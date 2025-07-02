Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace SpectrumBands
    Public Class Class_NetTransferTCP

        ' Proprietà e variabili per la modalità client
        Private m_tcpClient As TcpClient
        Private m_networkStream As NetworkStream
        Private m_serverAddress As String
        Private m_serverPort As Integer
        Private m_isConnected As Boolean = False
        Private m_sendEnabled As Boolean = True

        ' Proprietà e variabili per la modalità server
        Private m_tcpListener As TcpListener
        Private m_isServerRunning As Boolean = False
        Private m_listenThread As Thread
        Private m_clients As New List(Of TcpClient)
        Private m_clientsLock As New Object()
        Private m_serverPort_Listen As Integer = 8080

        ' Costruttore per modalità client
        Public Sub New(serverAddress As String, serverPort As Integer)
            m_serverAddress = serverAddress
            m_serverPort = serverPort
        End Sub

        ' Costruttore per modalità server
        Public Sub New()
            ' Inizializzazione senza parametri per quando si usa solo come server
        End Sub

#Region "Client Methods"
        ' quando si esegue Connect si avvia il thread di ascolto client
        Public Function Connect() As Boolean
            Try
                m_tcpClient = New TcpClient(m_serverAddress, m_serverPort)
                m_networkStream = m_tcpClient.GetStream()
                m_isConnected = True

                ' Avvia thread per ricevere risposte dal server
                Dim clientThread As New Thread(AddressOf ClientReceiveLoop)
                clientThread.IsBackground = True
                clientThread.Start()

                Return True
            Catch ex As Exception
                m_isConnected = False
                Return False
            End Try
        End Function

        Public Sub Disconnect()
            If m_isConnected Then
                m_networkStream.Close()
                m_tcpClient.Close()
                m_isConnected = False
            End If
        End Sub

        Public Function SendData(ByRef data() As Int16) As Boolean
            If Not m_isConnected OrElse Not m_sendEnabled Then
                Return False
            End If

            Try
                ' Converti array Int16 in array di byte
                Dim byteArray(data.Length * 2 - 1) As Byte
                Buffer.BlockCopy(data, 0, byteArray, 0, byteArray.Length)

                ' Invia prima la lunghezza dei dati (4 byte per int32)
                Dim lengthBytes() As Byte = BitConverter.GetBytes(byteArray.Length)
                m_networkStream.Write(lengthBytes, 0, lengthBytes.Length)

                ' Invia i dati effettivi
                m_networkStream.Write(byteArray, 0, byteArray.Length)
                m_networkStream.Flush()

                Return True
            Catch ex As Exception
                m_isConnected = False
                Return False
            End Try
        End Function
#End Region

