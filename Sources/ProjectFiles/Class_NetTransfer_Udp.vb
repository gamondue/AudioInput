Imports System.Collections.Generic
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace NetTransfer
    Public Class NetTransfer_Udp
        ' Costanti per i tipi di messaggi
        Private Const MSG_TYPE_AUDIO_DATA As Byte = 0
        Private Const MSG_TYPE_NTP_REQUEST As Byte = 1
        Private Const MSG_TYPE_NTP_RESPONSE As Byte = 2
        Private Const MSG_TYPE_KEEPALIVE As Byte = 3
        Private Const MSG_TYPE_CLIENT_HELLO As Byte = 4
        Private Const MSG_TYPE_SERVER_ACK As Byte = 5

        ' UDP client principale
        Private m_udpClient As UdpClient
        Private m_localPort As Integer = 0
        Private m_receiveThread As Thread
        Private m_isRunning As Boolean = False

        ' Variabili modalità client
        Private m_serverEndPoint As IPEndPoint
        Private m_isConnected As Boolean = False
        Private m_sendEnabled As Boolean = True
        Private m_clientId As Guid = Guid.NewGuid()
        Private m_lastKeepAliveTime As DateTime = DateTime.MinValue

        ' Variabili modalità server
        Private m_isServerMode As Boolean = False
        Private m_clientsLock As New Object()
        Private m_clients As New Dictionary(Of String, ClientInfo)
        Private m_cleanupThread As Thread
        Private m_broadcastEnabled As Boolean = True

        ' Sincronizzazione NTP
        Private m_timeOffset As Long = 0
        Private m_lastSyncTime As DateTime = DateTime.MinValue

        Private m_syncHandlerAttachedUdp As Boolean = False

        ' Eventi 
        Public Event SyncCompleted(offsetMs As Long, roundTripMs As Long)
        'Public Event SyncCompleted As SyncCompletedEventHandler

        ' Eventi per notificare l'UI
        'Public Delegate Sub SyncCompletedEventHandler(offsetMs As Long, roundTripMs As Long)

        Public Event ClientConnected(clientId As String, endPoint As IPEndPoint)
        Public Event ClientDisconnected(clientId As String)
        Public Event ServerStatusChanged(isRunning As Boolean)
        Public Delegate Sub UdpClientEventHandler(clientId As String, endPointInfo As String)
        Public Delegate Sub UdpServerStatusEventHandler(isRunning As Boolean)
        Public Event UdpClientDisconnected As UdpClientEventHandler
        Public Event UdpServerStatusChanged As UdpServerStatusEventHandler

        ' Classe per memorizzare informazioni sui client
        Public Class ClientInfo
            Public Id As String
            Public EndPoint As IPEndPoint
            Public LastSeen As DateTime

            Public Sub New(id As String, endPoint As IPEndPoint)
                Me.Id = id
                Me.EndPoint = endPoint
                Me.LastSeen = DateTime.UtcNow
            End Sub
            ' override the ToString function
            Public Overrides Function ToString() As String
                Return EndPoint.Address.ToString()
            End Function
        End Class

#Region "Initialization and Cleanup"
        ' Costruttore per modalità client
        Public Sub New(serverAddress As String, serverPort As Integer)
            m_serverEndPoint = New IPEndPoint(IPAddress.Parse(serverAddress), serverPort)
            StartClient()
        End Sub

        ' Costruttore per modalità server
        Public Sub New(serverPort As Integer)
            m_localPort = serverPort
            m_isServerMode = True
            StartServer()
        End Sub
        Friend Sub StartClient()
            Try
                ' In modalità client, usa una porta casuale
                m_udpClient = New UdpClient(0)
                ' Avvia thread di ricezione
                m_isRunning = True
                m_receiveThread = New Thread(AddressOf ReceiveLoop)
                m_receiveThread.IsBackground = True
                m_receiveThread.Start()
            Catch ex As Exception
                If m_isServerMode Then
                    RaiseEvent ServerStatusChanged(False)
                End If
            End Try
            m_isRunning = True
            Connect()
        End Sub
        Friend Sub StopClient()
            Close()
        End Sub
        Friend Sub StartServer()
            Try
                ' In modalità server, associa alla porta specificata
                m_udpClient = New UdpClient(m_localPort)
                ' Avvia thread di ricezione
                m_isRunning = True
                m_receiveThread = New Thread(AddressOf ReceiveLoop)
                m_receiveThread.IsBackground = True
                m_receiveThread.Start()

                ' Avvia thread di pulizia client inattivi (solo server)
                If m_isServerMode Then
                    m_cleanupThread = New Thread(AddressOf CleanupInactiveClients)
                    m_cleanupThread.IsBackground = True
                    m_cleanupThread.Start()
                    RaiseEvent ServerStatusChanged(True)
                End If
            Catch ex As Exception
                m_isRunning = False
                If m_isServerMode Then
                    RaiseEvent ServerStatusChanged(False)
                End If
            End Try
        End Sub
        Friend Sub StopServer()
            Close()
        End Sub
        Public Sub Close()
            m_isRunning = False
            m_isConnected = False

            ' Chiudi il client UDP
            If m_udpClient IsNot Nothing Then
                m_udpClient.Close()
                m_udpClient = Nothing
            End If

            ' Ferma i thread
            If m_receiveThread IsNot Nothing AndAlso m_receiveThread.IsAlive Then
                m_receiveThread.Join(1000)
            End If

            If m_cleanupThread IsNot Nothing AndAlso m_cleanupThread.IsAlive Then
                m_cleanupThread.Join(1000)
            End If

            ' Notifica cambio stato server
            If m_isServerMode Then
                RaiseEvent ServerStatusChanged(False)
            End If
        End Sub
