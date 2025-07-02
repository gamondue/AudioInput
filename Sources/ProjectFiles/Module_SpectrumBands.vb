Imports System.Drawing.Drawing2D
Imports System.Net

Namespace SpectrumBands
    Module SpectrumBands

        ' ----------------------------------------------------------------------------------------
        '  If this class is primarly used for applications similar to psychedelic lights 
        '  it is better to increase the response with a short input buffer (and fourier samples)
        '  this is done at the expense of the low frequency resolution.
        '  A very short buffer is 2048 bytes and produces a delay of 46 mS
        '  A medium buffer is 4096 bytes and produces a delay of 92 mS
        '  A good bass frequency resolution 8192 buffer has a delay = 185 mS
        ' ----------------------------------------------------------------------------------------

        Private m_FourierSamples As Int32 = 2048 ' 8192 with 44100 or 16384 with 88200 or 32768 with 176400
        Private m_SamplesPerSec As Int32 = 44100 ' 44100 or 176400 or 192000 or 198450
        Private m_Channels As Int32 = 1
        Private m_NumBuffers As Int32 = 4
        Private m_LenBuffers As Int32 = 4096

        Private m_fifo As FIFO = New FIFO(16000)
        Friend m_fht As FHT = New FHT
        Private m_Recorder As AudioIn
        Private m_InputBuffer() As Int16

        Private m_netTransfer As Class_NetTransferTCP

        Private m_ddx As Int32
        Private m_ddy As Int32
        Private m_fmin As Single
        Private m_fmax As Single
        Private m_dbmin As Single
        Private m_dbmax As Single
        Private m_xlog As Boolean
        Private m_ylog As Boolean
        Private m_windowtype As FHT.WindowTypes

        Private m_fillBrush As LinearGradientBrush
        Private m_TextBrush As Brush = Brushes.Azure

        Private m_netTransferUdp As Class_NetTransfer_Udp
        Private m_syncHandlerAttachedUdp As Boolean = False
        ' modificato per usare UDP
        Private Sub DataArrived(ByRef data() As Int16)
            m_fifo.AddArray(data)

            ' Invia i dati al server UDP se siamo connessi come client
            If m_netTransferUdp IsNot Nothing AndAlso m_netTransferUdp.IsConnected AndAlso Not m_netTransferUdp.IsServerRunning Then
                m_netTransferUdp.SendData(data)
            End If

            ' Invia i dati a tutti i client connessi se il server è attivo
            If m_netTransferUdp IsNot Nothing AndAlso m_netTransferUdp.IsServerRunning Then
                m_netTransferUdp.BroadcastData(data)
            End If
        End Sub

        ' Richiedi sincronizzazione NTP via UDP
        Friend Function RequestNTPSyncUdp() As Boolean
            If m_netTransferUdp Is Nothing OrElse Not m_netTransferUdp.IsConnected Then
                Return False
            End If

            ' Aggiunge handler per l'evento di completamento, se non già fatto
            If Not m_syncHandlerAttachedUdp Then
                AddHandler m_netTransferUdp.SyncCompleted, AddressOf OnSyncCompleted
                m_syncHandlerAttachedUdp = True
            End If

            ' Invia richiesta di sincronizzazione
            m_netTransferUdp.RequestTimeSync()
            Return True
        End Function

        Private Function CreateFillBrush(ByVal pbox As PictureBox,
                                         ByVal direction As LinearGradientMode) As LinearGradientBrush
            CreateFillBrush = New LinearGradientBrush(pbox.ClientRectangle,
                                                      Color.Black,
                                                      Color.Black,
                                                      direction)
            Dim myBlend As ColorBlend = New ColorBlend()
            myBlend.Colors = New Color() {Color.FromArgb(255, 0, 0),
                                          Color.FromArgb(255, 230, 0),
                                          Color.FromArgb(250, 250, 0),
                                          Color.FromArgb(230, 230, 0),
                                          Color.FromArgb(0, 120, 0)}
            myBlend.Positions = New Single() {0.0F, 0.4F, 0.5F, 0.6F, 1.0F}
            CreateFillBrush.InterpolationColors = myBlend
        End Function

        Friend Sub Initialize(ByVal pbox As PictureBox, ByVal InputDeviceIndex As Int32,
                             Optional ByVal tcpServerAddress As String = "localhost",
                             Optional ByVal tcpServerPort As Integer = 8080)
            CloseAll()
            ReDim m_InputBuffer(m_FourierSamples - 1)
            m_fillBrush = CreateFillBrush(pbox, LinearGradientMode.Vertical)
            m_Recorder = New AudioIn()
            m_Recorder.InputOn(InputDeviceIndex,
                               m_SamplesPerSec,
                               m_Channels,
                               m_LenBuffers,
                               m_NumBuffers,
                               New AudioIn.BufferDoneEventHandler(AddressOf DataArrived))

            ' Inizializza la connessione TCP
            m_netTransfer = New Class_NetTransferTCP(tcpServerAddress, tcpServerPort)
            m_netTransfer.Connect()
        End Sub

        Friend Sub CloseAll()
            If m_Recorder IsNot Nothing Then
                m_Recorder.InputOff()
                m_Recorder = Nothing
            End If

            If m_netTransfer IsNot Nothing Then
                m_netTransfer.Disconnect()
                m_netTransfer = Nothing
            End If
        End Sub

        Friend Sub Update(ByVal pbox As PictureBox,
                          ByVal fmin As Single,
                          ByVal fmax As Single,
                          ByVal dbmin As Single,
                          ByVal dbmax As Single,
                          ByVal xlog As Boolean,
                          ByVal ylog As Boolean,
                          ByVal speed As Single,
                          ByVal windowtype As FHT.WindowTypes,
                          ByVal NumBands As Int32,
                          ByVal AGC As Boolean)

            If m_Recorder Is Nothing Then Return


            If pbox.Image Is Nothing OrElse pbox.Image.Width <> m_ddx OrElse
                                    pbox.Image.Height <> m_ddy OrElse
                                    fmin <> m_fmin OrElse
                                    fmax <> m_fmax OrElse
                                    dbmin <> m_dbmin OrElse
                                    dbmax <> m_dbmax OrElse
                                    xlog <> m_xlog OrElse
                                    ylog <> m_ylog OrElse
                                    windowtype <> m_windowtype Then

                InitPictureboxImage(pbox)

                m_ddx = pbox.Image.Width
                m_ddy = pbox.Image.Height
                m_fmin = fmin
                m_fmax = fmax
                m_dbmin = dbmin
                m_dbmax = dbmax
                m_xlog = xlog
                m_ylog = ylog
                m_windowtype = windowtype
                speed = 1
            End If

            Dim g As Graphics = Graphics.FromImage(pbox.Image)
            g.Clear(Color.FromArgb(60, 60, 60))

            If dbmin >= dbmax Or fmin >= fmax Or fmax >= m_SamplesPerSec \ 2 Then
                g.DrawString("Invalid params", New Font("Arial", 11), m_TextBrush, 10, 10)
                pbox.Invalidate()
                Return
            End If

            m_fifo.SetReadIndex(m_fifo.GetWriteIndex - m_InputBuffer.Length)
            m_fifo.GetArray(m_InputBuffer)
            m_fht.ExecuteFHT(m_InputBuffer, CType(m_windowtype, FHT.WindowTypes))
            m_fht.ExtractBands(NumBands, fmin, fmax, dbmin, dbmax, xlog, ylog, m_SamplesPerSec, speed, AGC)

            Dim x As Single
            Dim h As Int32 = pbox.Image.Height
            Dim bandspacing As Single = CSng(pbox.Image.Width / NumBands)
            Dim bandsize As Single = bandspacing - 1
            If bandspacing < 4 Then bandsize = bandspacing
            For b As Int32 = 0 To NumBands - 1
                x = b * bandspacing
                g.FillRectangle(m_fillBrush, x + 1, h * (1 - m_fht.BandsBuffer(b)), bandsize, h)
            Next

            pbox.Invalidate()
        End Sub

        Friend Sub ToggleServer(isServerEnabled As Boolean, Optional serverPort As Integer = 8080)
            If isServerEnabled Then
                ' Avvia il server se non è già in esecuzione
                If m_netTransfer Is Nothing Then
                    m_netTransfer = New Class_NetTransferTCP()
                End If

                If Not m_netTransfer.IsServerRunning Then
                    m_netTransfer.StartServer(serverPort)
                End If
            Else
                ' Ferma il server se è in esecuzione
                If m_netTransfer IsNot Nothing AndAlso m_netTransfer.IsServerRunning Then
                    m_netTransfer.StopServer()
                End If
            End If
        End Sub

