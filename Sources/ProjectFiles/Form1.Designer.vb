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
        components = New ComponentModel.Container()
        Dim DesignerRectTracker1 As DesignerRectTracker = New DesignerRectTracker()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CBlendItems1 As cBlendItems = New cBlendItems()
        Dim CBlendItems2 As cBlendItems = New cBlendItems()
        Dim DesignerRectTracker2 As DesignerRectTracker = New DesignerRectTracker()
        Dim DesignerRectTracker3 As DesignerRectTracker = New DesignerRectTracker()
        Dim CBlendItems3 As cBlendItems = New cBlendItems()
        Dim CBlendItems4 As cBlendItems = New cBlendItems()
        Dim DesignerRectTracker4 As DesignerRectTracker = New DesignerRectTracker()
        Dim DesignerRectTracker5 As DesignerRectTracker = New DesignerRectTracker()
        Dim CBlendItems5 As cBlendItems = New cBlendItems()
        Dim CBlendItems6 As cBlendItems = New cBlendItems()
        Dim DesignerRectTracker6 As DesignerRectTracker = New DesignerRectTracker()
        Dim DesignerRectTracker7 As DesignerRectTracker = New DesignerRectTracker()
        Dim CBlendItems7 As cBlendItems = New cBlendItems()
        Dim CBlendItems8 As cBlendItems = New cBlendItems()
        Dim DesignerRectTracker8 As DesignerRectTracker = New DesignerRectTracker()
        Timer1 = New Timer(components)
        tk_TriggerLevel = New TrackBar()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        lbl_TrigLevel = New Label()
        lbl_DeadTime = New Label()
        Label3 = New Label()
        tk_DeadTime = New TrackBar()
        GroupBox1 = New GroupBox()
        txt_SlotSpectrum = New MyTextBox()
        Label4 = New Label()
        txt_SlotCounter = New MyTextBox()
        Label8 = New Label()
        txt_SlotMeter = New MyTextBox()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        pBox1 = New PictureBox()
        GroupBox_Bands = New GroupBox()
        chkEnableServer = New CheckBox()
        chk_BandsAGC = New MyButton()
        chk_BandsLogY = New MyButton()
        chk_BandsLogX = New MyButton()
        txt_BandsSpeed = New MyTextBox()
        Label5 = New Label()
        pbox_SpectrumBars = New PictureBox()
        Label10 = New Label()
        Label6 = New Label()
        txt_BandsMaxDb = New MyTextBox()
        Label14 = New Label()
        txt_BandsCount = New MyTextBox()
        txt_BandsMaxFreq = New MyTextBox()
        txt_BandsMinDb = New MyTextBox()
        txt_BandsMinFreq = New MyTextBox()
        Label12 = New Label()
        Label13 = New Label()
        btn_AudioInputs = New MyButton()
        cmb_AudioInDevices = New MyComboBox()
        GroupBox4 = New GroupBox()
        CType(tk_TriggerLevel, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(tk_DeadTime, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(pBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox_Bands.SuspendLayout()
        CType(pbox_SpectrumBars, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        ' 
        ' tk_TriggerLevel
        ' 
        tk_TriggerLevel.AutoSize = False
        tk_TriggerLevel.Location = New Point(27, 14)
        tk_TriggerLevel.Margin = New Padding(4, 3, 4, 3)
        tk_TriggerLevel.Maximum = 999
        tk_TriggerLevel.Minimum = 1
        tk_TriggerLevel.Name = "tk_TriggerLevel"
        tk_TriggerLevel.Orientation = Orientation.Vertical
        tk_TriggerLevel.Size = New Size(50, 103)
        tk_TriggerLevel.TabIndex = 15
        tk_TriggerLevel.TickFrequency = 100
        tk_TriggerLevel.TickStyle = TickStyle.Both
        tk_TriggerLevel.Value = 500
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(13, 127)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 13)
        Label1.TabIndex = 17
        Label1.Text = "Trigger level"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.LightGoldenrodYellow
        GroupBox2.Controls.Add(lbl_TrigLevel)
        GroupBox2.Controls.Add(lbl_DeadTime)
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(tk_DeadTime)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Controls.Add(tk_TriggerLevel)
        GroupBox2.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox2.ForeColor = Color.Navy
        GroupBox2.Location = New Point(118, 51)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(168, 150)
        GroupBox2.TabIndex = 149
        GroupBox2.TabStop = False
        GroupBox2.Text = "Counter"
        ' 
        ' lbl_TrigLevel
        ' 
        lbl_TrigLevel.AutoSize = True
        lbl_TrigLevel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_TrigLevel.ForeColor = Color.Black
        lbl_TrigLevel.Location = New Point(30, 110)
        lbl_TrigLevel.Margin = New Padding(4, 0, 4, 0)
        lbl_TrigLevel.Name = "lbl_TrigLevel"
        lbl_TrigLevel.Size = New Size(37, 13)
        lbl_TrigLevel.TabIndex = 21
        lbl_TrigLevel.Text = "100uS"
        ' 
        ' lbl_DeadTime
        ' 
        lbl_DeadTime.AutoSize = True
        lbl_DeadTime.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_DeadTime.ForeColor = Color.Black
        lbl_DeadTime.Location = New Point(100, 110)
        lbl_DeadTime.Margin = New Padding(4, 0, 4, 0)
        lbl_DeadTime.Name = "lbl_DeadTime"
        lbl_DeadTime.Size = New Size(37, 13)
        lbl_DeadTime.TabIndex = 20
        lbl_DeadTime.Text = "100uS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(93, 127)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 13)
        Label3.TabIndex = 19
        Label3.Text = "Dead time"
        ' 
        ' tk_DeadTime
        ' 
        tk_DeadTime.AutoSize = False
        tk_DeadTime.Location = New Point(98, 14)
        tk_DeadTime.Margin = New Padding(4, 3, 4, 3)
        tk_DeadTime.Maximum = 100
        tk_DeadTime.Name = "tk_DeadTime"
        tk_DeadTime.Orientation = Orientation.Vertical
        tk_DeadTime.Size = New Size(48, 103)
        tk_DeadTime.TabIndex = 18
        tk_DeadTime.TickFrequency = 10
        tk_DeadTime.TickStyle = TickStyle.Both
        tk_DeadTime.Value = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGoldenrodYellow
        GroupBox1.Controls.Add(txt_SlotSpectrum)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txt_SlotCounter)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(txt_SlotMeter)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(6, 51)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(107, 150)
        GroupBox1.TabIndex = 150
        GroupBox1.TabStop = False
        GroupBox1.Text = "Outputs"
        ' 
        ' txt_SlotSpectrum
        ' 
        txt_SlotSpectrum.ArrowsIncrement = 1R
        txt_SlotSpectrum.BackColor = Color.MintCream
        txt_SlotSpectrum.BackColor_Over = Color.Moccasin
        txt_SlotSpectrum.BorderStyle = BorderStyle.None
        txt_SlotSpectrum.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_SlotSpectrum.ForeColor = Color.Black
        txt_SlotSpectrum.Increment = 0.2R
        txt_SlotSpectrum.Location = New Point(31, 120)
        txt_SlotSpectrum.Margin = New Padding(4, 3, 4, 3)
        txt_SlotSpectrum.MaxValue = 999R
        txt_SlotSpectrum.MinValue = -1R
        txt_SlotSpectrum.Name = "txt_SlotSpectrum"
        txt_SlotSpectrum.NumericValue = 0R
        txt_SlotSpectrum.RectangleColor = Color.PowderBlue
        txt_SlotSpectrum.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotSpectrum.RoundingStep = 0R
        txt_SlotSpectrum.ShadowColor = Color.LightGray
        txt_SlotSpectrum.Size = New Size(49, 16)
        txt_SlotSpectrum.TabIndex = 132
        txt_SlotSpectrum.Text = "0"
        txt_SlotSpectrum.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(8, 98)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 21)
        Label4.TabIndex = 131
        Label4.Text = "Spec. first slot"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txt_SlotCounter
        ' 
        txt_SlotCounter.ArrowsIncrement = 1R
        txt_SlotCounter.BackColor = Color.MintCream
        txt_SlotCounter.BackColor_Over = Color.Moccasin
        txt_SlotCounter.BorderStyle = BorderStyle.None
        txt_SlotCounter.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_SlotCounter.ForeColor = Color.Black
        txt_SlotCounter.Increment = 0.2R
        txt_SlotCounter.Location = New Point(29, 36)
        txt_SlotCounter.Margin = New Padding(4, 3, 4, 3)
        txt_SlotCounter.MaxValue = 999R
        txt_SlotCounter.MinValue = -1R
        txt_SlotCounter.Name = "txt_SlotCounter"
        txt_SlotCounter.NumericValue = -1R
        txt_SlotCounter.NumericValueInteger = -1
        txt_SlotCounter.RectangleColor = Color.PowderBlue
        txt_SlotCounter.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotCounter.RoundingStep = 0R
        txt_SlotCounter.ShadowColor = Color.LightGray
        txt_SlotCounter.Size = New Size(49, 16)
        txt_SlotCounter.TabIndex = 129
        txt_SlotCounter.Text = "-1"
        txt_SlotCounter.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(15, 21)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(66, 13)
        Label8.TabIndex = 130
        Label8.Text = "Counter slot"
        ' 
        ' txt_SlotMeter
        ' 
        txt_SlotMeter.ArrowsIncrement = 1R
        txt_SlotMeter.BackColor = Color.MintCream
        txt_SlotMeter.BackColor_Over = Color.Moccasin
        txt_SlotMeter.BorderStyle = BorderStyle.None
        txt_SlotMeter.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_SlotMeter.ForeColor = Color.Black
        txt_SlotMeter.Increment = 0.2R
        txt_SlotMeter.Location = New Point(29, 77)
        txt_SlotMeter.Margin = New Padding(4, 3, 4, 3)
        txt_SlotMeter.MaxValue = 999R
        txt_SlotMeter.MinValue = -1R
        txt_SlotMeter.Name = "txt_SlotMeter"
        txt_SlotMeter.NumericValue = -1R
        txt_SlotMeter.NumericValueInteger = -1
        txt_SlotMeter.RectangleColor = Color.PowderBlue
        txt_SlotMeter.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotMeter.RoundingStep = 0R
        txt_SlotMeter.ShadowColor = Color.LightGray
        txt_SlotMeter.Size = New Size(49, 16)
        txt_SlotMeter.TabIndex = 127
        txt_SlotMeter.Text = "-1"
        txt_SlotMeter.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(21, 59)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 13)
        Label7.TabIndex = 128
        Label7.Text = "Meter slot"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.LightGoldenrodYellow
        GroupBox3.Controls.Add(pBox1)
        GroupBox3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.Navy
        GroupBox3.Location = New Point(290, 51)
        GroupBox3.Margin = New Padding(4, 3, 4, 3)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(4, 3, 4, 3)
        GroupBox3.Size = New Size(78, 150)
        GroupBox3.TabIndex = 151
        GroupBox3.TabStop = False
        GroupBox3.Text = "Meter"
        ' 
        ' pBox1
        ' 
        pBox1.BorderStyle = BorderStyle.Fixed3D
        pBox1.Location = New Point(29, 25)
        pBox1.Margin = New Padding(4, 3, 4, 3)
        pBox1.Name = "pBox1"
        pBox1.Size = New Size(22, 115)
        pBox1.TabIndex = 18
        pBox1.TabStop = False
        ' 
        ' GroupBox_Bands
        ' 
        GroupBox_Bands.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox_Bands.BackColor = Color.LightGoldenrodYellow
        GroupBox_Bands.Controls.Add(chkEnableServer)
        GroupBox_Bands.Controls.Add(chk_BandsAGC)
        GroupBox_Bands.Controls.Add(chk_BandsLogY)
        GroupBox_Bands.Controls.Add(chk_BandsLogX)
        GroupBox_Bands.Controls.Add(txt_BandsSpeed)
        GroupBox_Bands.Controls.Add(Label5)
        GroupBox_Bands.Controls.Add(pbox_SpectrumBars)
        GroupBox_Bands.Controls.Add(Label10)
        GroupBox_Bands.Controls.Add(Label6)
        GroupBox_Bands.Controls.Add(txt_BandsMaxDb)
        GroupBox_Bands.Controls.Add(Label14)
        GroupBox_Bands.Controls.Add(txt_BandsCount)
        GroupBox_Bands.Controls.Add(txt_BandsMaxFreq)
        GroupBox_Bands.Controls.Add(txt_BandsMinDb)
        GroupBox_Bands.Controls.Add(txt_BandsMinFreq)
        GroupBox_Bands.Controls.Add(Label12)
        GroupBox_Bands.Controls.Add(Label13)
        GroupBox_Bands.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox_Bands.ForeColor = Color.Navy
        GroupBox_Bands.Location = New Point(374, 7)
        GroupBox_Bands.Margin = New Padding(4, 3, 4, 3)
        GroupBox_Bands.MinimumSize = New Size(362, 167)
        GroupBox_Bands.Name = "GroupBox_Bands"
        GroupBox_Bands.Padding = New Padding(4, 3, 4, 3)
        GroupBox_Bands.Size = New Size(377, 193)
        GroupBox_Bands.TabIndex = 152
        GroupBox_Bands.TabStop = False
        GroupBox_Bands.Text = "FHT Spectrum bands"
        ' 
        ' chkEnableServer
        ' 
        chkEnableServer.AutoSize = True
        chkEnableServer.Location = New Point(304, 34)
        chkEnableServer.Name = "chkEnableServer"
        chkEnableServer.Size = New Size(58, 17)
        chkEnableServer.TabIndex = 236
        chkEnableServer.Text = "Server"
        chkEnableServer.UseVisualStyleBackColor = True
        ' 
        ' chk_BandsAGC
        ' 
        chk_BandsAGC.BorderColor = Color.DarkGray
        DesignerRectTracker1.IsActive = False
        DesignerRectTracker1.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker1.TrackerRectangle"), RectangleF)
        chk_BandsAGC.CenterPtTracker = DesignerRectTracker1
        chk_BandsAGC.CheckButton = True
        chk_BandsAGC.Checked = True
        CBlendItems1.iColor = New Color() {Color.FromArgb(CByte(255), CByte(255), CByte(192)), Color.FromArgb(CByte(220), CByte(220), CByte(192)), Color.FromArgb(CByte(150), CByte(140), CByte(140))}
        CBlendItems1.iPoint = New Single() {0F, 0.8683274F, 1F}
        chk_BandsAGC.ColorFillBlend = CBlendItems1
        CBlendItems2.iColor = New Color() {Color.FromArgb(CByte(255), CByte(170), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0))}
        CBlendItems2.iPoint = New Single() {0F, 0.2491103F, 1F}
        chk_BandsAGC.ColorFillBlendChecked = CBlendItems2
        chk_BandsAGC.ColorFillSolid = SystemColors.Control
        chk_BandsAGC.ColorFillSolidChecked = SystemColors.Control
        chk_BandsAGC.Corners.All = 6S
        chk_BandsAGC.Corners.LowerLeft = 6S
        chk_BandsAGC.Corners.LowerRight = 6S
        chk_BandsAGC.Corners.UpperLeft = 6S
        chk_BandsAGC.Corners.UpperRight = 6S
        chk_BandsAGC.DimFactorOver = 30
        chk_BandsAGC.FillType = MyButton.eFillType.LinearVertical
        chk_BandsAGC.FillTypeChecked = MyButton.eFillType.LinearVertical
        chk_BandsAGC.FocalPoints.CenterPtX = 1F
        chk_BandsAGC.FocalPoints.CenterPtY = 1F
        chk_BandsAGC.FocalPoints.FocusPtX = 0F
        chk_BandsAGC.FocalPoints.FocusPtY = 0F
        chk_BandsAGC.FocalPointsChecked.CenterPtX = 0F
        chk_BandsAGC.FocalPointsChecked.CenterPtY = 0F
        chk_BandsAGC.FocalPointsChecked.FocusPtX = 0F
        chk_BandsAGC.FocalPointsChecked.FocusPtY = 0F
        DesignerRectTracker2.IsActive = False
        DesignerRectTracker2.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker2.TrackerRectangle"), RectangleF)
        chk_BandsAGC.FocusPtTracker = DesignerRectTracker2
        chk_BandsAGC.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chk_BandsAGC.Image = Nothing
        chk_BandsAGC.ImageAlign = ContentAlignment.MiddleCenter
        chk_BandsAGC.ImageIndex = 0
        chk_BandsAGC.ImageSize = New Size(16, 16)
        chk_BandsAGC.Location = New Point(318, 1)
        chk_BandsAGC.Margin = New Padding(4, 3, 4, 3)
        chk_BandsAGC.Name = "chk_BandsAGC"
        chk_BandsAGC.Shape = MyButton.eShape.Rectangle
        chk_BandsAGC.SideImage = Nothing
        chk_BandsAGC.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsAGC.SideImageSize = New Size(32, 32)
        chk_BandsAGC.Size = New Size(47, 18)
        chk_BandsAGC.TabIndex = 60
        chk_BandsAGC.Text = "AGC"
        chk_BandsAGC.TextImageRelation = TextImageRelation.ImageAboveText
        chk_BandsAGC.TextMargin = New Padding(0)
        chk_BandsAGC.TextShadow = Color.Transparent
        ' 
        ' chk_BandsLogY
        ' 
        chk_BandsLogY.BorderColor = Color.DarkGray
        DesignerRectTracker3.IsActive = False
        DesignerRectTracker3.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker3.TrackerRectangle"), RectangleF)
        chk_BandsLogY.CenterPtTracker = DesignerRectTracker3
        chk_BandsLogY.CheckButton = True
        CBlendItems3.iColor = New Color() {Color.FromArgb(CByte(255), CByte(255), CByte(192)), Color.FromArgb(CByte(220), CByte(220), CByte(192)), Color.FromArgb(CByte(150), CByte(140), CByte(140))}
        CBlendItems3.iPoint = New Single() {0F, 0.8683274F, 1F}
        chk_BandsLogY.ColorFillBlend = CBlendItems3
        CBlendItems4.iColor = New Color() {Color.FromArgb(CByte(255), CByte(170), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0))}
        CBlendItems4.iPoint = New Single() {0F, 0.2491103F, 1F}
        chk_BandsLogY.ColorFillBlendChecked = CBlendItems4
        chk_BandsLogY.ColorFillSolid = SystemColors.Control
        chk_BandsLogY.ColorFillSolidChecked = SystemColors.Control
        chk_BandsLogY.Corners.All = 6S
        chk_BandsLogY.Corners.LowerLeft = 6S
        chk_BandsLogY.Corners.LowerRight = 6S
        chk_BandsLogY.Corners.UpperLeft = 6S
        chk_BandsLogY.Corners.UpperRight = 6S
        chk_BandsLogY.DimFactorOver = 30
        chk_BandsLogY.FillType = MyButton.eFillType.LinearVertical
        chk_BandsLogY.FillTypeChecked = MyButton.eFillType.LinearVertical
        chk_BandsLogY.FocalPoints.CenterPtX = 1F
        chk_BandsLogY.FocalPoints.CenterPtY = 1F
        chk_BandsLogY.FocalPoints.FocusPtX = 0F
        chk_BandsLogY.FocalPoints.FocusPtY = 0F
        chk_BandsLogY.FocalPointsChecked.CenterPtX = 0F
        chk_BandsLogY.FocalPointsChecked.CenterPtY = 0F
        chk_BandsLogY.FocalPointsChecked.FocusPtX = 0F
        chk_BandsLogY.FocalPointsChecked.FocusPtY = 0F
        DesignerRectTracker4.IsActive = True
        DesignerRectTracker4.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker4.TrackerRectangle"), RectangleF)
        chk_BandsLogY.FocusPtTracker = DesignerRectTracker4
        chk_BandsLogY.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chk_BandsLogY.Image = Nothing
        chk_BandsLogY.ImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogY.ImageIndex = 0
        chk_BandsLogY.ImageSize = New Size(16, 16)
        chk_BandsLogY.Location = New Point(76, 155)
        chk_BandsLogY.Margin = New Padding(4, 3, 4, 3)
        chk_BandsLogY.Name = "chk_BandsLogY"
        chk_BandsLogY.Shape = MyButton.eShape.Rectangle
        chk_BandsLogY.SideImage = Nothing
        chk_BandsLogY.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogY.SideImageSize = New Size(32, 32)
        chk_BandsLogY.Size = New Size(51, 18)
        chk_BandsLogY.TabIndex = 59
        chk_BandsLogY.Text = "Log Y"
        chk_BandsLogY.TextImageRelation = TextImageRelation.ImageAboveText
        chk_BandsLogY.TextMargin = New Padding(0)
        chk_BandsLogY.TextShadow = Color.Transparent
        ' 
        ' chk_BandsLogX
        ' 
        chk_BandsLogX.BorderColor = Color.DarkGray
        DesignerRectTracker5.IsActive = False
        DesignerRectTracker5.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker5.TrackerRectangle"), RectangleF)
        chk_BandsLogX.CenterPtTracker = DesignerRectTracker5
        chk_BandsLogX.CheckButton = True
        chk_BandsLogX.Checked = True
        CBlendItems5.iColor = New Color() {Color.FromArgb(CByte(255), CByte(255), CByte(192)), Color.FromArgb(CByte(220), CByte(220), CByte(192)), Color.FromArgb(CByte(150), CByte(140), CByte(140))}
        CBlendItems5.iPoint = New Single() {0F, 0.8683274F, 1F}
        chk_BandsLogX.ColorFillBlend = CBlendItems5
        CBlendItems6.iColor = New Color() {Color.FromArgb(CByte(255), CByte(170), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0))}
        CBlendItems6.iPoint = New Single() {0F, 0.2491103F, 1F}
        chk_BandsLogX.ColorFillBlendChecked = CBlendItems6
        chk_BandsLogX.ColorFillSolid = SystemColors.Control
        chk_BandsLogX.ColorFillSolidChecked = SystemColors.Control
        chk_BandsLogX.Corners.All = 6S
        chk_BandsLogX.Corners.LowerLeft = 6S
        chk_BandsLogX.Corners.LowerRight = 6S
        chk_BandsLogX.Corners.UpperLeft = 6S
        chk_BandsLogX.Corners.UpperRight = 6S
        chk_BandsLogX.DimFactorOver = 30
        chk_BandsLogX.FillType = MyButton.eFillType.LinearVertical
        chk_BandsLogX.FillTypeChecked = MyButton.eFillType.LinearVertical
        chk_BandsLogX.FocalPoints.CenterPtX = 1F
        chk_BandsLogX.FocalPoints.CenterPtY = 1F
        chk_BandsLogX.FocalPoints.FocusPtX = 0F
        chk_BandsLogX.FocalPoints.FocusPtY = 0F
        chk_BandsLogX.FocalPointsChecked.CenterPtX = 0F
        chk_BandsLogX.FocalPointsChecked.CenterPtY = 0F
        chk_BandsLogX.FocalPointsChecked.FocusPtX = 0F
        chk_BandsLogX.FocalPointsChecked.FocusPtY = 0F
        DesignerRectTracker6.IsActive = False
        DesignerRectTracker6.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker6.TrackerRectangle"), RectangleF)
        chk_BandsLogX.FocusPtTracker = DesignerRectTracker6
        chk_BandsLogX.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chk_BandsLogX.Image = Nothing
        chk_BandsLogX.ImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogX.ImageIndex = 0
        chk_BandsLogX.ImageSize = New Size(16, 16)
        chk_BandsLogX.Location = New Point(20, 155)
        chk_BandsLogX.Margin = New Padding(4, 3, 4, 3)
        chk_BandsLogX.Name = "chk_BandsLogX"
        chk_BandsLogX.Shape = MyButton.eShape.Rectangle
        chk_BandsLogX.SideImage = Nothing
        chk_BandsLogX.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogX.SideImageSize = New Size(32, 32)
        chk_BandsLogX.Size = New Size(51, 18)
        chk_BandsLogX.TabIndex = 58
        chk_BandsLogX.Text = "Log X"
        chk_BandsLogX.TextImageRelation = TextImageRelation.ImageAboveText
        chk_BandsLogX.TextMargin = New Padding(0)
        chk_BandsLogX.TextShadow = Color.Transparent
        ' 
        ' txt_BandsSpeed
        ' 
        txt_BandsSpeed.ArrowsIncrement = 1R
        txt_BandsSpeed.BackColor = Color.MintCream
        txt_BandsSpeed.BackColor_Over = Color.Moccasin
        txt_BandsSpeed.BorderStyle = BorderStyle.None
        txt_BandsSpeed.DimFactorGray = -65
        txt_BandsSpeed.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsSpeed.ForeColor = Color.Black
        txt_BandsSpeed.Increment = 0.02R
        txt_BandsSpeed.Location = New Point(78, 128)
        txt_BandsSpeed.Margin = New Padding(4, 3, 4, 3)
        txt_BandsSpeed.MaxValue = 100R
        txt_BandsSpeed.MinValue = 1R
        txt_BandsSpeed.Name = "txt_BandsSpeed"
        txt_BandsSpeed.NumericValue = 10R
        txt_BandsSpeed.NumericValueInteger = 10
        txt_BandsSpeed.RectangleColor = Color.PowderBlue
        txt_BandsSpeed.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsSpeed.RoundingStep = 0R
        txt_BandsSpeed.ShadowColor = Color.LightGray
        txt_BandsSpeed.Size = New Size(54, 16)
        txt_BandsSpeed.TabIndex = 55
        txt_BandsSpeed.Text = "10"
        txt_BandsSpeed.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(9, 130)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(63, 15)
        Label5.TabIndex = 44
        Label5.Text = "Speed"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pbox_SpectrumBars
        ' 
        pbox_SpectrumBars.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pbox_SpectrumBars.BorderStyle = BorderStyle.Fixed3D
        pbox_SpectrumBars.Location = New Point(144, 27)
        pbox_SpectrumBars.Margin = New Padding(4, 3, 4, 3)
        pbox_SpectrumBars.Name = "pbox_SpectrumBars"
        pbox_SpectrumBars.Size = New Size(153, 156)
        pbox_SpectrumBars.TabIndex = 0
        pbox_SpectrumBars.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(13, 37)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(63, 15)
        Label10.TabIndex = 34
        Label10.Text = "Max dB"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(175, 3)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(63, 15)
        Label6.TabIndex = 30
        Label6.Text = "Bands"
        Label6.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txt_BandsMaxDb
        ' 
        txt_BandsMaxDb.ArrowsIncrement = 1R
        txt_BandsMaxDb.BackColor = Color.MintCream
        txt_BandsMaxDb.BackColor_Over = Color.Moccasin
        txt_BandsMaxDb.BorderStyle = BorderStyle.None
        txt_BandsMaxDb.DimFactorGray = -65
        txt_BandsMaxDb.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsMaxDb.ForeColor = Color.Black
        txt_BandsMaxDb.Increment = 0.1R
        txt_BandsMaxDb.Location = New Point(78, 35)
        txt_BandsMaxDb.Margin = New Padding(4, 3, 4, 3)
        txt_BandsMaxDb.MaxValue = 0R
        txt_BandsMaxDb.MinValue = -120R
        txt_BandsMaxDb.Name = "txt_BandsMaxDb"
        txt_BandsMaxDb.NumericValue = -20R
        txt_BandsMaxDb.NumericValueInteger = -20
        txt_BandsMaxDb.RectangleColor = Color.PowderBlue
        txt_BandsMaxDb.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMaxDb.RoundingStep = 0R
        txt_BandsMaxDb.ShadowColor = Color.LightGray
        txt_BandsMaxDb.Size = New Size(54, 16)
        txt_BandsMaxDb.TabIndex = 51
        txt_BandsMaxDb.Text = "-20"
        txt_BandsMaxDb.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(13, 83)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(63, 15)
        Label14.TabIndex = 38
        Label14.Text = "Max freq."
        Label14.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' txt_BandsCount
        ' 
        txt_BandsCount.ArrowsIncrement = 1R
        txt_BandsCount.BackColor = Color.MintCream
        txt_BandsCount.BackColor_Over = Color.Moccasin
        txt_BandsCount.BorderStyle = BorderStyle.None
        txt_BandsCount.DimFactorGray = -65
        txt_BandsCount.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsCount.ForeColor = Color.Black
        txt_BandsCount.Increment = 0.1R
        txt_BandsCount.Location = New Point(243, 1)
        txt_BandsCount.Margin = New Padding(4, 3, 4, 3)
        txt_BandsCount.MaxValue = 100R
        txt_BandsCount.MinValue = 1R
        txt_BandsCount.Name = "txt_BandsCount"
        txt_BandsCount.NumericValue = 3R
        txt_BandsCount.NumericValueInteger = 3
        txt_BandsCount.RectangleColor = Color.PowderBlue
        txt_BandsCount.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsCount.RoundingStep = 0R
        txt_BandsCount.ShadowColor = Color.LightGray
        txt_BandsCount.Size = New Size(54, 16)
        txt_BandsCount.TabIndex = 50
        txt_BandsCount.Text = "3"
        txt_BandsCount.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_BandsMaxFreq
        ' 
        txt_BandsMaxFreq.ArrowsIncrement = 1R
        txt_BandsMaxFreq.BackColor = Color.MintCream
        txt_BandsMaxFreq.BackColor_Over = Color.Moccasin
        txt_BandsMaxFreq.BorderStyle = BorderStyle.None
        txt_BandsMaxFreq.DimFactorGray = -65
        txt_BandsMaxFreq.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsMaxFreq.ForeColor = Color.Black
        txt_BandsMaxFreq.Increment = 0.1R
        txt_BandsMaxFreq.Location = New Point(78, 81)
        txt_BandsMaxFreq.Margin = New Padding(4, 3, 4, 3)
        txt_BandsMaxFreq.MaxValue = 22000R
        txt_BandsMaxFreq.MinValue = 1R
        txt_BandsMaxFreq.Name = "txt_BandsMaxFreq"
        txt_BandsMaxFreq.NumericValue = 16000R
        txt_BandsMaxFreq.NumericValueInteger = 16000
        txt_BandsMaxFreq.RectangleColor = Color.PowderBlue
        txt_BandsMaxFreq.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMaxFreq.RoundingStep = 0R
        txt_BandsMaxFreq.ShadowColor = Color.LightGray
        txt_BandsMaxFreq.Size = New Size(54, 16)
        txt_BandsMaxFreq.TabIndex = 53
        txt_BandsMaxFreq.Text = "16000"
        txt_BandsMaxFreq.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_BandsMinDb
        ' 
        txt_BandsMinDb.ArrowsIncrement = 1R
        txt_BandsMinDb.BackColor = Color.MintCream
        txt_BandsMinDb.BackColor_Over = Color.Moccasin
        txt_BandsMinDb.BorderStyle = BorderStyle.None
        txt_BandsMinDb.DimFactorGray = -65
        txt_BandsMinDb.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsMinDb.ForeColor = Color.Black
        txt_BandsMinDb.Increment = 0.1R
        txt_BandsMinDb.Location = New Point(78, 58)
        txt_BandsMinDb.Margin = New Padding(4, 3, 4, 3)
        txt_BandsMinDb.MaxValue = 0R
        txt_BandsMinDb.MinValue = -120R
        txt_BandsMinDb.Name = "txt_BandsMinDb"
        txt_BandsMinDb.NumericValue = -40R
        txt_BandsMinDb.NumericValueInteger = -40
        txt_BandsMinDb.RectangleColor = Color.PowderBlue
        txt_BandsMinDb.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMinDb.RoundingStep = 0R
        txt_BandsMinDb.ShadowColor = Color.LightGray
        txt_BandsMinDb.Size = New Size(54, 16)
        txt_BandsMinDb.TabIndex = 52
        txt_BandsMinDb.Text = "-40"
        txt_BandsMinDb.TextAlign = HorizontalAlignment.Center
        ' 
        ' txt_BandsMinFreq
        ' 
        txt_BandsMinFreq.ArrowsIncrement = 1R
        txt_BandsMinFreq.BackColor = Color.MintCream
        txt_BandsMinFreq.BackColor_Over = Color.Moccasin
        txt_BandsMinFreq.BorderStyle = BorderStyle.None
        txt_BandsMinFreq.DimFactorGray = -65
        txt_BandsMinFreq.Font = New Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_BandsMinFreq.ForeColor = Color.Black
        txt_BandsMinFreq.Increment = 0.1R
        txt_BandsMinFreq.Location = New Point(78, 104)
        txt_BandsMinFreq.Margin = New Padding(4, 3, 4, 3)
        txt_BandsMinFreq.MaxValue = 22000R
        txt_BandsMinFreq.MinValue = 1R
        txt_BandsMinFreq.Name = "txt_BandsMinFreq"
        txt_BandsMinFreq.NumericValue = 80R
        txt_BandsMinFreq.NumericValueInteger = 80
        txt_BandsMinFreq.RectangleColor = Color.PowderBlue
        txt_BandsMinFreq.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMinFreq.RoundingStep = 0R
        txt_BandsMinFreq.ShadowColor = Color.LightGray
        txt_BandsMinFreq.Size = New Size(54, 16)
        txt_BandsMinFreq.TabIndex = 54
        txt_BandsMinFreq.Text = "80"
        txt_BandsMinFreq.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(13, 106)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(63, 15)
        Label12.TabIndex = 40
        Label12.Text = "Min freq."
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(13, 59)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(63, 15)
        Label13.TabIndex = 36
        Label13.Text = "Min dB"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btn_AudioInputs
        ' 
        btn_AudioInputs.BackColor = Color.WhiteSmoke
        btn_AudioInputs.BorderColor = Color.DarkGray
        DesignerRectTracker7.IsActive = False
        DesignerRectTracker7.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker7.TrackerRectangle"), RectangleF)
        btn_AudioInputs.CenterPtTracker = DesignerRectTracker7
        CBlendItems7.iColor = New Color() {Color.FromArgb(CByte(255), CByte(255), CByte(192)), Color.FromArgb(CByte(220), CByte(220), CByte(192)), Color.FromArgb(CByte(150), CByte(140), CByte(140))}
        CBlendItems7.iPoint = New Single() {0F, 0.8683274F, 1F}
        btn_AudioInputs.ColorFillBlend = CBlendItems7
        CBlendItems8.iColor = New Color() {Color.FromArgb(CByte(255), CByte(170), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0)), Color.FromArgb(CByte(255), CByte(255), CByte(0))}
        CBlendItems8.iPoint = New Single() {0F, 0.2491103F, 1F}
        btn_AudioInputs.ColorFillBlendChecked = CBlendItems8
        btn_AudioInputs.ColorFillSolid = SystemColors.Control
        btn_AudioInputs.ColorFillSolidChecked = SystemColors.Control
        btn_AudioInputs.Corners.All = 6S
        btn_AudioInputs.Corners.LowerLeft = 6S
        btn_AudioInputs.Corners.LowerRight = 6S
        btn_AudioInputs.Corners.UpperLeft = 6S
        btn_AudioInputs.Corners.UpperRight = 6S
        btn_AudioInputs.DimFactorOver = 30
        btn_AudioInputs.FillType = MyButton.eFillType.LinearVertical
        btn_AudioInputs.FillTypeChecked = MyButton.eFillType.LinearVertical
        btn_AudioInputs.FocalPoints.CenterPtX = 1F
        btn_AudioInputs.FocalPoints.CenterPtY = 1F
        btn_AudioInputs.FocalPoints.FocusPtX = 0F
        btn_AudioInputs.FocalPoints.FocusPtY = 0F
        btn_AudioInputs.FocalPointsChecked.CenterPtX = 0F
        btn_AudioInputs.FocalPointsChecked.CenterPtY = 0F
        btn_AudioInputs.FocalPointsChecked.FocusPtX = 0F
        btn_AudioInputs.FocalPointsChecked.FocusPtY = 0F
        DesignerRectTracker8.IsActive = False
        DesignerRectTracker8.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker8.TrackerRectangle"), RectangleF)
        btn_AudioInputs.FocusPtTracker = DesignerRectTracker8
        btn_AudioInputs.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btn_AudioInputs.Image = Nothing
        btn_AudioInputs.ImageAlign = ContentAlignment.MiddleCenter
        btn_AudioInputs.ImageIndex = 0
        btn_AudioInputs.ImageSize = New Size(16, 16)
        btn_AudioInputs.Location = New Point(257, 12)
        btn_AudioInputs.Margin = New Padding(4, 3, 4, 3)
        btn_AudioInputs.Name = "btn_AudioInputs"
        btn_AudioInputs.Shape = MyButton.eShape.Rectangle
        btn_AudioInputs.SideImage = Nothing
        btn_AudioInputs.SideImageAlign = ContentAlignment.MiddleCenter
        btn_AudioInputs.SideImageSize = New Size(32, 32)
        btn_AudioInputs.Size = New Size(92, 21)
        btn_AudioInputs.TabIndex = 233
        btn_AudioInputs.Text = "Audio inputs"
        btn_AudioInputs.TextImageRelation = TextImageRelation.ImageAboveText
        btn_AudioInputs.TextMargin = New Padding(0)
        btn_AudioInputs.TextShadow = Color.Transparent
        ' 
        ' cmb_AudioInDevices
        ' 
        cmb_AudioInDevices.ArrowButtonColor = Color.Transparent
        cmb_AudioInDevices.ArrowColor = Color.DarkGray
        cmb_AudioInDevices.BackColor = Color.FloralWhite
        cmb_AudioInDevices.BackColor_Focused = Color.FloralWhite
        cmb_AudioInDevices.BackColor_Over = Color.Moccasin
        cmb_AudioInDevices.BorderColor = Color.DarkGray
        cmb_AudioInDevices.BorderSize = 1
        cmb_AudioInDevices.DrawMode = DrawMode.OwnerDrawFixed
        cmb_AudioInDevices.DropDown_BackColor = Color.Cornsilk
        cmb_AudioInDevices.DropDown_BackSelected = Color.Moccasin
        cmb_AudioInDevices.DropDown_BorderColor = Color.Cornsilk
        cmb_AudioInDevices.DropDown_ForeColor = SystemColors.WindowText
        cmb_AudioInDevices.DropDown_ForeSelected = SystemColors.WindowText
        cmb_AudioInDevices.DropDownHeight = 500
        cmb_AudioInDevices.DropDownStyle = ComboBoxStyle.DropDownList
        cmb_AudioInDevices.DropDownWidth = 180
        cmb_AudioInDevices.FlatStyle = FlatStyle.Flat
        cmb_AudioInDevices.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cmb_AudioInDevices.ForeColor = Color.Black
        cmb_AudioInDevices.IntegralHeight = False
        cmb_AudioInDevices.ItemHeight = 11
        cmb_AudioInDevices.Items.AddRange(New Object() {"Auto"})
        cmb_AudioInDevices.Location = New Point(72, 13)
        cmb_AudioInDevices.Margin = New Padding(4, 3, 4, 3)
        cmb_AudioInDevices.Name = "cmb_AudioInDevices"
        cmb_AudioInDevices.ShadowColor = Color.LightGray
        cmb_AudioInDevices.Size = New Size(164, 17)
        cmb_AudioInDevices.TabIndex = 234
        cmb_AudioInDevices.TextPosition = 1
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightGoldenrodYellow
        GroupBox4.Controls.Add(cmb_AudioInDevices)
        GroupBox4.Controls.Add(btn_AudioInputs)
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.Navy
        GroupBox4.Location = New Point(8, 7)
        GroupBox4.Margin = New Padding(4, 3, 4, 3)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 3, 4, 3)
        GroupBox4.Size = New Size(360, 39)
        GroupBox4.TabIndex = 235
        GroupBox4.TabStop = False
        GroupBox4.Text = "Input"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(756, 204)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox_Bands)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        Opacity = 0R
        StartPosition = FormStartPosition.Manual
        Text = "Theremino AudioInput"
        CType(tk_TriggerLevel, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(tk_DeadTime, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(pBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox_Bands.ResumeLayout(False)
        GroupBox_Bands.PerformLayout()
        CType(pbox_SpectrumBars, ComponentModel.ISupportInitialize).EndInit()
        GroupBox4.ResumeLayout(False)
        ResumeLayout(False)

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
    Friend WithEvents chkEnableServer As CheckBox
End Class