#End Region

#Region "Client Methods"
        ' Connetti al server (per client)
        Public Function Connect() As Boolean
            If Not m_isRunning OrElse m_isServerMode Then
                Return False
            End If
            Try
                ' Invia messaggio HELLO al server
                Dim msgBuffer(16) As Byte
                msgBuffer(0) = MSG_TYPE_CLIENT_HELLO
                Buffer.BlockCopy(m_clientId.ToByteArray(), 0, msgBuffer, 1, 16)
                m_udpClient.Send(msgBuffer, msgBuffer.Length, m_serverEndPoint)
                ' Imposta un timer per verificare la connessione
                Dim waitTimeout As DateTime = DateTime.UtcNow.AddSeconds(5)
                While DateTime.UtcNow < waitTimeout AndAlso Not m_isConnected
                    Thread.Sleep(100)
                End While
                Return m_isConnected
            Catch ex As Exception
                Return False
            End Try
        End Function

        ' Disconnetti dal server (per client)
        Public Sub Disconnect()
            m_isConnected = False
        End Sub

        ' Invia dati audio al server (per client)
        Public Function SendData(ByRef data() As Int16) As Boolean
            If Not m_isRunning OrElse Not m_isConnected OrElse Not m_sendEnabled Then
                Return False
            End If

            Try
                ' Converti array Int16 in array di byte
                Dim dataLength As Integer = data.Length * 2
                Dim packetSize As Integer = dataLength + 1 + 16  ' 1 byte tipo + 16 byte client ID
                Dim packet(packetSize - 1) As Byte
                ' Tipo messaggio
                packet(0) = MSG_TYPE_AUDIO_DATA
                ' ID client
                Buffer.BlockCopy(m_clientId.ToByteArray(), 0, packet, 1, 16)
                ' Dati audio
                Buffer.BlockCopy(data, 0, packet, 17, dataLength)
                ' Invia pacchetto
                m_udpClient.Send(packet, packet.Length, m_serverEndPoint)
                Return True
            Catch ex As Exception
                m_isConnected = False
                Return False
            End Try
        End Function

        ' Invia keepalive al server (per client)
        Private Sub SendKeepAlive()
            If Not m_isRunning OrElse Not m_isConnected Then
                Return
            End If

            ' Invia solo se non ci sono stati invii recenti
            If DateTime.UtcNow.Subtract(m_lastKeepAliveTime).TotalSeconds >= 5 Then
                Try
                    Dim msgBuffer(16) As Byte
                    msgBuffer(0) = MSG_TYPE_KEEPALIVE
                    Buffer.BlockCopy(m_clientId.ToByteArray(), 0, msgBuffer, 1, 16)

                    m_udpClient.Send(msgBuffer, msgBuffer.Length, m_serverEndPoint)
                    m_lastKeepAliveTime = DateTime.UtcNow
                Catch ex As Exception
                    m_isConnected = False
                End Try
            End If
        End Sub
#End Region