#Region "Time sync Methods"
        ' Variabile per tenere traccia degli handler di eventi
        Private m_syncHandlerAttached As Boolean = False

        ' Richiedi sincronizzazione NTP
        Friend Function RequestNTPSync() As Boolean
            If m_netTransfer Is Nothing OrElse Not m_netTransfer.IsConnected Then
                Return False
            End If

            ' Aggiunge handler per l'evento di completamento, se non già fatto
            If Not m_syncHandlerAttached Then
                AddHandler m_netTransfer.SyncCompleted, AddressOf OnSyncCompleted
                m_syncHandlerAttached = True
            End If

            ' Invia richiesta di sincronizzazione
            m_netTransfer.RequestTimeSync()
            Return True
        End Function

        '' Callback quando la sincronizzazione è completata
        'Private Sub OnSyncCompleted(offsetMs As Long, roundTripMs As Long)
        '    ' Qui puoi aggiungere codice per notificare l'UI del completamento
        '    ' Ad esempio, aggiornare una label con le informazioni di sincronizzazione
        '    ' O chiamare un delegato/evento per notificare il form

        '    ' Esempio: potremmo esporre un evento pubblico
        '    RaiseSyncCompletedEvent(offsetMs, roundTripMs)
        'End Sub

        ' Metodo per sollevare l'evento
        Private Sub RaiseSyncCompletedEvent(offsetMs As Long, roundTripMs As Long)
            RaiseEvent SyncCompleted(offsetMs, roundTripMs)
        End Sub

        ' Ottieni il tempo sincronizzato
        Friend Function GetSynchronizedTime() As DateTime
            If m_netTransfer IsNot Nothing Then
                Return m_netTransfer.GetSynchronizedTime()
            Else
                Return DateTime.UtcNow
            End If
        End Function
