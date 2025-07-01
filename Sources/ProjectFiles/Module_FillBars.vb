
Imports System.Drawing.Drawing2D

Module Module_FillBars

    Friend Sub InitPictureboxImage(ByVal pbox As PictureBox)
        With pbox
            If .ClientSize.Width < 1 Then Return
            If .Image Is Nothing OrElse .Image.Width <> .ClientSize.Width OrElse .Image.Height <> .ClientSize.Height Then
                .Image = New Bitmap(.ClientRectangle.Width, .ClientRectangle.Height, Imaging.PixelFormat.Format24bppRgb)
            End If
        End With
    End Sub

    'Friend Function VoltToDecibel(ByRef v As Double) As Double
    '    VoltToDecibel = 20 * Math.Log(v, 10)
    'End Function

End Module

Friend Class VuMeter

    Private w As Int32
    Private h As Int32
    Private b1 As Drawing2D.LinearGradientBrush
    Private b2 As Brush
    Private g As Graphics

    Friend Sub Draw(ByVal pbox As PictureBox, _
                    ByVal value As Double, _
                    Optional ByVal MarkPoint As Double = 0)
        ' ----------------------------------------------------------- 
        If Not pbox.Visible Then Exit Sub
        ' ----------------------------------------------------------- 
        If pbox.Image Is Nothing OrElse pbox.ClientSize.Width <> w OrElse pbox.ClientSize.Height <> h Then
            w = pbox.ClientSize.Width
            h = pbox.ClientSize.Height
            InitPictureboxImage(pbox)
            g = Graphics.FromImage(pbox.Image)
            b1 = CreateFillBrush(pbox, If(w > h, LinearGradientMode.Horizontal, LinearGradientMode.Vertical))
            b2 = New SolidBrush(pbox.BackColor)
        End If
        ' ----------------------------------------------------------- 
        If value < 0 Then value = 0
        If value > 1 Then value = 1
        Dim v As Int32 = CInt(value * h)
        ' ----------------------------------------------------------- 
        g.FillRectangle(b1, 0, h - v, w, h)
        g.FillRectangle(b2, 0, 0, w, h - v)
        ' ----------------------------------------------------------- mark line
        If MarkPoint > 0 Then
            v = CInt(MarkPoint * pbox.Height)
            g.DrawLine(Pens.Black, 0, h - v, w, h - v)
        End If
        ' ----------------------------------------------------------- final refresh - no flickering
        pbox.Refresh()
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

End Class
