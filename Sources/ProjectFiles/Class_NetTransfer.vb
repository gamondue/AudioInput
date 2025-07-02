Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Namespace SpectrumBands
    Public Class Class_NetTransfer

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
        Public Function Connect() As Boolean
            Try
                m_tcpClient = New TcpClient(m_serverAddress, m_serverPort)
                m_networkStream = m_tcpClient.GetStream()
                m_isConnected = True
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
                    ' Leggi dati dal client (per keepalive o comandi)
                    Dim bytesRead As Integer = clientStream.Read(buffer, 0, buffer.Length)
                    If bytesRead = 0 Then
                        ' Client disconnesso
                        Exit While
                    End If

                    ' Qui puoi elaborare eventuali comandi ricevuti dal client
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
    End Class
End Namespace

