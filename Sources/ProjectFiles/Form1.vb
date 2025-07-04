Imports System.Drawing

Public Class Form1

    Private vu As VuMeter = New VuMeter
    Private m_WaveReader As WaveReader = New WaveReader
    Private Slot_Counter As Int32
    Private Slot_Meter As Int32
    Private Slot_Spectrum As Int32

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

        ' Registra l'handler per l'evento di sincronizzazione completata
        AddHandler SpectrumBands.SyncCompleted, AddressOf OnSyncCompleted

        ' eventi UDP
        AddHandler SpectrumBands.SyncCompleted, AddressOf OnSyncCompleted
        AddHandler SpectrumBands.UdpClientConnected, AddressOf OnUdpClientConnected
        AddHandler SpectrumBands.UdpClientDisconnected, AddressOf OnUdpClientDisconnected
        AddHandler SpectrumBands.UdpServerStatusChanged, AddressOf OnUdpServerStatusChanged
    End Sub

    Private Sub Form_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        Save_INI()
        m_WaveReader.RecordStop()
        SpectrumBands.CloseAll()
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
        SpectrumBands.ToggleServer(chkEnableServer.Checked)
    End Sub

    Private Sub btnSyncNTP_ClickButtonArea(Sender As Object, e As EventArgs)
        ' Controlla se il client è connesso
        If SpectrumBands.RequestNTPSync Then
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
            lblServerStatus.Text = "Server UDP in ascolto"
            btnToggleUdpServer.Text = "Arresta Server UDP"
        Else
            lblServerStatus.Text = "Server UDP arrestato"
            btnToggleUdpServer.Text = "Avvia Server UDP"
            lstClients.Items.Clear()
        End If
    End Sub
    Private Sub UpdateSyncUI(offsetMs As Long, roundTripMs As Long)
        lblSyncStatus.Text = $"Sincronizzazione completata. Offset: {offsetMs} ms, RTT: {roundTripMs} ms"
    End Sub

    Private Sub btnToggleUdpServer_Click(sender As Object, e As EventArgs) Handles btnToggleUdpServer.Click
        If btnToggleUdpServer.Text = "Avvia Server UDP" Then
            If SpectrumBands.StartUdpServer(27759) Then
                btnToggleUdpServer.Text = "Arresta Server UDP"
                lblServerStatus.Text = "Server UDP in ascolto..."
            Else
                MessageBox.Show("Impossibile avviare il server UDP", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            SpectrumBands.StopUdpServer()
            btnToggleUdpServer.Text = "Avvia Server UDP"
            lblServerStatus.Text = "Server UDP arrestato"
        End If
    End Sub

    Private Sub btnSyncNTP_Click(sender As Object, e As EventArgs) Handles btnSyncNTP.Click
        If SpectrumBands.RequestNTPSyncUdp() Then
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
End Class