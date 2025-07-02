Imports System.Drawing.Drawing2D

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

        Private m_netTransfer As Class_NetTransfer

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

        Private Sub DataArrived(ByRef data() As Int16)
            m_fifo.AddArray(data)

            ' Invia i dati al server TCP se siamo connessi come client
            If m_netTransfer IsNot Nothing AndAlso m_netTransfer.IsConnected Then
                m_netTransfer.SendData(data)
            End If

            '' Invia i dati a tutti i client connessi se il server è attivo
            'If m_netTransfer IsNot Nothing AndAlso m_netTransfer.IsServerRunning Then
            '    m_netTransfer.BroadcastData(data)
            'End If
        End Sub

        Private Function CreateFillBrush(ByVal pbox As PictureBox, _
                                         ByVal direction As LinearGradientMode) As LinearGradientBrush
            CreateFillBrush = New LinearGradientBrush(pbox.ClientRectangle, _
                                                      Color.Black, _
                                                      Color.Black, _
                                                      direction)
            Dim myBlend As ColorBlend = New ColorBlend()
            myBlend.Colors = New Color() {Color.FromArgb(255, 0, 0), _
                                          Color.FromArgb(255, 230, 0), _
                                          Color.FromArgb(250, 250, 0), _
                                          Color.FromArgb(230, 230, 0), _
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
            m_netTransfer = New Class_NetTransfer(tcpServerAddress, tcpServerPort)
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

        Friend Sub Update(ByVal pbox As PictureBox, _
                          ByVal fmin As Single, _
                          ByVal fmax As Single, _
                          ByVal dbmin As Single, _
                          ByVal dbmax As Single, _
                          ByVal xlog As Boolean, _
                          ByVal ylog As Boolean, _
                          ByVal speed As Single, _
                          ByVal windowtype As FHT.WindowTypes, _
                          ByVal NumBands As Int32, _
                          ByVal AGC As Boolean)

            If m_Recorder Is Nothing Then Return


            If pbox.Image Is Nothing OrElse pbox.Image.Width <> m_ddx OrElse _
                                    pbox.Image.Height <> m_ddy OrElse _
                                    fmin <> m_fmin OrElse _
                                    fmax <> m_fmax OrElse _
                                    dbmin <> m_dbmin OrElse _
                                    dbmax <> m_dbmax OrElse _
                                    xlog <> m_xlog OrElse _
                                    ylog <> m_ylog OrElse _
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
            m_fht.ExtractBands(NumBands, fmin, fmax, dbmin, dbmax, xlog, ylog, m_SamplesPerSec, speed, agc)

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
                    m_netTransfer = New Class_NetTransfer()
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
    End Module
End Namespace