#Region "Server Methods"
        ' Invia risposta al client che si è connesso
        Private Sub SendServerAck(clientId As Guid, endPoint As IPEndPoint)
            Try
                Dim msgBuffer(16) As Byte
                msgBuffer(0) = MSG_TYPE_SERVER_ACK
                Buffer.BlockCopy(clientId.ToByteArray(), 0, msgBuffer, 1, 16)

                m_udpClient.Send(msgBuffer, msgBuffer.Length, endPoint)
            Catch ex As Exception
                ' Gestione errori
            End Try
        End Sub

        ' Broadcast dei dati audio a tutti i client connessi
        Public Sub BroadcastData(ByRef data() As Int16)
            If Not m_isRunning OrElse Not m_isServerMode OrElse Not m_broadcastEnabled Then
                Return
            End If

            SyncLock m_clientsLock
                If m_clients.Count = 0 Then
                    Return
                End If

                Try
                    ' Converti array Int16 in array di byte
                    Dim dataLength As Integer = data.Length * 2
                    Dim packetSize As Integer = dataLength + 1  ' 1 byte tipo
                    Dim packet(packetSize - 1) As Byte

                    ' Tipo messaggio
                    packet(0) = MSG_TYPE_AUDIO_DATA

                    ' Dati audio
                    Buffer.BlockCopy(data, 0, packet, 1, dataLength)

                    ' Invia a tutti i client
                    For Each client In m_clients.Values
                        m_udpClient.Send(packet, packet.Length, client.EndPoint)
                    Next
                Catch ex As Exception
                    ' Gestione errori
                End Try
            End SyncLock
        End Sub

        ' Thread per rimuovere client inattivi
        Private Sub CleanupInactiveClients()
            Try
                While m_isRunning AndAlso m_isServerMode
                    ' Attendi 10 secondi tra le verifiche
                    Thread.Sleep(10000)

                    SyncLock m_clientsLock
                        Dim currentTime As DateTime = DateTime.UtcNow
                        Dim inactiveClients As New List(Of String)

                        ' Trova client inattivi (30 secondi senza messaggi)
                        For Each client In m_clients
                            If currentTime.Subtract(client.Value.LastSeen).TotalSeconds > 30 Then
                                inactiveClients.Add(client.Key)
                            End If
                        Next

                        ' Rimuovi client inattivi
                        For Each clientId In inactiveClients
                            m_clients.Remove(clientId)
                            RaiseEvent ClientDisconnected(clientId)
                        Next
                    End SyncLock
                End While
            Catch ex As Exception
                ' Gestione errori
            End Try
        End Sub
#End Region

