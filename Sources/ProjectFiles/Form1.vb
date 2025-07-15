Imports System.Drawing
Imports System.Net
Imports Theremino_AudioInput.NetTransfer
Imports Theremino_AudioInput.NetTransfer.NetTransfer_Udp

Public Class Form1

    Private vu As VuMeter = New VuMeter
    Private m_WaveReader As WaveReader = New WaveReader
    Private Slot_Counter As Int32
    Private Slot_Meter As Int32
    Private Slot_Spectrum As Int32

    Private TemplateWave As Double()

    Private isMeasuringStrokes As Boolean = False
    Private locateStrokesThread As Threading.Thread = Nothing
    Private previousBackGround As Color
    Private previousForeColor As Color

    Private WithEvents netTransfer As NetTransfer_Udp

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EventsAreEnabled = False
        Load_INI()
        Timer1.Interval = 10
        Timer1.Start()
        Set_Props()
        Me.Text = AppTitleAndVersion("AudioInput")
        m_WaveReader.RecordStart(SelectedAudioIn)
        SpectrumBands.Initialize(pbox_SpectrumBars, SelectedAudioIn)
        FillAudioDevicesCombo()
        EventsAreEnabled = True
        GroupBox3.Focus()
        Refresh()
        Opacity = 1

        ReadTemplateWave()
    End Sub
    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Save_INI()
        m_WaveReader.RecordStop()
        If Not netTransfer Is Nothing Then
            netTransfer.Close()
        End If
    End Sub
    Private Sub Form_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.LocationChanged
        If Not EventsAreEnabled Then Exit Sub
        LimitFormPosition(Me)
    End Sub

    ' =======================================================================================================
    '   APP TITLE AND VERSION
    ' =======================================================================================================
    Friend Function AppTitleAndVersion(Optional ByVal Title As String = "") As String
        If Title = "" Then Title = Replace(My.Application.Info.AssemblyName, "_", " ")
        Dim s() As String = Split(My.Application.Info.Version.ToString, ".")
        Return Title & " - V" & s(0) & "." & s(1)
    End Function

    ' ===================================================================================================
    '  SELECT AUDIO INPUT 
    ' ===================================================================================================
    Friend SelectedAudioIn As Int32 = 0

    Private Sub cmb_AudioInDevices_DropDown(ByVal sender As Object, ByVal e As EventArgs)
        cmb_AudioInDevices.ItemHeight = 16
        FillAudioDevicesCombo()
    End Sub
    Private Sub cmb_AudioInDevices_DropDownClosed(ByVal sender As Object, ByVal e As EventArgs)
        cmb_AudioInDevices.ItemHeight = 11
    End Sub
    Private Sub cmb_AudioInDevices_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not EventsAreEnabled Then Exit Sub
        SelectedAudioIn = cmb_AudioInDevices.SelectedIndex
        m_WaveReader.RecordStart(SelectedAudioIn)
        SpectrumBands.Initialize(pbox_SpectrumBars, SelectedAudioIn)
    End Sub
    Private Sub FillAudioDevicesCombo()
        Dim sa As String() = WaveNative.GetDevNames
        If sa.Length = 0 Then ReDim sa(0) : sa(0) = ""
        cmb_AudioInDevices.Items.Clear()
        For i As Int32 = 0 To sa.Length - 1
            cmb_AudioInDevices.Items.Add(ExtractDeviceName(sa(i)))
        Next
        Combo_SetIndex(cmb_AudioInDevices, SelectedAudioIn)
    End Sub
    ' ===================================================================================================
    '  AUDIO IN HELPERS
    ' ===================================================================================================
    Private Function ExtractDeviceName(ByVal s As String) As String
        If s = Nothing Then Return ""
        Dim i As Int32 = InStr(s, "(") - 1
        Dim s2 As String = ""
        If i > 1 Then s2 = s.Remove(i)
        s2 = s2.Trim
        If s.ToLower.Contains("usb") Then s2 = s2 + " USB"
        Return s2
    End Function
    Private Sub btn_AudioInputs_ClickButtonArea(ByVal Sender As Object, ByVal e As EventArgs)
        Open_AudioInputs()
    End Sub
    ' ================================================================================================
    '    TIMERS
    ' ================================================================================================
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not EventsAreEnabled Then Return
        ' ----------------------------------------------------------------------- In Out Slots
        If Slot_Counter >= 0 Then
            Slots.WriteSlot(Slot_Counter, m_WaveReader.Counter)
        End If
        If Slot_Meter >= 0 Then
            Slots.WriteSlot(Slot_Meter, m_WaveReader.VuMeterLog * 1000.0F)
        End If
        vu.Draw(pBox1, m_WaveReader.VuMeterLog, m_WaveReader.TriggerLevel_mV / 1000)

        If Slot_Spectrum >= 0 Then
            SpectrumBands.Update(pbox_SpectrumBars,
                                 CSng(txt_BandsMinFreq.NumericValue),
                                 CSng(txt_BandsMaxFreq.NumericValue),
                                 CSng(txt_BandsMinDb.NumericValue),
                                 CSng(txt_BandsMaxDb.NumericValue),
                                 chk_BandsLogX.Checked,
                                 chk_BandsLogY.Checked,
                                 txt_BandsSpeed.NumericValueInteger / 100.0F,
                                 FHT.WindowTypes.BlackmanHarris,
                                 txt_BandsCount.NumericValueInteger,
                                 chk_BandsAGC.Checked)
            For i As Int32 = 0 To txt_BandsCount.NumericValueInteger - 1
                Slots.WriteSlot(Slot_Spectrum + i, 1000.0F * SpectrumBands.m_fht.BandsBuffer(i))
            Next
        End If

        txtCount.Text = m_WaveReader.Counter.ToString("0")

        txtCorrelationForDelay.Text = LocateStrokes.CorrelationWithOtherWave.ToString("0.0000")
        txtDelay.Text = LocateStrokes.DelayInSamples.ToString("0")

        'Dim c As Double
        'Me.Invoke(Sub()
        '              ' codice per mostrare risultati nell'UI
        '              c = LocateStrokes.CorrelationWithTemplate
        '          End Sub)
        'txtCorrelation.Text = c.ToString("0.0000")

        Me.Invoke(Sub()
                      ' codice per mostrare risultati nell'UI
                      txtCorrelation.Text = LocateStrokes.CorrelationWithTemplate
                  End Sub)
    End Sub
    ' ================================================================================================
    '   SAVE INI ON LOST-FOCUS
    ' ================================================================================================
    Private Sub Properties_LostFocus(ByVal sender As Object,
                                     ByVal e As EventArgs) Handles tk_TriggerLevel.LostFocus
        Save_INI()
    End Sub
    ' ================================================================================================
    '   SET PROPERTIES
    ' ================================================================================================
    Private Sub txt_Slots_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not EventsAreEnabled Then Exit Sub
        Set_Props()
    End Sub
    Private Sub tk_TriggerLevel_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tk_TriggerLevel.Scroll
        If Not EventsAreEnabled Then Exit Sub
        Set_Props()
    End Sub
    Private Sub tk_DeadTime_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tk_DeadTime.Scroll
        If Not EventsAreEnabled Then Exit Sub
        Set_Props()
    End Sub
    Private Sub Set_Props()
        ' ---------------------------------------------------------------- slots 
        Slot_Counter = txt_SlotCounter.NumericValueInteger
        Slot_Meter = txt_SlotMeter.NumericValueInteger
        Slot_Spectrum = txt_SlotSpectrum.NumericValueInteger
        ' ---------------------------------------------------------------- trigger
        m_WaveReader.TriggerLevel_mV = tk_TriggerLevel.Value
        m_WaveReader.DeadTime_uS = (tk_DeadTime.Value + 2) * 20
        ' ---------------------------------------------------------------- show trigger values
        lbl_TrigLevel.Text = m_WaveReader.TriggerLevel_mV.ToString("0 mV")
        lbl_DeadTime.Text = m_WaveReader.DeadTime_uS.ToString("0 uS")
        ' ----------------------------------------------------------------
        '''If Slot_Spectrum >= 0 Then
        '''    Me.Width = 690
        '''Else
        '''    Me.Width = 330
        '''End If
    End Sub
    Private Sub chkEnableServer_CheckedChanged(sender As Object, e As EventArgs) Handles chkEnableServer.CheckedChanged
        If netTransfer IsNot Nothing Then
            netTransfer.StopClient()
            netTransfer.StopServer()
            netTransfer = Nothing
        End If
        lblConnectionStatus.Text = "Closed"
    End Sub
    Private Sub btnSyncNTP_ClickButtonArea(Sender As Object, e As EventArgs)
        ' Controlla se il client è connesso
        If netTransfer.RequestNTPSync Then
            btnSyncNTP.Enabled = False
            lblSyncStatus.Text = "Sincronizzazione in corso..."

            ' Riabilita il pulsante dopo 5 secondi
            Dim timer As New Timer With {.Interval = 5000}
            AddHandler timer.Tick, Sub(s, args)
                                       btnSyncNTP.Enabled = True
                                       timer.Stop()
                                       timer.Dispose()
                                   End Sub
            timer.Start()
        Else
            lblSyncStatus.Text = "Impossibile sincronizzare: client non connesso"
        End If
    End Sub
    ' Gestore per l'evento di completamento
    Private Sub OnSyncCompleted(offsetMs As Long, roundTripMs As Long)
        ' Questo viene chiamato quando la sincronizzazione è completata
        ' Utilizza Invoke se necessario per aggiornare l'UI da un thread diverso
        If Me.InvokeRequired Then
            Me.Invoke(Sub() UpdateSyncUI(offsetMs, roundTripMs))
        Else
            UpdateSyncUI(offsetMs, roundTripMs)
        End If
    End Sub
    Private Sub OnUdpClientConnected(clientId As String, endPointInfo As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() lstClients.Items.Add($"{clientId} ({endPointInfo})"))
        Else
            lstClients.Items.Add($"{clientId} ({endPointInfo})")
        End If
    End Sub
    Private Sub OnUdpServerStatusChanged(isRunning As Boolean)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() UpdateServerStatusUI(isRunning))
        Else
            UpdateServerStatusUI(isRunning)
        End If
    End Sub
    Private Sub OnUdpClientDisconnected(clientId As String, endPointInfo As String)
        If Me.InvokeRequired Then
            Me.Invoke(Sub() RemoveClientFromList(clientId))
        Else
            RemoveClientFromList(clientId)
        End If
    End Sub
    Private Sub RemoveClientFromList(clientId As String)
        For i As Integer = lstClients.Items.Count - 1 To 0 Step -1
            If lstClients.Items(i).ToString().StartsWith(clientId) Then
                lstClients.Items.RemoveAt(i)
                Exit For
            End If
        Next
    End Sub
    Private Sub UpdateServerStatusUI(isRunning As Boolean)
        If isRunning Then
            lblConnectionStatus.Text = "Server UDP in ascolto"
            btnToggle.Text = "Arresta Server UDP"
        Else
            lblConnectionStatus.Text = "Server UDP arrestato"
            btnToggle.Text = "Avvia Server UDP"
            lstClients.Items.Clear()
        End If
    End Sub
    Private Sub UpdateSyncUI(offsetMs As Long, roundTripMs As Long)
        lblSyncStatus.Text = $"Sincronizzazione completata. Offset: {offsetMs} ms, RTT: {roundTripMs} ms"
    End Sub
    Private Sub btnSyncNTP_Click(sender As Object, e As EventArgs) Handles btnSyncNTP.Click
        If netTransfer.RequestTimeSync() Then
            btnSyncNTP.Enabled = False
            lblSyncStatus.Text = "Sincronizzazione in corso..."

            ' Riabilita il pulsante dopo 5 secondi
            Dim timer As New Timer With {.Interval = 5000}
            AddHandler timer.Tick, Sub(s, args)
                                       btnSyncNTP.Enabled = True
                                       timer.Stop()
                                       timer.Dispose()
                                   End Sub
            timer.Start()
        Else
            lblSyncStatus.Text = "Impossibile sincronizzare: client non connesso"
        End If
    End Sub
    Private Sub btnGetTemplate_Click(sender As Object, e As EventArgs) Handles btnGetTemplate.Click
        TemplateWave = LocateStrokes.GetTemplateWave(m_WaveReader)
    End Sub
    Private Sub btnLocatestrokes_Click(sender As Object, e As EventArgs) Handles btnGetStroke.Click
        If Not isMeasuringStrokes Then
            isMeasuringStrokes = True
            btnGetStroke.Text = "Stop"
            previousBackGround = btnGetStroke.BackColor
            previousForeColor = btnGetStroke.ForeColor

            btnGetStroke.BackColor = Color.Red
            btnGetStroke.ForeColor = Color.Yellow
            ' Avvia in un thread separato
            locateStrokesThread = New Threading.Thread(
                Sub()
                    Try
                        ' Ciclo continuo di rilevamento fino all'interruzione
                        While isMeasuringStrokes
                            ' Esegui la rilevazione del colpo d'ariete
                            Dim result = LocateStrokes.GetStroke(m_WaveReader, chkEnableServer.Checked)
                            ' calcolo del ritardo

                            Dim waveNormalized As Double() = LocateStrokes.NormalizeWave(m_WaveReader.outBuffer)
                            ' Se rileva un colpo d'ariete (result non è Nothing)
                            If result IsNot Nothing Then
                                Dim sampleOfDelay = LocateStrokes.CalculateDelayWithCrossCorrelation(waveNormalized, TemplateWave)

                                ' Aggiorna l'interfaccia utente in modo thread-safe
                                'Me.Invoke(Sub()
                                '              ' codice per mostrare risultati nell'UI
                                '              'txtCorrelation.Text = LocateStrokes.CorrelationWithTemplate.ToString("0.0000")
                                '          End Sub)
                            End If
                            ' Piccola pausa per evitare di sovraccaricare la CPU
                            Threading.Thread.Sleep(10)
                        End While
                    Catch ex As Exception
                        ' Gestisci eccezioni in modo thread-safe
                        Me.Invoke(Sub()
                                      MessageBox.Show("Errore durante il rilevamento: " & ex.Message,
                                                "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                  End Sub)
                    End Try
                End Sub)

            ' Imposta il thread come background
            locateStrokesThread.IsBackground = True
            ' Avvia il thread
            locateStrokesThread.Start()
        Else
            ' Imposta il flag per terminare il ciclo nel thread
            isMeasuringStrokes = False

            ' Attendi che il thread termini (max 1 secondo)
            If locateStrokesThread IsNot Nothing AndAlso locateStrokesThread.IsAlive Then
                Try
                    locateStrokesThread.Join(1000)
                Catch ex As Exception
                    ' Ignora eventuali errori
                End Try
                locateStrokesThread = Nothing
            End If

            btnGetStroke.Text = "Locate Strokes"
            btnGetStroke.BackColor = previousBackGround
            btnGetStroke.ForeColor = previousForeColor
            MessageBox.Show("Misurazione della posizione del colpo d'ariete interrotta.", "Interruzione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        'LocateStrokes.GetStroke(m_WaveReader, chkEnableServer.Checked)
    End Sub
    Private Sub btnSaveTemplate_Click(sender As Object, e As EventArgs) Handles btnSaveTemplate.Click
        ' Salva l'array TemplateWave in un file csv
        If TemplateWave IsNot Nothing AndAlso TemplateWave.Length > 0 Then
            Dim filePath = "TemplateWave.csv"
            Using writer As New IO.StreamWriter(filePath)
                For Each value In TemplateWave
                    writer.WriteLine(value.ToString("F6"))
                Next
            End Using
            MessageBox.Show($"Template wave salvato in {filePath}", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nessun template wave disponibile da salvare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub ReadTemplateWave()
        ' Legge il contenuto del file TemplateWave.csv e lo carica nell'array TemplateWave
        Dim filePath As String = "TemplateWave.csv"
        If IO.File.Exists(filePath) Then
            Dim lines As String() = IO.File.ReadAllLines(filePath)
            Dim values As New List(Of Double)
            Dim culture As Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
            For Each line In lines
                Dim trimmed = line.Trim()
                If trimmed <> "" Then
                    Dim d As Double
                    ' Prova prima con la cultura locale
                    If Double.TryParse(trimmed, Globalization.NumberStyles.Any, culture, d) Then
                        values.Add(d)
                    ElseIf Double.TryParse(trimmed.Replace(".", culture.NumberFormat.NumberDecimalSeparator).Replace(",", culture.NumberFormat.NumberDecimalSeparator), Globalization.NumberStyles.Any, culture, d) Then
                        ' Prova a sostituire il separatore decimale se necessario
                        values.Add(d)
                    End If
                End If
            Next
            TemplateWave = values.ToArray()
            LocateStrokes.NormalizedTemplateWave = TemplateWave
            MessageBox.Show($"Template wave caricato da {filePath}", "Caricamento completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show($"File {filePath} non trovato.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnSaveWave_Click(sender As Object, e As EventArgs) Handles btnSaveWave.Click
        ' normalizza l'array CurrentWave prima di salvarlo
        Dim CurrentWave As Double() = LocateStrokes.NormalizeWave(LocateStrokes.CurrentWave)
        ' Salva l'array CurrentWave in un file csv
        If CurrentWave IsNot Nothing AndAlso CurrentWave.Length > 0 Then
            Dim filePath = "AcquiredWave.csv"
            Using writer As New IO.StreamWriter(filePath)
                For Each value In CurrentWave
                    writer.WriteLine(value.ToString("F6"))
                Next
            End Using
            MessageBox.Show($"Segnale salvato in {filePath}", "Salvataggio completato", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Nessun segnale disponibile da salvare.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub btnToggle_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If chkEnableServer.Checked = False Then
            'If Not netTransfer.IsServer Then
            netTransfer = New NetTransfer_Udp(27759)
            netTransfer.StopClient()
            netTransfer.StartServer()
            btnToggle.Text = "Arresta Server UDP"
            lblConnectionStatus.Text = "Server UDP in ascolto..."
            'Else
            '    MessageBox.Show("Impossibile avviare il server UDP", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        Else
            netTransfer = New NetTransfer_Udp("localhost", 27759)
            netTransfer.StopServer()
            netTransfer.StartClient()
            btnToggle.Text = "Avvia Server UDP"
            lblConnectionStatus.Text = "Server UDP arrestato"
        End If
    End Sub
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If chkEnableServer.Checked Then
            netTransfer = New NetTransfer_Udp(27759)
            'btnToggle.Text = "Arresta Server UDP"
            ' write in txtIpServer the IP address of this computer
            Dim host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName())
            Dim localIp As String = ""
            For Each ip In host.AddressList
                If ip.AddressFamily = Net.Sockets.AddressFamily.InterNetwork Then
                    localIp += ip.ToString() + vbNewLine
                End If
            Next
            txtIpServer.Text = localIp
            netTransfer.StartServer()
            lblConnectionStatus.Text = "Server listening..."
            'Else
            '    MessageBox.Show("Impossibile avviare il server UDP", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
        Else
            netTransfer = New NetTransfer_Udp(txtIpServer.Text, 27759)
            netTransfer.IsServer = False
            'btnToggle.Text = "Avvia Server UDP"
            netTransfer.StartClient()
            If netTransfer.IsConnected Then
                lblConnectionStatus.Text = "Client connected"
            Else
                lblConnectionStatus.Text = "Error in connection"
            End If
        End If
        btnConnect.Text = "Close"
    End Sub
    ' Evento per la connessione di un client UDP
    Private Sub netTransfer_ClientConnected(clientId As String, e As IPEndPoint) Handles netTransfer.ClientConnected
        ' Aggiorna la lista dei client connessi in modo thread-safe
        If Me.InvokeRequired Then
            'Me.Invoke(Sub() lstClients.Items.Add($"{e.ToString} ({clientId})"))
            lstClients.DataSource = netTransfer.ConnectedClients
            'lstClients.DisplayMember = "EndPointInfo.Address"
        Else
            'lstClients.Items.Add($"{e.ToString} ({clientId})")
        End If
    End Sub
    ' Evento per la connessione di un client UDP
    Private Sub netTransfer_ClientDisconnected(clientId As String) Handles netTransfer.ClientDisconnected
        ' Aggiorna la lista dei client connessi in modo thread-safe
        If Me.InvokeRequired Then
            Me.Invoke(Sub() lstClients.Items.Remove($"({clientId})"))
        Else
            lstClients.Items.Remove($"({clientId})")
        End If
    End Sub
End Class