#End Region

#Region "UDP Methods"
        Friend Sub InitializeUdp(ByVal pbox As PictureBox, ByVal InputDeviceIndex As Int32,
                     Optional ByVal tcpServerAddress As String = "127.0.0.1",
                     Optional ByVal tcpServerPort As Integer = 8080)
            CloseAllUdp()
            ReDim m_InputBuffer(m_FourierSamples - 1)
            m_fillBrush = CreateFillBrush(pbox, LinearGradientMode.Vertical)
            m_Recorder = New AudioIn()
            m_Recorder.InputOn(InputDeviceIndex,
                       m_SamplesPerSec,
                       m_Channels,
                       m_LenBuffers,
                       m_NumBuffers,
                       New AudioIn.BufferDoneEventHandler(AddressOf DataArrived))

            ' Inizializza la connessione UDP client
            m_netTransferUdp = New Class_NetTransfer_Udp(tcpServerAddress, tcpServerPort)
            m_netTransferUdp.Connect()
        End Sub

        ' Metodo per chiudere la connessione UDP
        Friend Sub CloseAllUdp()
            If m_Recorder IsNot Nothing Then
                m_Recorder.InputOff()
                m_Recorder = Nothing
            End If

            If m_netTransferUdp IsNot Nothing Then
                m_netTransferUdp.Close()
                m_netTransferUdp = Nothing
            End If
        End Sub

        ' Metodo per avviare un server UDP
        Friend Function StartUdpServer(port As Integer) As Boolean
            If m_netTransferUdp IsNot Nothing Then
                m_netTransferUdp.Close()
            End If

            Try
                m_netTransferUdp = New Class_NetTransfer_Udp(port)
                AddHandler m_netTransferUdp.ClientConnected, AddressOf OnClientConnected
                AddHandler m_netTransferUdp.ClientDisconnected, AddressOf OnClientDisconnected
                AddHandler m_netTransferUdp.ServerStatusChanged, AddressOf OnServerStatusChanged
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Function

        ' Metodo per fermare il server UDP
        Friend Sub StopUdpServer()
            If m_netTransferUdp IsNot Nothing Then
                m_netTransferUdp.Close()
                m_netTransferUdp = Nothing
            End If
        End Sub
        ' Handler eventi server
        Private Sub OnClientConnected(clientId As String, endPoint As IPEndPoint)
            ' Qui puoi notificare l'UI della connessione di un nuovo client
            RaiseEvent UdpClientConnected(clientId, endPoint.ToString())
        End Sub

        Private Sub OnClientDisconnected(clientId As String)
            ' Qui puoi notificare l'UI della disconnessione di un client
            '''''RaiseEvent UdpClientDisconnected(clientId)
        End Sub

        Private Sub OnServerStatusChanged(isRunning As Boolean)
            ' Qui puoi notificare l'UI del cambio di stato del server
            RaiseEvent UdpServerStatusChanged(isRunning)
        End Sub

        ' Callback quando la sincronizzazione è completata
        Private Sub OnSyncCompleted(offsetMs As Long, roundTripMs As Long)
            ' Notifica UI della sincronizzazione completata
            RaiseEvent SyncCompleted(offsetMs, roundTripMs)
        End Sub

        ' Eventi per notificare l'UI
        Public Delegate Sub SyncCompletedEventHandler(offsetMs As Long, roundTripMs As Long)
        Public Delegate Sub UdpClientEventHandler(clientId As String, endPointInfo As String)
        Public Delegate Sub UdpServerStatusEventHandler(isRunning As Boolean)

        Public Event SyncCompleted As SyncCompletedEventHandler
        Public Event UdpClientConnected As UdpClientEventHandler
        Public Event UdpClientDisconnected As UdpClientEventHandler
        Public Event UdpServerStatusChanged As UdpServerStatusEventHandler
#End Region
    End Module
End Namespace