#Region "NTP Sync Methods"
        ' Richiesta di sincronizzazione NTP like (lato client)
        Friend Function RequestTimeSync() As Boolean
            If Not m_isRunning OrElse Not m_isConnected Then
                Return False
            End If

            Try
                ' Prepara pacchetto con:
                ' 1 byte per tipo messaggio + 16 byte per client ID + 8 byte per timestamp client
                Dim msgBuffer(24) As Byte
                msgBuffer(0) = MSG_TYPE_NTP_REQUEST

                ' ID client
                Buffer.BlockCopy(m_clientId.ToByteArray(), 0, msgBuffer, 1, 16)

                ' Timestamp corrente
                Dim t1 As Long = DateTime.UtcNow.Ticks
                Buffer.BlockCopy(BitConverter.GetBytes(t1), 0, msgBuffer, 17, 8)

                ' Invia richiesta
                m_udpClient.Send(msgBuffer, msgBuffer.Length, m_serverEndPoint)
            Catch ex As Exception
                m_isConnected = False
                Return False
            End Try
            Return True
        End Function

        ' Invia risposta di sincronizzazione (lato server)
        Private Sub SendTimeSyncResponse(clientId As Guid, clientTime As Long, receiveTime As Long, endPoint As IPEndPoint)
            Try
                ' Prepara pacchetto con:
                ' 1 byte per tipo + 16 byte per client ID + 8 byte per t1 + 8 byte per t2 + 8 byte per t3
                Dim msgBuffer(40) As Byte
                msgBuffer(0) = MSG_TYPE_NTP_RESPONSE

                ' ID client
                Buffer.BlockCopy(clientId.ToByteArray(), 0, msgBuffer, 1, 16)

                ' t1: tempo di invio client
                Buffer.BlockCopy(BitConverter.GetBytes(clientTime), 0, msgBuffer, 17, 8)

                ' t2: tempo di ricezione server
                Buffer.BlockCopy(BitConverter.GetBytes(receiveTime), 0, msgBuffer, 25, 8)

                ' t3: tempo di invio risposta server
                Dim t3 As Long = DateTime.UtcNow.Ticks
                Buffer.BlockCopy(BitConverter.GetBytes(t3), 0, msgBuffer, 33, 8)

                ' Invia risposta
                m_udpClient.Send(msgBuffer, msgBuffer.Length, endPoint)
            Catch ex As Exception
                ' Gestione errori
            End Try
        End Sub

        ' Processa messaggio di sincronizzazione NTP
        Private Sub ProcessTimeSyncMessage(buffer() As Byte, bytesRead As Integer, remoteEndPoint As IPEndPoint)
            If bytesRead < 1 Then
                Return
            End If

            Select Case buffer(0)
                Case MSG_TYPE_NTP_REQUEST
                    ' Server: risponde a richiesta di sincronizzazione
                    If bytesRead >= 25 AndAlso m_isServerMode Then
                        Dim clientId As New Guid(buffer.Skip(1).Take(16).ToArray())
                        Dim clientTime As Long = BitConverter.ToInt64(buffer, 17)
                        Dim receiveTime As Long = DateTime.UtcNow.Ticks

                        ' Aggiorna LastSeen del client
                        UpdateClientActivity(clientId.ToString(), remoteEndPoint)

                        SendTimeSyncResponse(clientId, clientTime, receiveTime, remoteEndPoint)
                    End If

                Case MSG_TYPE_NTP_RESPONSE
                    ' Client: elabora risposta di sincronizzazione
                    If bytesRead >= 41 AndAlso Not m_isServerMode Then
                        Dim receivedClientId As New Guid(buffer.Skip(1).Take(16).ToArray())

                        ' Verifica che la risposta sia per questo client
                        If receivedClientId.Equals(m_clientId) Then
                            ' Estrai timestamp
                            Dim t1 As Long = BitConverter.ToInt64(buffer, 17)  ' Tempo invio client
                            Dim t2 As Long = BitConverter.ToInt64(buffer, 25)  ' Tempo ricezione server
                            Dim t3 As Long = BitConverter.ToInt64(buffer, 33)  ' Tempo invio risposta server
                            Dim t4 As Long = DateTime.UtcNow.Ticks            ' Tempo ricezione client

                            ' Calcola offset e ritardo (in tick)
                            Dim roundTrip As Long = (t4 - t1) - (t3 - t2)
                            m_timeOffset = ((t2 - t1) + (t3 - t4)) \ 2

                            ' Converte in millisecondi
                            Dim roundTripMs As Long = roundTrip \ TimeSpan.TicksPerMillisecond
                            Dim offsetMs As Long = m_timeOffset \ TimeSpan.TicksPerMillisecond

                            m_lastSyncTime = DateTime.UtcNow

                            ' Notifica completamento
                            RaiseEvent SyncCompleted(offsetMs, roundTripMs)
                        End If
                    End If
            End Select
        End Sub
#End Region

