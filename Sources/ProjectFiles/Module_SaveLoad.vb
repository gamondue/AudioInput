
Imports System.Math

Module Module_SaveLoad

    Friend EventsAreEnabled As Boolean = False


    ' =======================================================================================
    '  FORM FUNCTIONS
    ' =======================================================================================
    Friend Sub LimitFormPosition(ByVal f As System.Windows.Forms.Form)
        If f.WindowState <> FormWindowState.Normal Then Return
        GetMaxScreenBounds()
        EnsureFormVisible(f)
        'EnsureFormCompletelyVisible(f)
    End Sub

    Private SB As Rectangle = New Rectangle(Integer.MaxValue, Integer.MaxValue, Integer.MinValue, Integer.MinValue)

    Private Sub GetMaxScreenBounds()
        For Each s As Screen In System.Windows.Forms.Screen.AllScreens
            SB = Rectangle.Union(SB, s.WorkingArea)
        Next
    End Sub

    'Private Sub EnsureFormCompletelyVisible(ByVal frm As Form)
    '    With frm
    '        .Width = Math.Min(.Width, SB.Width)         ' not more than a maximized window
    '        .Height = Math.Min(.Height, SB.Height)      ' not more than a maximized window
    '        .Width = Math.Max(.Width, 32)               ' at least 32x24
    '        .Height = Math.Max(.Height, 24)             ' at least 32x24
    '        .Left = Math.Min(.Left, SB.Right - .Width)  ' not beyond the right border
    '        .Top = Math.Min(.Top, SB.Bottom - .Height)  ' not beyond the bottom border
    '        .Left = Math.Max(.Left, SB.Left)            ' at least at the left border
    '        .Top = Math.Max(.Top, SB.Top)               ' at least at the top border
    '    End With
    'End Sub

    Private Sub EnsureFormVisible(ByVal frm As Form)
        With frm
            .Width = Math.Min(.Width, SB.Width)             ' not more than VIRTUALSCREEN dimensions
            .Height = Math.Min(.Height, SB.Height)          ' not more than VIRTUALSCREEN dimensions 
            .Width = Math.Max(.Width, 32)                   ' at least 32x24
            .Height = Math.Max(.Height, 24)                 ' at least 32x24
            .Left = Math.Min(.Left, SB.Right - 50)          ' not beyond right border - 50 pixels
            .Top = Math.Min(.Top, SB.Bottom - 100)          ' not beyond bottom border - 50 pixels
            .Left = Math.Max(.Left, SB.Left + 100 - .Width) ' at least at left border + 50 pixels
            .Top = Math.Max(.Top, SB.Top - 10)              ' at least at top border
        End With
    End Sub

    ' (The value of the RestoreBounds property is valid only 
    '   when the WindowState property of the Form class is not equal to Normal)
    Friend Function GetFormRectangle(ByVal frm As Form) As Rectangle
        Dim r As Rectangle
        If frm.WindowState = FormWindowState.Normal Then
            r = frm.Bounds
        Else
            r = frm.RestoreBounds
        End If
        Return r
    End Function


    ' ================================================================================================
    '  Private Read-Write functions
    ' ================================================================================================
    Private Function TabString(ByVal Name As String, _
                               Optional ByVal Value As Double = Double.NaN, _
                               Optional ByVal fmt As String = "") As String

        Dim nTab As Int32 = Math.Max(0, 22 - Name.Length)
        If Double.IsNaN(Value) Then
            Return Name
        Else
            Return Name & "=" & Strings.StrDup(nTab, " ") & Value.ToString(fmt, GCI)
        End If
    End Function
    Private Function TabString(ByVal Name As String, _
                                  ByVal Value As Boolean) As String

        Dim nTab As Int32 = Math.Max(0, 22 - Name.Length)

        Return Name & "=" & Strings.StrDup(nTab, " ") & Value.ToString
    End Function
    Private Function TabString(ByVal Name As String, _
                                ByVal Value As String) As String

        Dim nTab As Int32 = Math.Max(0, 22 - Name.Length)

        Return Name & "=" & Strings.StrDup(nTab, " ") & Value
    End Function
    Private Function Val_Double(ByVal l As String) As Double
        Return Val(Replace(l, ",", "."))
    End Function
    Private Function Val_Int(ByVal l As String) As Int32
        Return CInt(Val(l))
    End Function
    Private Function ExtractParamName(ByRef s As String) As String
        ' ------------------------- Returns the first field from begin to the first "=" symbol
        ' -------------------------  and removes it from the string
        Dim i As Integer
        i = InStr(s, "=")
        If i > 0 Then
            ExtractParamName = Trim(Strings.Left(s, i - 1))
            s = Trim(Mid(s, i + 1))
        Else
            ExtractParamName = Trim(s)
            s = ""
        End If
    End Function
    Private Function AssemblyName() As String
        Return System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
    End Function


    ' ==================================================================================================
    '  SAVE LOAD -- Program INI
    ' ==================================================================================================
    Friend Sub Save_INI()
        Dim iniFileName As String = Application.StartupPath & "\" & AssemblyName() & "_INI.txt"
        Dim f As System.IO.StreamWriter = Nothing
        Try
            f = IO.File.CreateText(iniFileName)
            '
            f.WriteLine(" Program Params")
            f.WriteLine("===========================================")
            ' ------------------------------------------------------------------------------ FORM BOUNDS
            Dim r As Rectangle
            r = GetFormRectangle(Form1)
            f.WriteLine(TabString("Form1_Top", r.Top))
            f.WriteLine(TabString("Form1_Left", r.Left))
            'f.WriteLine(TabString("Form1_Width", r.Width))
            'f.WriteLine(TabString("Form1_Height", r.Height))
            f.WriteLine(TabString("Form1_WindowState", Form1.WindowState))
            '
            f.WriteLine("")
            f.WriteLine(" Input selector")
            f.WriteLine("===========================================")
            f.WriteLine(TabString("SelectedAudioIn", Form1.SelectedAudioIn))
            '
            f.WriteLine("")
            f.WriteLine(" Output slots")
            f.WriteLine("===========================================")
            f.WriteLine(TabString("SlotCounter", Form1.txt_SlotCounter.Text))
            f.WriteLine(TabString("SlotMeter", Form1.txt_SlotMeter.Text))
            f.WriteLine(TabString("SlotSpectrum", Form1.txt_SlotSpectrum.Text))
            '
            f.WriteLine("")
            f.WriteLine(" Audio in")
            f.WriteLine("===========================================")
            f.WriteLine(TabString("TriggerLevel", Form1.tk_TriggerLevel.Value.ToString))
            f.WriteLine(TabString("DeadTime", Form1.tk_DeadTime.Value.ToString))
            '
            f.WriteLine("")
            f.WriteLine(" Bands")
            f.WriteLine("===========================================")
            f.WriteLine(TabString("BandsCount", Form1.txt_BandsCount.Text))
            f.WriteLine(TabString("BandsAGC", Form1.chk_BandsAGC.Checked.ToString))
            f.WriteLine(TabString("BandsMaxDb", Form1.txt_BandsMaxDb.Text))
            f.WriteLine(TabString("BandsMinDb", Form1.txt_BandsMinDb.Text))
            f.WriteLine(TabString("BandsMaxFreq", Form1.txt_BandsMaxFreq.Text))
            f.WriteLine(TabString("BandsMinFreq", Form1.txt_BandsMinFreq.Text))
            f.WriteLine(TabString("BandsSpeed", Form1.txt_BandsSpeed.Text))
            f.WriteLine(TabString("BandsLogX", Form1.chk_BandsLogX.Checked.ToString))
            f.WriteLine(TabString("BandsLogY", Form1.chk_BandsLogY.Checked.ToString))
            '
            'f.WriteLine("")
            'f.WriteLine(" examples")
            'f.WriteLine("===========================================")
            'f.WriteLine(TabString("DefaultCapMaxDist", Form1.txt_MaxDist.NumericValue))
            'f.WriteLine(TabString("FastScroll", Form2.btn_FastScroll.Checked))
            'f.WriteLine(TabString("ShowRawCount", Form2.btn_ShowRawCount.Checked))
            'f.WriteLine(TabString("ShowXY", Form2.btn_ShowXY.Checked))
        Catch
        End Try
        Try
            f.Close()
        Catch
        End Try
    End Sub


    Friend Sub Load_INI()
        ' ------------------------------------------------------------- defaults
        '
        ' -------------------------------------------------------------
        ' ------------------------------------------------------------------------------- 
        ' With "Resume Next" subsequent parameters are loaded and f.Close() is executed
        ' -------------------------------------------------------------------------------
        On Error Resume Next  ' use Resume-Next instead of Try-Catch
        ' -------------------------------------------------------------------------------
        Dim l As String
        Dim iniFileName As String = Application.StartupPath & "\" & AssemblyName() & "_INI.txt"
        If My.Computer.FileSystem.FileExists(iniFileName) Then
            Dim f As System.IO.StreamReader
            f = IO.File.OpenText(iniFileName)

            Do While Not f.EndOfStream
                l = f.ReadLine()
                Select Case ExtractParamName(l)
                    Case "Form1_Top" : Form1.Top = Val_Int(l)
                    Case "Form1_Left" : Form1.Left = Val_Int(l)
                        'Case "Form1_Width" : Form1.Width = Val_Int(l))
                        'Case "Form1_Height" : Form1.Height = Val_Int(l))
                    Case "Form1_WindowState" : Form1.WindowState = CType(l, FormWindowState)
                        ' ----------------------------------------------------------------- Input selector
                    Case "SelectedAudioIn" : Form1.SelectedAudioIn = Val_Int(l)
                        ' ----------------------------------------------------------------- Out slots
                    Case "SlotCounter" : Form1.txt_SlotCounter.Text = l
                    Case "SlotMeter" : Form1.txt_SlotMeter.Text = l
                    Case "SlotSpectrum" : Form1.txt_SlotSpectrum.Text = l
                        ' ----------------------------------------------------------------- Audio in
                    Case "TriggerLevel" : Form1.tk_TriggerLevel.Value = Val_Int(l)
                    Case "DeadTime" : Form1.tk_DeadTime.Value = Val_Int(l)
                        ' ----------------------------------------------------------------- bands
                    Case "BandsCount" : Form1.txt_BandsCount.Text = l
                    Case "BandsAGC" : Form1.chk_BandsAGC.Checked = l = "True"
                    Case "BandsMaxDb" : Form1.txt_BandsMaxDb.Text = l
                    Case "BandsMinDb" : Form1.txt_BandsMinDb.Text = l
                    Case "BandsMaxFreq" : Form1.txt_BandsMaxFreq.Text = l
                    Case "BandsMinFreq" : Form1.txt_BandsMinFreq.Text = l
                    Case "BandsSpeed" : Form1.txt_BandsSpeed.Text = l
                    Case "BandsLogX" : Form1.chk_BandsLogX.Checked = l = "True"
                    Case "BandsLogY" : Form1.chk_BandsLogY.Checked = l = "True"
                        ' ----------------------------------------------------------------- examples
                        'Case "DefaultCapMaxDist" : Form1.txt_MaxDist.NumericValue = Val(l)
                        'Case "FastScroll" : Form2.btn_FastScroll.Checked = l = "True"
                        'Case "ShowRawCount" : Form2.btn_ShowRawCount.Checked = l = "True"
                        'Case "ShowXY" : Form2.btn_ShowXY.Checked = l = "True"
                End Select
            Loop
            f.Close()
        End If
        LimitFormPosition(Form1)
    End Sub

End Module
