
Class WaveReader

    Private mDeadTimeSamples As Int32 = 20  ' DeadTime in samples
    Private mTriggerLevel As Int32 = 4000

    Friend Counter As Int32 = 0
    Friend VuMeterLinear As Double = 0
    Friend VuMeterLog As Double = 0

    Friend MaxDB As Double
    Friend MinDB As Double

    Private m_Recorder As AudioIn = New AudioIn
    Private m_RecBuffer As Int16()
    Private m_DeadTimeCounter As Int32

    Friend Property DeadTime_uS() As Single
        Get
            Return mDeadTimeSamples * 1000000.0F / 44100.0F
        End Get
        Set(ByVal value As Single)
            mDeadTimeSamples = CInt(value * 44100.0F / 1000000.0F)
        End Set
    End Property

    Friend Property TriggerLevel_mV() As Single
        Get
            Return (mTriggerLevel * 1000.0F / 32768.0F)
        End Get
        Set(ByVal value As Single)
            mTriggerLevel = CInt(value / 1000.0F * 32768.0F)
        End Set
    End Property

    Private Sub DataArrived(ByRef m_RecBuffer() As Int16)
        ' -------------------------------------------------------------------- scan the buffer data
        Dim MaxValue As Int32 = -999999
        Dim MinValue As Int32 = 999999
        Dim v As Int32
        For i As Integer = 0 To m_RecBuffer.Length - 1
            ' ----------------------------------------------------------------
            v = m_RecBuffer(i)
            ' ----------------------------------------------------------------
            If v > MaxValue Then MaxValue = v
            If v < MinValue Then MinValue = v
            ' ----------------------------------------------------------------
            m_DeadTimeCounter -= 1
            If m_DeadTimeCounter < 0 Then
                m_DeadTimeCounter = 0
                If Math.Abs(v) > mTriggerLevel Then
                    Counter += 1
                    If Counter > 65535 Then Counter = 0
                    m_DeadTimeCounter = mDeadTimeSamples
                End If
            End If
        Next
        '
        Dim vpp As Single = (MaxValue - MinValue) / 60000.0F
        If vpp < 0.00001 Then vpp = 0.00001
        If vpp > VuMeterLinear Then
            VuMeterLinear += (vpp - VuMeterLinear) * 0.5F
        Else
            VuMeterLinear += (vpp - VuMeterLinear) * 0.1F
        End If
        '
        Dim db As Double = VoltToDecibel(VuMeterLinear)
        Dim vlog As Double = 1 + db / 50.0
        If vlog < 0 Then vlog = 0
        VuMeterLog = vlog
    End Sub

    Friend Function VoltToDecibel(ByVal v As Double) As Double
        Static kdb As Double = 20 / Math.Log(10)
        VoltToDecibel = kdb * Math.Log(v)
    End Function

    Friend Sub RecordStop()
        m_Recorder.InputOff()
    End Sub

    Friend Sub RecordStart(ByVal InputDeviceIndex As Int32)
        RecordStop()
        m_Recorder.InputOn(InputDeviceIndex, _
                           44100, _
                           1, _
                           1024, _
                           6, _
                           AddressOf DataArrived)
    End Sub

End Class