#Region "Message Processing"
        ' Thread principale di ricezione messaggi
        Private Sub ReceiveLoop()
            Try
                While m_isRunning
                    Dim remoteEndPoint As New IPEndPoint(IPAddress.Any, 0)
                    Dim receivedData As Byte() = m_udpClient.Receive(remoteEndPoint)

                    If receivedData.Length > 0 Then
                        ProcessReceivedMessage(receivedData, receivedData.Length, remoteEndPoint)
                    End If
                End While
            Catch ex As Exception
                ' Gestione errori o chiusura socket
                m_isRunning = False
                m_isConnected = False
            End Try
        End Sub

        ' Elabora i messaggi ricevuti
        Private Sub ProcessReceivedMessage(buffer() As Byte, bytesRead As Integer, remoteEndPoint As IPEndPoint)
            If bytesRead < 1 Then
                Return
            End If

            Select Case buffer(0)
                Case MSG_TYPE_AUDIO_DATA
                    ' Elabora dati audio (in server mode)
                    If m_isServerMode AndAlso bytesRead > 17 Then
                        Dim clientId As New Guid(buffer.Skip(1).Take(16).ToArray())
                        UpdateClientActivity(clientId.ToString(), remoteEndPoint)

                        ' Qui è possibile implementare la logica per elaborare i dati audio
                        ' Esempio: ritrasmettere a tutti i client (relay audio)
                    End If

                Case MSG_TYPE_NTP_REQUEST, MSG_TYPE_NTP_RESPONSE
                    ' Gestito nella funzione dedicata
                    ProcessTimeSyncMessage(buffer, bytesRead, remoteEndPoint)

                Case MSG_TYPE_KEEPALIVE
                    ' Aggiorna attività client
                    If m_isServerMode AndAlso bytesRead >= 17 Then
                        Dim clientId As New Guid(buffer.Skip(1).Take(16).ToArray())
                        UpdateClientActivity(clientId.ToString(), remoteEndPoint)
                    End If

                Case MSG_TYPE_CLIENT_HELLO
                    ' Solo server: registra nuovo client
                    If m_isServerMode AndAlso bytesRead >= 17 Then
                        Dim clientId As New Guid(buffer.Skip(1).Take(16).ToArray())
                        Dim clientIdStr As String = clientId.ToString()

                        ' Registra o aggiorna client
                        UpdateClientActivity(clientIdStr, remoteEndPoint)

                        ' Invia ACK al client
                        SendServerAck(clientId, remoteEndPoint)

                        ' Notifica connessione client
                        RaiseEvent ClientConnected(clientIdStr, remoteEndPoint)
                    End If

                Case MSG_TYPE_SERVER_ACK
                    ' Solo client: conferma connessione
                    If Not m_isServerMode AndAlso bytesRead >= 17 Then
                        Dim receivedClientId As New Guid(buffer.Skip(1).Take(16).ToArray())

                        ' Verifica che l'ACK sia per questo client
                        If receivedClientId.Equals(m_clientId) Then
                            m_isConnected = True
                            m_serverEndPoint = remoteEndPoint
                            m_lastKeepAliveTime = DateTime.UtcNow
                        End If
                    End If
            End Select
        End Sub

        ' Aggiorna lo stato di attività di un client
        Private Sub UpdateClientActivity(clientId As String, endPoint As IPEndPoint)
            If Not m_isServerMode Then
                Return
            End If

            SyncLock m_clientsLock
                If m_clients.ContainsKey(clientId) Then
                    m_clients(clientId).LastSeen = DateTime.UtcNow
                    m_clients(clientId).EndPoint = endPoint  ' Aggiorna endpoint nel caso sia cambiato
                Else
                    ' Nuovo client
                    m_clients.Add(clientId, New ClientInfo(clientId, endPoint))
                    RaiseEvent ClientConnected(clientId, endPoint)
                End If
            End SyncLock
        End Sub
#End Region

#Region "Properties"
        Public Property IsServer() As Boolean
            Get
                Return m_isServerMode
            End Get
            Set(value As Boolean)
                m_isServerMode = value
            End Set
        End Property
        Public ReadOnly Property IsConnected() As Boolean
            Get
                ' Per client: connesso al server
                If Not m_isServerMode Then
                    ' Invia keepalive se necessario
                    If m_isConnected AndAlso DateTime.UtcNow.Subtract(m_lastKeepAliveTime).TotalSeconds >= 5 Then
                        SendKeepAlive()
                    End If
                    Return m_isConnected
                Else
                    ' Per server: in esecuzione
                    Return m_isRunning
                End If
            End Get
        End Property
        Public Property SendEnabled() As Boolean
            Get
                Return m_sendEnabled
            End Get
            Set(value As Boolean)
                m_sendEnabled = value
            End Set
        End Property
        Public ReadOnly Property IsServerRunning() As Boolean
            Get
                Return m_isRunning AndAlso m_isServerMode
            End Get
        End Property
        Public ReadOnly Property NConnectedClients() As Integer
            Get
                If Not m_isServerMode Then
                    Return 0
                End If

                SyncLock m_clientsLock
                    Return m_clients.Count
                End SyncLock
            End Get
        End Property
        Public ReadOnly Property ConnectedClients() As List(Of ClientInfo)
            Get
                If Not m_isServerMode Then
                    Return New List(Of ClientInfo)
                End If
                SyncLock m_clientsLock
                    Return m_clients.Values.ToList()
                End SyncLock
            End Get
        End Property
        Public Property BroadcastEnabled() As Boolean
            Get
                Return m_broadcastEnabled
            End Get
            Set(value As Boolean)
                m_broadcastEnabled = value
            End Set
        End Property
#End Region

