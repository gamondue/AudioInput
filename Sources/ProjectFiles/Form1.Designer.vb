<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DesignerRectTracker1 As DesignerRectTracker = New DesignerRectTracker
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CBlendItems1 As cBlendItems = New cBlendItems
        Dim CBlendItems2 As cBlendItems = New cBlendItems
        Dim DesignerRectTracker2 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker3 As DesignerRectTracker = New DesignerRectTracker
        Dim CBlendItems3 As cBlendItems = New cBlendItems
        Dim CBlendItems4 As cBlendItems = New cBlendItems
        Dim DesignerRectTracker4 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker5 As DesignerRectTracker = New DesignerRectTracker
        Dim CBlendItems5 As cBlendItems = New cBlendItems
        Dim CBlendItems6 As cBlendItems = New cBlendItems
        Dim DesignerRectTracker6 As DesignerRectTracker = New DesignerRectTracker
        Dim DesignerRectTracker7 As DesignerRectTracker = New DesignerRectTracker
        Dim CBlendItems7 As cBlendItems = New cBlendItems
        Dim CBlendItems8 As cBlendItems = New cBlendItems
        Dim DesignerRectTracker8 As DesignerRectTracker = New DesignerRectTracker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tk_TriggerLevel = New System.Windows.Forms.TrackBar
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_TrigLevel = New System.Windows.Forms.Label
        Me.lbl_DeadTime = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.tk_DeadTime = New System.Windows.Forms.TrackBar
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_SlotSpectrum = New MyTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txt_SlotCounter = New MyTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_SlotMeter = New MyTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.pBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox_Bands = New System.Windows.Forms.GroupBox
        Me.chk_BandsAGC = New MyButton
        Me.chk_BandsLogY = New MyButton
        Me.chk_BandsLogX = New MyButton
        Me.txt_BandsSpeed = New MyTextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.pbox_SpectrumBars = New System.Windows.Forms.PictureBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_BandsMaxDb = New MyTextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txt_BandsCount = New MyTextBox
        Me.txt_BandsMaxFreq = New MyTextBox
        Me.txt_BandsMinDb = New MyTextBox
        Me.txt_BandsMinFreq = New MyTextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btn_AudioInputs = New MyButton
        Me.cmb_AudioInDevices = New MyComboBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        CType(Me.tk_TriggerLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.tk_DeadTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.pBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox_Bands.SuspendLayout()
        CType(Me.pbox_SpectrumBars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'tk_TriggerLevel
        '
        Me.tk_TriggerLevel.AutoSize = False
        Me.tk_TriggerLevel.Location = New System.Drawing.Point(23, 12)
        Me.tk_TriggerLevel.Maximum = 999
        Me.tk_TriggerLevel.Minimum = 1
        Me.tk_TriggerLevel.Name = "tk_TriggerLevel"
        Me.tk_TriggerLevel.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tk_TriggerLevel.Size = New System.Drawing.Size(43, 89)
        Me.tk_TriggerLevel.TabIndex = 15
        Me.tk_TriggerLevel.TickFrequency = 100
        Me.tk_TriggerLevel.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tk_TriggerLevel.Value = 500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Trigger level"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox2.Controls.Add(Me.lbl_TrigLevel)
        Me.GroupBox2.Controls.Add(Me.lbl_DeadTime)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tk_DeadTime)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tk_TriggerLevel)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(101, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(144, 130)
        Me.GroupBox2.TabIndex = 149
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Counter"
        '
        'lbl_TrigLevel
        '
        Me.lbl_TrigLevel.AutoSize = True
        Me.lbl_TrigLevel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TrigLevel.ForeColor = System.Drawing.Color.Black
        Me.lbl_TrigLevel.Location = New System.Drawing.Point(26, 95)
        Me.lbl_TrigLevel.Name = "lbl_TrigLevel"
        Me.lbl_TrigLevel.Size = New System.Drawing.Size(37, 13)
        Me.lbl_TrigLevel.TabIndex = 21
        Me.lbl_TrigLevel.Text = "100uS"
        '
        'lbl_DeadTime
        '
        Me.lbl_DeadTime.AutoSize = True
        Me.lbl_DeadTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DeadTime.ForeColor = System.Drawing.Color.Black
        Me.lbl_DeadTime.Location = New System.Drawing.Point(86, 95)
        Me.lbl_DeadTime.Name = "lbl_DeadTime"
        Me.lbl_DeadTime.Size = New System.Drawing.Size(37, 13)
        Me.lbl_DeadTime.TabIndex = 20
        Me.lbl_DeadTime.Text = "100uS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(80, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Dead time"
        '
        'tk_DeadTime
        '
        Me.tk_DeadTime.AutoSize = False
        Me.tk_DeadTime.Location = New System.Drawing.Point(84, 12)
        Me.tk_DeadTime.Maximum = 100
        Me.tk_DeadTime.Name = "tk_DeadTime"
        Me.tk_DeadTime.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tk_DeadTime.Size = New System.Drawing.Size(41, 89)
        Me.tk_DeadTime.TabIndex = 18
        Me.tk_DeadTime.TickFrequency = 10
        Me.tk_DeadTime.TickStyle = System.Windows.Forms.TickStyle.Both
        Me.tk_DeadTime.Value = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox1.Controls.Add(Me.txt_SlotSpectrum)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_SlotCounter)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_SlotMeter)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(5, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(92, 130)
        Me.GroupBox1.TabIndex = 150
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Outputs"
        '
        'txt_SlotSpectrum
        '
        Me.txt_SlotSpectrum.ArrowsIncrement = 1
        Me.txt_SlotSpectrum.BackColor = System.Drawing.Color.MintCream
        Me.txt_SlotSpectrum.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_SlotSpectrum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_SlotSpectrum.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SlotSpectrum.ForeColor = System.Drawing.Color.Black
        Me.txt_SlotSpectrum.Increment = 0.2
        Me.txt_SlotSpectrum.Location = New System.Drawing.Point(27, 104)
        Me.txt_SlotSpectrum.MaxValue = 999
        Me.txt_SlotSpectrum.MinValue = -1
        Me.txt_SlotSpectrum.Name = "txt_SlotSpectrum"
        Me.txt_SlotSpectrum.NumericValue = 0
        Me.txt_SlotSpectrum.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_SlotSpectrum.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_SlotSpectrum.RoundingStep = 0
        Me.txt_SlotSpectrum.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_SlotSpectrum.Size = New System.Drawing.Size(42, 16)
        Me.txt_SlotSpectrum.TabIndex = 132
        Me.txt_SlotSpectrum.Text = "0"
        Me.txt_SlotSpectrum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 131
        Me.Label4.Text = "Spec. first slot"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_SlotCounter
        '
        Me.txt_SlotCounter.ArrowsIncrement = 1
        Me.txt_SlotCounter.BackColor = System.Drawing.Color.MintCream
        Me.txt_SlotCounter.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_SlotCounter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_SlotCounter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SlotCounter.ForeColor = System.Drawing.Color.Black
        Me.txt_SlotCounter.Increment = 0.2
        Me.txt_SlotCounter.Location = New System.Drawing.Point(25, 31)
        Me.txt_SlotCounter.MaxValue = 999
        Me.txt_SlotCounter.MinValue = -1
        Me.txt_SlotCounter.Name = "txt_SlotCounter"
        Me.txt_SlotCounter.NumericValue = -1
        Me.txt_SlotCounter.NumericValueInteger = -1
        Me.txt_SlotCounter.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_SlotCounter.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_SlotCounter.RoundingStep = 0
        Me.txt_SlotCounter.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_SlotCounter.Size = New System.Drawing.Size(42, 16)
        Me.txt_SlotCounter.TabIndex = 129
        Me.txt_SlotCounter.Text = "-1"
        Me.txt_SlotCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 13)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "Counter slot"
        '
        'txt_SlotMeter
        '
        Me.txt_SlotMeter.ArrowsIncrement = 1
        Me.txt_SlotMeter.BackColor = System.Drawing.Color.MintCream
        Me.txt_SlotMeter.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_SlotMeter.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_SlotMeter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SlotMeter.ForeColor = System.Drawing.Color.Black
        Me.txt_SlotMeter.Increment = 0.2
        Me.txt_SlotMeter.Location = New System.Drawing.Point(25, 67)
        Me.txt_SlotMeter.MaxValue = 999
        Me.txt_SlotMeter.MinValue = -1
        Me.txt_SlotMeter.Name = "txt_SlotMeter"
        Me.txt_SlotMeter.NumericValue = -1
        Me.txt_SlotMeter.NumericValueInteger = -1
        Me.txt_SlotMeter.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_SlotMeter.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_SlotMeter.RoundingStep = 0
        Me.txt_SlotMeter.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_SlotMeter.Size = New System.Drawing.Size(42, 16)
        Me.txt_SlotMeter.TabIndex = 127
        Me.txt_SlotMeter.Text = "-1"
        Me.txt_SlotMeter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(18, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 128
        Me.Label7.Text = "Meter slot"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox3.Controls.Add(Me.pBox1)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(249, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(67, 130)
        Me.GroupBox3.TabIndex = 151
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Meter"
        '
        'pBox1
        '
        Me.pBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pBox1.Location = New System.Drawing.Point(25, 22)
        Me.pBox1.Name = "pBox1"
        Me.pBox1.Size = New System.Drawing.Size(19, 100)
        Me.pBox1.TabIndex = 18
        Me.pBox1.TabStop = False
        '
        'GroupBox_Bands
        '
        Me.GroupBox_Bands.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox_Bands.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox_Bands.Controls.Add(Me.chk_BandsAGC)
        Me.GroupBox_Bands.Controls.Add(Me.chk_BandsLogY)
        Me.GroupBox_Bands.Controls.Add(Me.chk_BandsLogX)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsSpeed)
        Me.GroupBox_Bands.Controls.Add(Me.Label5)
        Me.GroupBox_Bands.Controls.Add(Me.pbox_SpectrumBars)
        Me.GroupBox_Bands.Controls.Add(Me.Label10)
        Me.GroupBox_Bands.Controls.Add(Me.Label6)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsMaxDb)
        Me.GroupBox_Bands.Controls.Add(Me.Label14)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsCount)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsMaxFreq)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsMinDb)
        Me.GroupBox_Bands.Controls.Add(Me.txt_BandsMinFreq)
        Me.GroupBox_Bands.Controls.Add(Me.Label12)
        Me.GroupBox_Bands.Controls.Add(Me.Label13)
        Me.GroupBox_Bands.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_Bands.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox_Bands.Location = New System.Drawing.Point(321, 6)
        Me.GroupBox_Bands.MinimumSize = New System.Drawing.Size(310, 145)
        Me.GroupBox_Bands.Name = "GroupBox_Bands"
        Me.GroupBox_Bands.Size = New System.Drawing.Size(355, 167)
        Me.GroupBox_Bands.TabIndex = 152
        Me.GroupBox_Bands.TabStop = False
        Me.GroupBox_Bands.Text = "FHT Spectrum bands"
        '
        'chk_BandsAGC
        '
        Me.chk_BandsAGC.BorderColor = System.Drawing.Color.DarkGray
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsAGC.CenterPtTracker = DesignerRectTracker1
        Me.chk_BandsAGC.CheckButton = True
        Me.chk_BandsAGC.Checked = True
        CBlendItems1.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))}
        CBlendItems1.iPoint = New Single() {0.0!, 0.8683274!, 1.0!}
        Me.chk_BandsAGC.ColorFillBlend = CBlendItems1
        CBlendItems2.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems2.iPoint = New Single() {0.0!, 0.2491103!, 1.0!}
        Me.chk_BandsAGC.ColorFillBlendChecked = CBlendItems2
        Me.chk_BandsAGC.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.chk_BandsAGC.ColorFillSolidChecked = System.Drawing.SystemColors.Control
        Me.chk_BandsAGC.Corners.All = CType(6, Short)
        Me.chk_BandsAGC.Corners.LowerLeft = CType(6, Short)
        Me.chk_BandsAGC.Corners.LowerRight = CType(6, Short)
        Me.chk_BandsAGC.Corners.UpperLeft = CType(6, Short)
        Me.chk_BandsAGC.Corners.UpperRight = CType(6, Short)
        Me.chk_BandsAGC.DimFactorOver = 30
        Me.chk_BandsAGC.FillType = MyButton.eFillType.LinearVertical
        Me.chk_BandsAGC.FillTypeChecked = MyButton.eFillType.LinearVertical
        Me.chk_BandsAGC.FocalPoints.CenterPtX = 1.0!
        Me.chk_BandsAGC.FocalPoints.CenterPtY = 1.0!
        Me.chk_BandsAGC.FocalPoints.FocusPtX = 0.0!
        Me.chk_BandsAGC.FocalPoints.FocusPtY = 0.0!
        Me.chk_BandsAGC.FocalPointsChecked.CenterPtX = 0.0!
        Me.chk_BandsAGC.FocalPointsChecked.CenterPtY = 0.0!
        Me.chk_BandsAGC.FocalPointsChecked.FocusPtX = 0.0!
        Me.chk_BandsAGC.FocalPointsChecked.FocusPtY = 0.0!
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsAGC.FocusPtTracker = DesignerRectTracker2
        Me.chk_BandsAGC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BandsAGC.Image = Nothing
        Me.chk_BandsAGC.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsAGC.ImageIndex = 0
        Me.chk_BandsAGC.ImageSize = New System.Drawing.Size(16, 16)
        Me.chk_BandsAGC.Location = New System.Drawing.Point(273, 1)
        Me.chk_BandsAGC.Name = "chk_BandsAGC"
        Me.chk_BandsAGC.Shape = MyButton.eShape.Rectangle
        Me.chk_BandsAGC.SideImage = Nothing
        Me.chk_BandsAGC.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsAGC.SideImageSize = New System.Drawing.Size(32, 32)
        Me.chk_BandsAGC.Size = New System.Drawing.Size(40, 16)
        Me.chk_BandsAGC.TabIndex = 60
        Me.chk_BandsAGC.Text = "AGC"
        Me.chk_BandsAGC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsAGC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chk_BandsAGC.TextMargin = New System.Windows.Forms.Padding(0)
        Me.chk_BandsAGC.TextShadow = System.Drawing.Color.Transparent
        '
        'chk_BandsLogY
        '
        Me.chk_BandsLogY.BorderColor = System.Drawing.Color.DarkGray
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsLogY.CenterPtTracker = DesignerRectTracker3
        Me.chk_BandsLogY.CheckButton = True
        CBlendItems3.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))}
        CBlendItems3.iPoint = New Single() {0.0!, 0.8683274!, 1.0!}
        Me.chk_BandsLogY.ColorFillBlend = CBlendItems3
        CBlendItems4.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems4.iPoint = New Single() {0.0!, 0.2491103!, 1.0!}
        Me.chk_BandsLogY.ColorFillBlendChecked = CBlendItems4
        Me.chk_BandsLogY.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.chk_BandsLogY.ColorFillSolidChecked = System.Drawing.SystemColors.Control
        Me.chk_BandsLogY.Corners.All = CType(6, Short)
        Me.chk_BandsLogY.Corners.LowerLeft = CType(6, Short)
        Me.chk_BandsLogY.Corners.LowerRight = CType(6, Short)
        Me.chk_BandsLogY.Corners.UpperLeft = CType(6, Short)
        Me.chk_BandsLogY.Corners.UpperRight = CType(6, Short)
        Me.chk_BandsLogY.DimFactorOver = 30
        Me.chk_BandsLogY.FillType = MyButton.eFillType.LinearVertical
        Me.chk_BandsLogY.FillTypeChecked = MyButton.eFillType.LinearVertical
        Me.chk_BandsLogY.FocalPoints.CenterPtX = 1.0!
        Me.chk_BandsLogY.FocalPoints.CenterPtY = 1.0!
        Me.chk_BandsLogY.FocalPoints.FocusPtX = 0.0!
        Me.chk_BandsLogY.FocalPoints.FocusPtY = 0.0!
        Me.chk_BandsLogY.FocalPointsChecked.CenterPtX = 0.0!
        Me.chk_BandsLogY.FocalPointsChecked.CenterPtY = 0.0!
        Me.chk_BandsLogY.FocalPointsChecked.FocusPtX = 0.0!
        Me.chk_BandsLogY.FocalPointsChecked.FocusPtY = 0.0!
        DesignerRectTracker4.IsActive = True
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsLogY.FocusPtTracker = DesignerRectTracker4
        Me.chk_BandsLogY.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BandsLogY.Image = Nothing
        Me.chk_BandsLogY.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogY.ImageIndex = 0
        Me.chk_BandsLogY.ImageSize = New System.Drawing.Size(16, 16)
        Me.chk_BandsLogY.Location = New System.Drawing.Point(65, 134)
        Me.chk_BandsLogY.Name = "chk_BandsLogY"
        Me.chk_BandsLogY.Shape = MyButton.eShape.Rectangle
        Me.chk_BandsLogY.SideImage = Nothing
        Me.chk_BandsLogY.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogY.SideImageSize = New System.Drawing.Size(32, 32)
        Me.chk_BandsLogY.Size = New System.Drawing.Size(44, 16)
        Me.chk_BandsLogY.TabIndex = 59
        Me.chk_BandsLogY.Text = "Log Y"
        Me.chk_BandsLogY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogY.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chk_BandsLogY.TextMargin = New System.Windows.Forms.Padding(0)
        Me.chk_BandsLogY.TextShadow = System.Drawing.Color.Transparent
        '
        'chk_BandsLogX
        '
        Me.chk_BandsLogX.BorderColor = System.Drawing.Color.DarkGray
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsLogX.CenterPtTracker = DesignerRectTracker5
        Me.chk_BandsLogX.CheckButton = True
        Me.chk_BandsLogX.Checked = True
        CBlendItems5.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))}
        CBlendItems5.iPoint = New Single() {0.0!, 0.8683274!, 1.0!}
        Me.chk_BandsLogX.ColorFillBlend = CBlendItems5
        CBlendItems6.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems6.iPoint = New Single() {0.0!, 0.2491103!, 1.0!}
        Me.chk_BandsLogX.ColorFillBlendChecked = CBlendItems6
        Me.chk_BandsLogX.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.chk_BandsLogX.ColorFillSolidChecked = System.Drawing.SystemColors.Control
        Me.chk_BandsLogX.Corners.All = CType(6, Short)
        Me.chk_BandsLogX.Corners.LowerLeft = CType(6, Short)
        Me.chk_BandsLogX.Corners.LowerRight = CType(6, Short)
        Me.chk_BandsLogX.Corners.UpperLeft = CType(6, Short)
        Me.chk_BandsLogX.Corners.UpperRight = CType(6, Short)
        Me.chk_BandsLogX.DimFactorOver = 30
        Me.chk_BandsLogX.FillType = MyButton.eFillType.LinearVertical
        Me.chk_BandsLogX.FillTypeChecked = MyButton.eFillType.LinearVertical
        Me.chk_BandsLogX.FocalPoints.CenterPtX = 1.0!
        Me.chk_BandsLogX.FocalPoints.CenterPtY = 1.0!
        Me.chk_BandsLogX.FocalPoints.FocusPtX = 0.0!
        Me.chk_BandsLogX.FocalPoints.FocusPtY = 0.0!
        Me.chk_BandsLogX.FocalPointsChecked.CenterPtX = 0.0!
        Me.chk_BandsLogX.FocalPointsChecked.CenterPtY = 0.0!
        Me.chk_BandsLogX.FocalPointsChecked.FocusPtX = 0.0!
        Me.chk_BandsLogX.FocalPointsChecked.FocusPtY = 0.0!
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), System.Drawing.RectangleF)
        Me.chk_BandsLogX.FocusPtTracker = DesignerRectTracker6
        Me.chk_BandsLogX.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_BandsLogX.Image = Nothing
        Me.chk_BandsLogX.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogX.ImageIndex = 0
        Me.chk_BandsLogX.ImageSize = New System.Drawing.Size(16, 16)
        Me.chk_BandsLogX.Location = New System.Drawing.Point(17, 134)
        Me.chk_BandsLogX.Name = "chk_BandsLogX"
        Me.chk_BandsLogX.Shape = MyButton.eShape.Rectangle
        Me.chk_BandsLogX.SideImage = Nothing
        Me.chk_BandsLogX.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogX.SideImageSize = New System.Drawing.Size(32, 32)
        Me.chk_BandsLogX.Size = New System.Drawing.Size(44, 16)
        Me.chk_BandsLogX.TabIndex = 58
        Me.chk_BandsLogX.Text = "Log X"
        Me.chk_BandsLogX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_BandsLogX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chk_BandsLogX.TextMargin = New System.Windows.Forms.Padding(0)
        Me.chk_BandsLogX.TextShadow = System.Drawing.Color.Transparent
        '
        'txt_BandsSpeed
        '
        Me.txt_BandsSpeed.ArrowsIncrement = 1
        Me.txt_BandsSpeed.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsSpeed.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsSpeed.DimFactorGray = -65
        Me.txt_BandsSpeed.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsSpeed.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsSpeed.Increment = 0.02
        Me.txt_BandsSpeed.Location = New System.Drawing.Point(67, 111)
        Me.txt_BandsSpeed.MaxValue = 100
        Me.txt_BandsSpeed.MinValue = 1
        Me.txt_BandsSpeed.Name = "txt_BandsSpeed"
        Me.txt_BandsSpeed.NumericValue = 10
        Me.txt_BandsSpeed.NumericValueInteger = 10
        Me.txt_BandsSpeed.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsSpeed.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsSpeed.RoundingStep = 0
        Me.txt_BandsSpeed.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsSpeed.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsSpeed.TabIndex = 55
        Me.txt_BandsSpeed.Text = "10"
        Me.txt_BandsSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Speed"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pbox_SpectrumBars
        '
        Me.pbox_SpectrumBars.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbox_SpectrumBars.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbox_SpectrumBars.Location = New System.Drawing.Point(123, 23)
        Me.pbox_SpectrumBars.Name = "pbox_SpectrumBars"
        Me.pbox_SpectrumBars.Size = New System.Drawing.Size(224, 136)
        Me.pbox_SpectrumBars.TabIndex = 0
        Me.pbox_SpectrumBars.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(11, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Max dB"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(150, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Bands"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_BandsMaxDb
        '
        Me.txt_BandsMaxDb.ArrowsIncrement = 1
        Me.txt_BandsMaxDb.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsMaxDb.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsMaxDb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsMaxDb.DimFactorGray = -65
        Me.txt_BandsMaxDb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsMaxDb.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsMaxDb.Increment = 0.1
        Me.txt_BandsMaxDb.Location = New System.Drawing.Point(67, 30)
        Me.txt_BandsMaxDb.MaxValue = 0
        Me.txt_BandsMaxDb.MinValue = -120
        Me.txt_BandsMaxDb.Name = "txt_BandsMaxDb"
        Me.txt_BandsMaxDb.NumericValue = -20
        Me.txt_BandsMaxDb.NumericValueInteger = -20
        Me.txt_BandsMaxDb.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsMaxDb.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsMaxDb.RoundingStep = 0
        Me.txt_BandsMaxDb.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsMaxDb.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsMaxDb.TabIndex = 51
        Me.txt_BandsMaxDb.Text = "-20"
        Me.txt_BandsMaxDb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 72)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Max freq."
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_BandsCount
        '
        Me.txt_BandsCount.ArrowsIncrement = 1
        Me.txt_BandsCount.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsCount.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsCount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsCount.DimFactorGray = -65
        Me.txt_BandsCount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsCount.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsCount.Increment = 0.1
        Me.txt_BandsCount.Location = New System.Drawing.Point(208, 1)
        Me.txt_BandsCount.MaxValue = 100
        Me.txt_BandsCount.MinValue = 1
        Me.txt_BandsCount.Name = "txt_BandsCount"
        Me.txt_BandsCount.NumericValue = 3
        Me.txt_BandsCount.NumericValueInteger = 3
        Me.txt_BandsCount.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsCount.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsCount.RoundingStep = 0
        Me.txt_BandsCount.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsCount.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsCount.TabIndex = 50
        Me.txt_BandsCount.Text = "3"
        Me.txt_BandsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_BandsMaxFreq
        '
        Me.txt_BandsMaxFreq.ArrowsIncrement = 1
        Me.txt_BandsMaxFreq.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsMaxFreq.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsMaxFreq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsMaxFreq.DimFactorGray = -65
        Me.txt_BandsMaxFreq.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsMaxFreq.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsMaxFreq.Increment = 0.1
        Me.txt_BandsMaxFreq.Location = New System.Drawing.Point(67, 70)
        Me.txt_BandsMaxFreq.MaxValue = 22000
        Me.txt_BandsMaxFreq.MinValue = 1
        Me.txt_BandsMaxFreq.Name = "txt_BandsMaxFreq"
        Me.txt_BandsMaxFreq.NumericValue = 16000
        Me.txt_BandsMaxFreq.NumericValueInteger = 16000
        Me.txt_BandsMaxFreq.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsMaxFreq.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsMaxFreq.RoundingStep = 0
        Me.txt_BandsMaxFreq.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsMaxFreq.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsMaxFreq.TabIndex = 53
        Me.txt_BandsMaxFreq.Text = "16000"
        Me.txt_BandsMaxFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_BandsMinDb
        '
        Me.txt_BandsMinDb.ArrowsIncrement = 1
        Me.txt_BandsMinDb.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsMinDb.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsMinDb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsMinDb.DimFactorGray = -65
        Me.txt_BandsMinDb.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsMinDb.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsMinDb.Increment = 0.1
        Me.txt_BandsMinDb.Location = New System.Drawing.Point(67, 50)
        Me.txt_BandsMinDb.MaxValue = 0
        Me.txt_BandsMinDb.MinValue = -120
        Me.txt_BandsMinDb.Name = "txt_BandsMinDb"
        Me.txt_BandsMinDb.NumericValue = -40
        Me.txt_BandsMinDb.NumericValueInteger = -40
        Me.txt_BandsMinDb.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsMinDb.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsMinDb.RoundingStep = 0
        Me.txt_BandsMinDb.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsMinDb.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsMinDb.TabIndex = 52
        Me.txt_BandsMinDb.Text = "-40"
        Me.txt_BandsMinDb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_BandsMinFreq
        '
        Me.txt_BandsMinFreq.ArrowsIncrement = 1
        Me.txt_BandsMinFreq.BackColor = System.Drawing.Color.MintCream
        Me.txt_BandsMinFreq.BackColor_Over = System.Drawing.Color.Moccasin
        Me.txt_BandsMinFreq.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_BandsMinFreq.DimFactorGray = -65
        Me.txt_BandsMinFreq.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_BandsMinFreq.ForeColor = System.Drawing.Color.Black
        Me.txt_BandsMinFreq.Increment = 0.1
        Me.txt_BandsMinFreq.Location = New System.Drawing.Point(67, 90)
        Me.txt_BandsMinFreq.MaxValue = 22000
        Me.txt_BandsMinFreq.MinValue = 1
        Me.txt_BandsMinFreq.Name = "txt_BandsMinFreq"
        Me.txt_BandsMinFreq.NumericValue = 80
        Me.txt_BandsMinFreq.NumericValueInteger = 80
        Me.txt_BandsMinFreq.RectangleColor = System.Drawing.Color.PowderBlue
        Me.txt_BandsMinFreq.RectangleStyle = System.Windows.Forms.ButtonBorderStyle.Dashed
        Me.txt_BandsMinFreq.RoundingStep = 0
        Me.txt_BandsMinFreq.ShadowColor = System.Drawing.Color.LightGray
        Me.txt_BandsMinFreq.Size = New System.Drawing.Size(46, 16)
        Me.txt_BandsMinFreq.TabIndex = 54
        Me.txt_BandsMinFreq.Text = "80"
        Me.txt_BandsMinFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(11, 92)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Min freq."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Min dB"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_AudioInputs
        '
        Me.btn_AudioInputs.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_AudioInputs.BorderColor = System.Drawing.Color.DarkGray
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btn_AudioInputs.CenterPtTracker = DesignerRectTracker7
        CBlendItems7.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(140, Byte), Integer))}
        CBlendItems7.iPoint = New Single() {0.0!, 0.8683274!, 1.0!}
        Me.btn_AudioInputs.ColorFillBlend = CBlendItems7
        CBlendItems8.iColor = New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))}
        CBlendItems8.iPoint = New Single() {0.0!, 0.2491103!, 1.0!}
        Me.btn_AudioInputs.ColorFillBlendChecked = CBlendItems8
        Me.btn_AudioInputs.ColorFillSolid = System.Drawing.SystemColors.Control
        Me.btn_AudioInputs.ColorFillSolidChecked = System.Drawing.SystemColors.Control
        Me.btn_AudioInputs.Corners.All = CType(6, Short)
        Me.btn_AudioInputs.Corners.LowerLeft = CType(6, Short)
        Me.btn_AudioInputs.Corners.LowerRight = CType(6, Short)
        Me.btn_AudioInputs.Corners.UpperLeft = CType(6, Short)
        Me.btn_AudioInputs.Corners.UpperRight = CType(6, Short)
        Me.btn_AudioInputs.DimFactorOver = 30
        Me.btn_AudioInputs.FillType = MyButton.eFillType.LinearVertical
        Me.btn_AudioInputs.FillTypeChecked = MyButton.eFillType.LinearVertical
        Me.btn_AudioInputs.FocalPoints.CenterPtX = 1.0!
        Me.btn_AudioInputs.FocalPoints.CenterPtY = 1.0!
        Me.btn_AudioInputs.FocalPoints.FocusPtX = 0.0!
        Me.btn_AudioInputs.FocalPoints.FocusPtY = 0.0!
        Me.btn_AudioInputs.FocalPointsChecked.CenterPtX = 0.0!
        Me.btn_AudioInputs.FocalPointsChecked.CenterPtY = 0.0!
        Me.btn_AudioInputs.FocalPointsChecked.FocusPtX = 0.0!
        Me.btn_AudioInputs.FocalPointsChecked.FocusPtY = 0.0!
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), System.Drawing.RectangleF)
        Me.btn_AudioInputs.FocusPtTracker = DesignerRectTracker8
        Me.btn_AudioInputs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AudioInputs.Image = Nothing
        Me.btn_AudioInputs.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_AudioInputs.ImageIndex = 0
        Me.btn_AudioInputs.ImageSize = New System.Drawing.Size(16, 16)
        Me.btn_AudioInputs.Location = New System.Drawing.Point(220, 10)
        Me.btn_AudioInputs.Name = "btn_AudioInputs"
        Me.btn_AudioInputs.Shape = MyButton.eShape.Rectangle
        Me.btn_AudioInputs.SideImage = Nothing
        Me.btn_AudioInputs.SideImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_AudioInputs.SideImageSize = New System.Drawing.Size(32, 32)
        Me.btn_AudioInputs.Size = New System.Drawing.Size(79, 18)
        Me.btn_AudioInputs.TabIndex = 233
        Me.btn_AudioInputs.Text = "Audio inputs"
        Me.btn_AudioInputs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_AudioInputs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_AudioInputs.TextMargin = New System.Windows.Forms.Padding(0)
        Me.btn_AudioInputs.TextShadow = System.Drawing.Color.Transparent
        '
        'cmb_AudioInDevices
        '
        Me.cmb_AudioInDevices.ArrowButtonColor = System.Drawing.Color.Transparent
        Me.cmb_AudioInDevices.ArrowColor = System.Drawing.Color.DarkGray
        Me.cmb_AudioInDevices.BackColor = System.Drawing.Color.FloralWhite
        Me.cmb_AudioInDevices.BackColor_Focused = System.Drawing.Color.FloralWhite
        Me.cmb_AudioInDevices.BackColor_Over = System.Drawing.Color.Moccasin
        Me.cmb_AudioInDevices.BorderColor = System.Drawing.Color.DarkGray
        Me.cmb_AudioInDevices.BorderSize = 1
        Me.cmb_AudioInDevices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmb_AudioInDevices.DropDown_BackColor = System.Drawing.Color.Cornsilk
        Me.cmb_AudioInDevices.DropDown_BackSelected = System.Drawing.Color.Moccasin
        Me.cmb_AudioInDevices.DropDown_BorderColor = System.Drawing.Color.Cornsilk
        Me.cmb_AudioInDevices.DropDown_ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmb_AudioInDevices.DropDown_ForeSelected = System.Drawing.SystemColors.WindowText
        Me.cmb_AudioInDevices.DropDownHeight = 500
        Me.cmb_AudioInDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AudioInDevices.DropDownWidth = 180
        Me.cmb_AudioInDevices.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmb_AudioInDevices.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_AudioInDevices.ForeColor = System.Drawing.Color.Black
        Me.cmb_AudioInDevices.IntegralHeight = False
        Me.cmb_AudioInDevices.ItemHeight = 11
        Me.cmb_AudioInDevices.Items.AddRange(New Object() {"Auto"})
        Me.cmb_AudioInDevices.Location = New System.Drawing.Point(62, 11)
        Me.cmb_AudioInDevices.Name = "cmb_AudioInDevices"
        Me.cmb_AudioInDevices.ShadowColor = System.Drawing.Color.LightGray
        Me.cmb_AudioInDevices.Size = New System.Drawing.Size(141, 17)
        Me.cmb_AudioInDevices.TabIndex = 234
        Me.cmb_AudioInDevices.TextPosition = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.GroupBox4.Controls.Add(Me.cmb_AudioInDevices)
        Me.GroupBox4.Controls.Add(Me.btn_AudioInputs)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(309, 34)
        Me.GroupBox4.TabIndex = 235
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Input"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(680, 177)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox_Bands)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Theremino AudioInput"
        CType(Me.tk_TriggerLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.tk_DeadTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.pBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox_Bands.ResumeLayout(False)
        Me.GroupBox_Bands.PerformLayout()
        CType(Me.pbox_SpectrumBars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tk_TriggerLevel As System.Windows.Forms.TrackBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_SlotCounter As MyTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_SlotMeter As MyTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tk_DeadTime As System.Windows.Forms.TrackBar
    Friend WithEvents pBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_TrigLevel As System.Windows.Forms.Label
    Friend WithEvents lbl_DeadTime As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_SlotSpectrum As MyTextBox
    Friend WithEvents GroupBox_Bands As System.Windows.Forms.GroupBox
    Friend WithEvents chk_BandsLogY As MyButton
    Friend WithEvents chk_BandsLogX As MyButton
    Friend WithEvents txt_BandsSpeed As MyTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbox_SpectrumBars As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_BandsMaxDb As MyTextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_BandsCount As MyTextBox
    Friend WithEvents txt_BandsMaxFreq As MyTextBox
    Friend WithEvents txt_BandsMinDb As MyTextBox
    Friend WithEvents txt_BandsMinFreq As MyTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chk_BandsAGC As MyButton
    Friend WithEvents btn_AudioInputs As MyButton
    Friend WithEvents cmb_AudioInDevices As MyComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