#Region "Server Methods"
        Public Function StartServer(Optional port As Integer = 8080) As Boolean
            If m_isServerRunning Then
                StopServer()
            End If

            Try
                m_serverPort_Listen = port
                m_tcpListener = New TcpListener(IPAddress.Any, m_serverPort_Listen)
                m_tcpListener.Start()
                m_isServerRunning = True

                ' Avvia thread per ascolto connessioni
                m_listenThread = New Thread(AddressOf ListenForClients)
                m_listenThread.IsBackground = True
                m_listenThread.Start()

                Return True
            Catch ex As Exception
                m_isServerRunning = False
                Return False
            End Try
        End Function

        Public Sub StopServer()
            If m_isServerRunning Then
                m_isServerRunning = False

                ' Chiudi il listener
                If m_tcpListener IsNot Nothing Then
                    m_tcpListener.Stop()
                End If

                ' Termina il thread di ascolto
                If m_listenThread IsNot Nothing AndAlso m_listenThread.IsAlive Then
                    m_listenThread.Join(1000)  ' Attendi che il thread termini
                End If

                ' Chiudi tutte le connessioni client
                SyncLock m_clientsLock
                    For Each client As TcpClient In m_clients
                        Try
                            client.Close()
                        Catch
                            ' Ignora eventuali errori durante la chiusura
                        End Try
                    Next
                    m_clients.Clear()
                End SyncLock
            End If
        End Sub

        Private Sub ListenForClients()
            Try
                While m_isServerRunning
                    ' Attendi connessione client in modo asincrono
                    Dim client As TcpClient = m_tcpListener.AcceptTcpClient()

                    ' Aggiungi client alla lista
                    SyncLock m_clientsLock
                        m_clients.Add(client)
                    End SyncLock

                    ' Avvia un thread per gestire questo client
                    Dim clientThread As New Thread(AddressOf HandleClientComm)
                    clientThread.IsBackground = True
                    clientThread.Start(client)
                End While
            Catch ex As Exception
                ' Potrebbe verificarsi un'eccezione quando si chiude il server, ignoriamo
            End Try
        End Sub

        Private Sub HandleClientComm(ByVal client As Object)
            Dim tcpClient As TcpClient = DirectCast(client, TcpClient)
            Dim clientStream As NetworkStream = tcpClient.GetStream()
            Dim buffer(4095) As Byte

            Try
                While m_isServerRunning
                    ' Leggi dati dal client
                    Dim bytesRead As Integer = clientStream.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then
                        ' Client disconnesso
                        Exit While
                    End If

                    ' Controlla se è un messaggio di sincronizzazione
                    If bytesRead > 0 AndAlso (buffer(0) = MSG_TYPE_NTP_REQUEST OrElse buffer(0) = MSG_TYPE_NTP_RESPONSE) Then
                        ProcessTimeSyncMessage(buffer, bytesRead, tcpClient)
                    Else
                        ' Elabora altri tipi di messaggi
                        ' ...
                    End If
                End While
            Catch ex As Exception
                ' Errore di comunicazione o client disconnesso
            Finally
                ' Rimuovi client dalla lista quando si disconnette
                SyncLock m_clientsLock
                    m_clients.Remove(tcpClient)
                End SyncLock

                ' Chiudi la connessione
                tcpClient.Close()
            End Try
        End Sub

        Public Sub BroadcastData(ByRef data() As Int16)
            If Not m_isServerRunning OrElse m_clients.Count = 0 Then
                Return
            End If

            Try
                ' Converti array Int16 in array di byte
                Dim byteArray(data.Length * 2 - 1) As Byte
                Buffer.BlockCopy(data, 0, byteArray, 0, byteArray.Length)

                ' Prepara header con lunghezza
                Dim lengthBytes() As Byte = BitConverter.GetBytes(byteArray.Length)

                ' Invia a tutti i client connessi
                Dim disconnectedClients As New List(Of TcpClient)

                SyncLock m_clientsLock
                    For Each client As TcpClient In m_clients
                        Try
                            Dim stream As NetworkStream = client.GetStream()

                            ' Invia la lunghezza
                            stream.Write(lengthBytes, 0, lengthBytes.Length)

                            ' Invia i dati
                            stream.Write(byteArray, 0, byteArray.Length)
                            stream.Flush()
                        Catch ex As Exception
                            ' Segna client per la rimozione
                            disconnectedClients.Add(client)
                        End Try
                    Next

                    ' Rimuovi client disconnessi
                    For Each client As TcpClient In disconnectedClients
                        m_clients.Remove(client)
                        client.Close()
                    Next
                End SyncLock
            Catch ex As Exception
                ' Gestione errori durante il broadcast
            End Try
        End Sub
#End Region

#Region "Properties"
        Public ReadOnly Property IsConnected() As Boolean
            Get
                Return m_isConnected
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

        Public Property ServerAddress() As String
            Get
                Return m_serverAddress
            End Get
            Set(value As String)
                m_serverAddress = value
            End Set
        End Property

        Public Property ServerPort() As Integer
            Get
                Return m_serverPort
            End Get
            Set(value As Integer)
                m_serverPort = value
            End Set
        End Property

        Public ReadOnly Property IsServerRunning() As Boolean
            Get
                Return m_isServerRunning
            End Get
        End Property

        Public ReadOnly Property ConnectedClients() As Integer
            Get
                SyncLock m_clientsLock
                    Return m_clients.Count
                End SyncLock
            End Get
        End Property
