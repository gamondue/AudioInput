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
    Private Sub cmb_AudioInDevices_DropDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_AudioInDevices.DropDown
        cmb_AudioInDevices.ItemHeight = 16
        FillAudioDevicesCombo()
    End Sub
    Private Sub cmb_AudioInDevices_DropDownClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_AudioInDevices.DropDownClosed
        cmb_AudioInDevices.ItemHeight = 11
    End Sub
    Private Sub cmb_AudioInDevices_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_AudioInDevices.SelectedIndexChanged
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
    Private Sub btn_AudioInputs_ClickButtonArea(ByVal Sender As Object, ByVal e As EventArgs) Handles btn_AudioInputs.ClickButtonArea
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
                                     ByVal e As System.EventArgs) Handles txt_SlotCounter.LostFocus,
                                                                          txt_SlotMeter.LostFocus,
                                                                          txt_SlotSpectrum.LostFocus,
                                                                          tk_TriggerLevel.LostFocus,
                                                                          txt_BandsCount.LostFocus,
                                                                          chk_BandsAGC.LostFocus,
                                                                          txt_BandsMaxDb.LostFocus,
                                                                          txt_BandsMinDb.LostFocus,
                                                                          txt_BandsMaxFreq.LostFocus,
                                                                          txt_BandsMinFreq.LostFocus,
                                                                          txt_BandsSpeed.LostFocus,
                                                                          chk_BandsLogX.LostFocus,
                                                                          chk_BandsLogY.LostFocus
        Save_INI()
    End Sub


    ' ================================================================================================
    '   SET PROPERTIES
    ' ================================================================================================
    Private Sub txt_Slots_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_SlotCounter.TextChanged,
                                                                                                   txt_SlotMeter.TextChanged,
                                                                                                   txt_SlotSpectrum.TextChanged
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
End Class