#Region "UDP Methods"
        'Friend Sub Initialize(Optional ByVal tcpServerAddress As String = "127.0.0.1",
        '             Optional ByVal tcpServerPort As Integer = 8080)
        '    CloseAll()
        '    ' Inizializza la connessione UDP client
        '    m_netTransferUdp = New NetTransfer_Udp(tcpServerAddress, tcpServerPort)
        '    m_netTransferUdp.Connect()
        'End Sub

        '' Metodo per chiudere la connessione UDP
        'Friend Sub CloseAll()
        '    If m_netTransferUdp IsNot Nothing Then
        '        m_netTransferUdp.Close()
        '        m_netTransferUdp = Nothing
        '    End If
        'End Sub

        ' Metodo per avviare un server UDP
        'Friend Function StartServer(port As Integer) As Boolean
        '    If m_netTransferUdp IsNot Nothing Then
        '        m_netTransferUdp.Close()
        '    End If

        '    Try
        '        m_netTransferUdp = New NetTransfer_Udp(port)
        '        AddHandler m_netTransferUdp.ClientConnected, AddressOf OnClientConnected
        '        AddHandler m_netTransferUdp.ClientDisconnected, AddressOf OnClientDisconnected
        '        AddHandler m_netTransferUdp.ServerStatusChanged, AddressOf OnServerStatusChanged
        '        Return True
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End Function

        '' Metodo per fermare il server UDP
        'Friend Sub StopUdpServer()
        '    If m_netTransferUdp IsNot Nothing Then
        '        m_netTransferUdp.Close()
        '        m_netTransferUdp = Nothing
        '    End If
        'End Sub
        ' Handler eventi server
        Private Sub OnClientConnected(clientId As String, endPoint As IPEndPoint)
            ' Qui puoi notificare l'UI della connessione di un nuovo client
            RaiseEvent ClientConnected(clientId, endPoint)
        End Sub
        Private Sub OnClientDisconnected(clientId As String)
            ' Qui puoi notificare l'UI della disconnessione di un client
            RaiseEvent ClientDisconnected(clientId)
        End Sub
        Private Sub OnServerStatusChanged(isRunning As Boolean)
            ' Qui puoi notificare l'UI del cambio di stato del server
            RaiseEvent UdpServerStatusChanged(isRunning)
        End Sub

#End Region

#Region "Time sync Methods"
        ' Variabile per tenere traccia degli handler di eventi
        Private m_syncHandlerAttached As Boolean = False

        ' Callback quando la sincronizzazione è completata
        Private Sub OnSyncCompleted(offsetMs As Long, roundTripMs As Long)
            ' Notifica UI della sincronizzazione completata
            RaiseEvent SyncCompleted(offsetMs, roundTripMs)
        End Sub
        ' Ottieni timestamp sincronizzato
        Public Function GetSynchronizedTime() As DateTime
            If m_lastSyncTime = DateTime.MinValue Then
                Return DateTime.UtcNow
            End If
            Return DateTime.UtcNow.AddTicks(m_timeOffset)
        End Function
        Friend Sub ToggleServer(checked As Boolean)
            Throw New NotImplementedException()
        End Sub
        ' !!!! UTILIZZAZIONE !!!!
        ' Ottieni il tempo sincronizzato
        'Friend Function GetSynchronizedTime() As DateTime
        '    If m_netTransfer IsNot Nothing Then
        '        Return m_netTransfer.GetSynchronizedTime()
        '    Else
        '        Return DateTime.UtcNow
        '    End If
        'End Function
        ' Richiedi sincronizzazione NTP
        'Friend Function RequestNTPSync() As Boolean
        '    If m_netTransfer Is Nothing OrElse Not m_netTransfer.IsConnected Then
        '        Return False
        '    End If

        '    ' Aggiunge handler per l'evento di completamento, se non già fatto
        '    If Not m_syncHandlerAttached Then
        '        AddHandler m_netTransfer.SyncCompleted, AddressOf OnSyncCompleted
        '        m_syncHandlerAttached = True
        '    End If

        '    ' Invia richiesta di sincronizzazione
        '    m_netTransfer.RequestTimeSync()
        '    Return True
        'End Function

        ' Richiedi sincronizzazione NTP via UDP
        Friend Function RequestNTPSync() As Boolean
            If Not IsConnected Then
                Return False
            End If

            ' Aggiunge handler per l'evento di completamento, se non già fatto
            If Not m_syncHandlerAttachedUdp Then
                AddHandler SyncCompleted, AddressOf OnSyncCompleted
                m_syncHandlerAttachedUdp = True
            End If

            ' Invia richiesta di sincronizzazione
            RequestTimeSync()
            Return True
        End Function
#End Region

    End Class
End Namespace