#End Region
#Region "NTP Sync Methods"
        ' implementazione di un protocollo di sincronizzazione temporale semplificato basato sui principi di NTP:
        '1.	Il client invia una richiesta di sincronizzazione con il proprio timestamp (T1)
        '2.	Il server riceve la richiesta, registra il suo timestamp (T2) e invia una risposta con entrambi i timestamp più il timestamp di risposta (T3)
        '3.	Il client riceve la risposta e registra il suo timestamp (T4)
        '4.	Il client calcola l'offset di tempo e il ritardo di round trip

        Private Const MSG_TYPE_NTP_REQUEST As Byte = 1
        Private Const MSG_TYPE_NTP_RESPONSE As Byte = 2

        ' Offset calcolato per sincronizzazione
        Private m_timeOffset As Long = 0
        Private m_lastSyncTime As DateTime = DateTime.MinValue

        ' Evento per notificare sincronizzazione completata
        Public Event SyncCompleted(offsetMs As Long, roundTripMs As Long)

        ' Richiedi sincronizzazione NTP (lato client)
        Public Sub RequestTimeSync()
            If Not m_isConnected Then
                Return
            End If

            Try
                ' Prepara pacchetto con:
                ' 1 byte per tipo messaggio + 8 byte per timestamp client
                Dim msgBuffer(8) As Byte
                msgBuffer(0) = MSG_TYPE_NTP_REQUEST

                ' Ottieni timestamp corrente
                Dim t1 As Long = DateTime.UtcNow.Ticks
                Buffer.BlockCopy(BitConverter.GetBytes(t1), 0, msgBuffer, 1, 8)

                ' Invia richiesta
                m_networkStream.Write(msgBuffer, 0, msgBuffer.Length)
                m_networkStream.Flush()
            Catch ex As Exception
                m_isConnected = False
            End Try
        End Sub

        ' Invia risposta di sincronizzazione (lato server)
        Private Sub SendTimeSyncResponse(clientTime As Long, receiveTime As Long, clientEndpoint As TcpClient)
            Try
                ' Prepara pacchetto con:
                ' 1 byte per tipo messaggio + 8 byte per t1 + 8 byte per t2 + 8 byte per t3
                Dim msgBuffer(24) As Byte
                msgBuffer(0) = MSG_TYPE_NTP_RESPONSE

                ' t1: tempo di invio client
                Buffer.BlockCopy(BitConverter.GetBytes(clientTime), 0, msgBuffer, 1, 8)

                ' t2: tempo di ricezione server
                Buffer.BlockCopy(BitConverter.GetBytes(receiveTime), 0, msgBuffer, 9, 8)

                ' t3: tempo di invio risposta server
                Dim t3 As Long = DateTime.UtcNow.Ticks
                Buffer.BlockCopy(BitConverter.GetBytes(t3), 0, msgBuffer, 17, 8)

                ' Invia risposta
                Dim stream As NetworkStream = clientEndpoint.GetStream()
                stream.Write(msgBuffer, 0, msgBuffer.Length)
                stream.Flush()
            Catch ex As Exception
                ' Gestione errori
            End Try
        End Sub

        ' Processo di sincronizzazione NTP (ricezione dati)
        Private Sub ProcessTimeSyncMessage(buffer() As Byte, bytesRead As Integer, clientEndpoint As TcpClient)
            If bytesRead < 1 Then Return

            Select Case buffer(0)
                Case MSG_TYPE_NTP_REQUEST
                    ' Server: risponde a richiesta di sincronizzazione
                    If bytesRead >= 9 Then
                        Dim clientTime As Long = BitConverter.ToInt64(buffer, 1)
                        Dim receiveTime As Long = DateTime.UtcNow.Ticks
                        SendTimeSyncResponse(clientTime, receiveTime, clientEndpoint)
                    End If

                Case MSG_TYPE_NTP_RESPONSE
                    ' Client: elabora risposta di sincronizzazione
                    If bytesRead >= 25 Then
                        ' Estrai timestamp
                        Dim t1 As Long = BitConverter.ToInt64(buffer, 1)  ' Tempo invio client
                        Dim t2 As Long = BitConverter.ToInt64(buffer, 9)  ' Tempo ricezione server
                        Dim t3 As Long = BitConverter.ToInt64(buffer, 17) ' Tempo invio risposta server
                        Dim t4 As Long = DateTime.UtcNow.Ticks           ' Tempo ricezione client

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
            End Select
        End Sub

        ' Ottieni timestamp sincronizzato
        Public Function GetSynchronizedTime() As DateTime
            If m_lastSyncTime = DateTime.MinValue Then
                Return DateTime.UtcNow
            End If

            Return DateTime.UtcNow.AddTicks(m_timeOffset)
        End Function
#End Region
#Region "Client side network messages monitoring"

        ' Thread di ascolto per client
        Private Sub ClientReceiveLoop()
            Dim buffer(4095) As Byte

            Try
                While m_isConnected
                    Dim bytesRead As Integer = m_networkStream.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then
                        ' Server disconnesso
                        m_isConnected = False
                        Exit While
                    End If

                    ' Controlla se è un messaggio di sincronizzazione
                    If bytesRead > 0 AndAlso (buffer(0) = MSG_TYPE_NTP_REQUEST OrElse buffer(0) = MSG_TYPE_NTP_RESPONSE) Then
                        ProcessTimeSyncMessage(buffer, bytesRead, m_tcpClient)
                    Else
                        ' Elabora altri tipi di messaggi
                        ' ...
                    End If
                End While
            Catch ex As Exception
                m_isConnected = False
            End Try
        End Sub
#End Region
    End Class
End Namespace

