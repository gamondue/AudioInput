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
        Dim DesignerRectTracker9 As DesignerRectTracker = New DesignerRectTracker()
        Dim CBlendItems9 As cBlendItems = New cBlendItems()
        Dim CBlendItems10 As cBlendItems = New cBlendItems()
        Dim DesignerRectTracker10 As DesignerRectTracker = New DesignerRectTracker()
        Timer1 = New Timer(components)
        tk_TriggerLevel = New TrackBar()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        lbl_TrigLevel = New Label()
        lbl_DeadTime = New Label()
        Label3 = New Label()
        tk_DeadTime = New TrackBar()
        GroupBox1 = New GroupBox()
        Label4 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txt_SlotSpectrum = New MyTextBox()
        txt_SlotCounter = New MyTextBox()
        txt_SlotMeter = New MyTextBox()
        GroupBox3 = New GroupBox()
        pBox1 = New PictureBox()
        GroupBox_Bands = New GroupBox()
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
        btnToggle = New Button()
        lblSyncStatus = New Label()
        chkEnableServer = New CheckBox()
        btn_AudioInputs = New MyButton()
        GroupBox4 = New GroupBox()
        cmb_AudioInDevices = New MyComboBox()
        lblConnectionStatus = New Label()
        btnSyncNTP = New Button()
        lstClients = New ListBox()
        btnGetTemplate = New Button()
        btnSaveTemplate = New Button()
        txtCount = New MyTextBox()
        btnEngageSystem = New MyButton()
        btnGetStroke = New Button()
        txtCorrelation = New MyTextBox()
        txtDelay = New MyTextBox()
        txtCorrelationForDelay = New MyTextBox()
        Label2 = New Label()
        Label9 = New Label()
        lblCorrelation = New Label()
        Label11 = New Label()
        Label15 = New Label()
        btnSaveWave = New Button()
        chkTimeSync = New CheckBox()
        btnConnect = New Button()
        Label16 = New Label()
        txtIpServer = New MyTextBox()
        Label17 = New Label()
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
        tk_TriggerLevel.Location = New Point(39, 23)
        tk_TriggerLevel.Margin = New Padding(6, 5, 6, 5)
        tk_TriggerLevel.Maximum = 999
        tk_TriggerLevel.Minimum = 1
        tk_TriggerLevel.Name = "tk_TriggerLevel"
        tk_TriggerLevel.Orientation = Orientation.Vertical
        tk_TriggerLevel.Size = New Size(71, 172)
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
        Label1.Location = New Point(19, 212)
        Label1.Margin = New Padding(6, 0, 6, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 21)
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
        GroupBox2.Location = New Point(169, 85)
        GroupBox2.Margin = New Padding(6, 5, 6, 5)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(6, 5, 6, 5)
        GroupBox2.Size = New Size(240, 250)
        GroupBox2.TabIndex = 149
        GroupBox2.TabStop = False
        GroupBox2.Text = "Counter"
        ' 
        ' lbl_TrigLevel
        ' 
        lbl_TrigLevel.AutoSize = True
        lbl_TrigLevel.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_TrigLevel.ForeColor = Color.Black
        lbl_TrigLevel.Location = New Point(43, 183)
        lbl_TrigLevel.Margin = New Padding(6, 0, 6, 0)
        lbl_TrigLevel.Name = "lbl_TrigLevel"
        lbl_TrigLevel.Size = New Size(55, 21)
        lbl_TrigLevel.TabIndex = 21
        lbl_TrigLevel.Text = "100uS"
        ' 
        ' lbl_DeadTime
        ' 
        lbl_DeadTime.AutoSize = True
        lbl_DeadTime.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl_DeadTime.ForeColor = Color.Black
        lbl_DeadTime.Location = New Point(143, 183)
        lbl_DeadTime.Margin = New Padding(6, 0, 6, 0)
        lbl_DeadTime.Name = "lbl_DeadTime"
        lbl_DeadTime.Size = New Size(55, 21)
        lbl_DeadTime.TabIndex = 20
        lbl_DeadTime.Text = "100uS"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(133, 212)
        Label3.Margin = New Padding(6, 0, 6, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 21)
        Label3.TabIndex = 19
        Label3.Text = "Dead time"
        ' 
        ' tk_DeadTime
        ' 
        tk_DeadTime.AutoSize = False
        tk_DeadTime.Location = New Point(140, 23)
        tk_DeadTime.Margin = New Padding(6, 5, 6, 5)
        tk_DeadTime.Maximum = 100
        tk_DeadTime.Name = "tk_DeadTime"
        tk_DeadTime.Orientation = Orientation.Vertical
        tk_DeadTime.Size = New Size(69, 172)
        tk_DeadTime.TabIndex = 18
        tk_DeadTime.TickFrequency = 10
        tk_DeadTime.TickStyle = TickStyle.Both
        tk_DeadTime.Value = 7
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.LightGoldenrodYellow
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = Color.Navy
        GroupBox1.Location = New Point(9, 85)
        GroupBox1.Margin = New Padding(6, 5, 6, 5)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(6, 5, 6, 5)
        GroupBox1.Size = New Size(153, 250)
        GroupBox1.TabIndex = 150
        GroupBox1.TabStop = False
        GroupBox1.Text = "Outputs"
        ' 
        ' Label4
        ' 
        Label4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(11, 163)
        Label4.Margin = New Padding(6, 0, 6, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 35)
        Label4.TabIndex = 131
        Label4.Text = "Spec. first slot"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Black
        Label8.Location = New Point(21, 35)
        Label8.Margin = New Padding(6, 0, 6, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(100, 21)
        Label8.TabIndex = 130
        Label8.Text = "Counter slot"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Black
        Label7.Location = New Point(30, 98)
        Label7.Margin = New Padding(6, 0, 6, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 21)
        Label7.TabIndex = 128
        Label7.Text = "Meter slot"
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
        txt_SlotSpectrum.Location = New Point(27, 104)
        txt_SlotSpectrum.MaxValue = 999R
        txt_SlotSpectrum.MinValue = -1R
        txt_SlotSpectrum.Name = "txt_SlotSpectrum"
        txt_SlotSpectrum.NumericValue = 0R
        txt_SlotSpectrum.RectangleColor = Color.PowderBlue
        txt_SlotSpectrum.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotSpectrum.RoundingStep = 0R
        txt_SlotSpectrum.ShadowColor = Color.LightGray
        txt_SlotSpectrum.Size = New Size(42, 24)
        txt_SlotSpectrum.TabIndex = 132
        txt_SlotSpectrum.Text = "0"
        txt_SlotSpectrum.TextAlign = HorizontalAlignment.Center
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
        txt_SlotCounter.Location = New Point(25, 31)
        txt_SlotCounter.MaxValue = 999R
        txt_SlotCounter.MinValue = -1R
        txt_SlotCounter.Name = "txt_SlotCounter"
        txt_SlotCounter.NumericValue = -1R
        txt_SlotCounter.NumericValueInteger = -1
        txt_SlotCounter.RectangleColor = Color.PowderBlue
        txt_SlotCounter.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotCounter.RoundingStep = 0R
        txt_SlotCounter.ShadowColor = Color.LightGray
        txt_SlotCounter.Size = New Size(42, 24)
        txt_SlotCounter.TabIndex = 129
        txt_SlotCounter.Text = "-1"
        txt_SlotCounter.TextAlign = HorizontalAlignment.Center
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
        txt_SlotMeter.Location = New Point(25, 67)
        txt_SlotMeter.MaxValue = 999R
        txt_SlotMeter.MinValue = -1R
        txt_SlotMeter.Name = "txt_SlotMeter"
        txt_SlotMeter.NumericValue = -1R
        txt_SlotMeter.NumericValueInteger = -1
        txt_SlotMeter.RectangleColor = Color.PowderBlue
        txt_SlotMeter.RectangleStyle = ButtonBorderStyle.Dashed
        txt_SlotMeter.RoundingStep = 0R
        txt_SlotMeter.ShadowColor = Color.LightGray
        txt_SlotMeter.Size = New Size(42, 24)
        txt_SlotMeter.TabIndex = 127
        txt_SlotMeter.Text = "-1"
        txt_SlotMeter.TextAlign = HorizontalAlignment.Center
        ' 
        ' GroupBox3
        ' 
        GroupBox3.BackColor = Color.LightGoldenrodYellow
        GroupBox3.Controls.Add(pBox1)
        GroupBox3.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox3.ForeColor = Color.Navy
        GroupBox3.Location = New Point(414, 85)
        GroupBox3.Margin = New Padding(6, 5, 6, 5)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(6, 5, 6, 5)
        GroupBox3.Size = New Size(97, 250)
        GroupBox3.TabIndex = 151
        GroupBox3.TabStop = False
        GroupBox3.Text = "Meter"
        ' 
        ' pBox1
        ' 
        pBox1.BorderStyle = BorderStyle.Fixed3D
        pBox1.Location = New Point(30, 35)
        pBox1.Margin = New Padding(6, 5, 6, 5)
        pBox1.Name = "pBox1"
        pBox1.Size = New Size(30, 189)
        pBox1.TabIndex = 18
        pBox1.TabStop = False
        ' 
        ' GroupBox_Bands
        ' 
        GroupBox_Bands.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        GroupBox_Bands.BackColor = Color.LightGoldenrodYellow
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
        GroupBox_Bands.Location = New Point(521, 10)
        GroupBox_Bands.Margin = New Padding(4, 5, 4, 5)
        GroupBox_Bands.MinimumSize = New Size(443, 242)
        GroupBox_Bands.Name = "GroupBox_Bands"
        GroupBox_Bands.Padding = New Padding(4, 5, 4, 5)
        GroupBox_Bands.Size = New Size(851, 325)
        GroupBox_Bands.TabIndex = 152
        GroupBox_Bands.TabStop = False
        GroupBox_Bands.Text = "FHT Spectrum bands"
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
        chk_BandsAGC.Location = New Point(441, 17)
        chk_BandsAGC.Margin = New Padding(4, 5, 4, 5)
        chk_BandsAGC.Name = "chk_BandsAGC"
        chk_BandsAGC.Shape = MyButton.eShape.Rectangle
        chk_BandsAGC.SideImage = Nothing
        chk_BandsAGC.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsAGC.SideImageSize = New Size(32, 32)
        chk_BandsAGC.Size = New Size(57, 27)
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
        chk_BandsLogY.Location = New Point(87, 282)
        chk_BandsLogY.Margin = New Padding(4, 5, 4, 5)
        chk_BandsLogY.Name = "chk_BandsLogY"
        chk_BandsLogY.Shape = MyButton.eShape.Rectangle
        chk_BandsLogY.SideImage = Nothing
        chk_BandsLogY.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogY.SideImageSize = New Size(32, 32)
        chk_BandsLogY.Size = New Size(63, 27)
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
        chk_BandsLogX.Location = New Point(19, 282)
        chk_BandsLogX.Margin = New Padding(4, 5, 4, 5)
        chk_BandsLogX.Name = "chk_BandsLogX"
        chk_BandsLogX.Shape = MyButton.eShape.Rectangle
        chk_BandsLogX.SideImage = Nothing
        chk_BandsLogX.SideImageAlign = ContentAlignment.MiddleCenter
        chk_BandsLogX.SideImageSize = New Size(32, 32)
        chk_BandsLogX.Size = New Size(63, 27)
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
        txt_BandsSpeed.Location = New Point(119, 212)
        txt_BandsSpeed.Margin = New Padding(4, 5, 4, 5)
        txt_BandsSpeed.MaxValue = 100R
        txt_BandsSpeed.MinValue = 1R
        txt_BandsSpeed.Name = "txt_BandsSpeed"
        txt_BandsSpeed.NumericValue = 10R
        txt_BandsSpeed.NumericValueInteger = 10
        txt_BandsSpeed.RectangleColor = Color.PowderBlue
        txt_BandsSpeed.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsSpeed.RoundingStep = 0R
        txt_BandsSpeed.ShadowColor = Color.LightGray
        txt_BandsSpeed.Size = New Size(66, 24)
        txt_BandsSpeed.TabIndex = 55
        txt_BandsSpeed.Text = "10"
        txt_BandsSpeed.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(13, 217)
        Label5.Margin = New Padding(6, 0, 6, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 25)
        Label5.TabIndex = 44
        Label5.Text = "Speed"
        Label5.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' pbox_SpectrumBars
        ' 
        pbox_SpectrumBars.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        pbox_SpectrumBars.BorderStyle = BorderStyle.Fixed3D
        pbox_SpectrumBars.Location = New Point(224, 62)
        pbox_SpectrumBars.Margin = New Padding(6, 5, 6, 5)
        pbox_SpectrumBars.Name = "pbox_SpectrumBars"
        pbox_SpectrumBars.Size = New Size(625, 177)
        pbox_SpectrumBars.TabIndex = 0
        pbox_SpectrumBars.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Black
        Label10.Location = New Point(19, 62)
        Label10.Margin = New Padding(6, 0, 6, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(90, 25)
        Label10.TabIndex = 34
        Label10.Text = "Max dB"
        Label10.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(224, 15)
        Label6.Margin = New Padding(6, 0, 6, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 25)
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
        txt_BandsMaxDb.Location = New Point(119, 65)
        txt_BandsMaxDb.Margin = New Padding(4, 5, 4, 5)
        txt_BandsMaxDb.MaxValue = 0R
        txt_BandsMaxDb.MinValue = -120R
        txt_BandsMaxDb.Name = "txt_BandsMaxDb"
        txt_BandsMaxDb.NumericValue = -20R
        txt_BandsMaxDb.NumericValueInteger = -20
        txt_BandsMaxDb.RectangleColor = Color.PowderBlue
        txt_BandsMaxDb.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMaxDb.RoundingStep = 0R
        txt_BandsMaxDb.ShadowColor = Color.LightGray
        txt_BandsMaxDb.Size = New Size(66, 24)
        txt_BandsMaxDb.TabIndex = 51
        txt_BandsMaxDb.Text = "-20"
        txt_BandsMaxDb.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label14
        ' 
        Label14.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label14.ForeColor = Color.Black
        Label14.Location = New Point(19, 138)
        Label14.Margin = New Padding(6, 0, 6, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(90, 25)
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
        txt_BandsCount.Location = New Point(324, 15)
        txt_BandsCount.Margin = New Padding(4, 5, 4, 5)
        txt_BandsCount.MaxValue = 100R
        txt_BandsCount.MinValue = 1R
        txt_BandsCount.Name = "txt_BandsCount"
        txt_BandsCount.NumericValue = 3R
        txt_BandsCount.NumericValueInteger = 3
        txt_BandsCount.RectangleColor = Color.PowderBlue
        txt_BandsCount.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsCount.RoundingStep = 0R
        txt_BandsCount.ShadowColor = Color.LightGray
        txt_BandsCount.Size = New Size(66, 24)
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
        txt_BandsMaxFreq.Location = New Point(119, 138)
        txt_BandsMaxFreq.Margin = New Padding(4, 5, 4, 5)
        txt_BandsMaxFreq.MaxValue = 22000R
        txt_BandsMaxFreq.MinValue = 1R
        txt_BandsMaxFreq.Name = "txt_BandsMaxFreq"
        txt_BandsMaxFreq.NumericValue = 16000R
        txt_BandsMaxFreq.NumericValueInteger = 16000
        txt_BandsMaxFreq.RectangleColor = Color.PowderBlue
        txt_BandsMaxFreq.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMaxFreq.RoundingStep = 0R
        txt_BandsMaxFreq.ShadowColor = Color.LightGray
        txt_BandsMaxFreq.Size = New Size(66, 24)
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
        txt_BandsMinDb.Location = New Point(119, 102)
        txt_BandsMinDb.Margin = New Padding(4, 5, 4, 5)
        txt_BandsMinDb.MaxValue = 0R
        txt_BandsMinDb.MinValue = -120R
        txt_BandsMinDb.Name = "txt_BandsMinDb"
        txt_BandsMinDb.NumericValue = -40R
        txt_BandsMinDb.NumericValueInteger = -40
        txt_BandsMinDb.RectangleColor = Color.PowderBlue
        txt_BandsMinDb.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMinDb.RoundingStep = 0R
        txt_BandsMinDb.ShadowColor = Color.LightGray
        txt_BandsMinDb.Size = New Size(66, 24)
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
        txt_BandsMinFreq.Location = New Point(119, 175)
        txt_BandsMinFreq.Margin = New Padding(4, 5, 4, 5)
        txt_BandsMinFreq.MaxValue = 22000R
        txt_BandsMinFreq.MinValue = 1R
        txt_BandsMinFreq.Name = "txt_BandsMinFreq"
        txt_BandsMinFreq.NumericValue = 80R
        txt_BandsMinFreq.NumericValueInteger = 80
        txt_BandsMinFreq.RectangleColor = Color.PowderBlue
        txt_BandsMinFreq.RectangleStyle = ButtonBorderStyle.Dashed
        txt_BandsMinFreq.RoundingStep = 0R
        txt_BandsMinFreq.ShadowColor = Color.LightGray
        txt_BandsMinFreq.Size = New Size(66, 24)
        txt_BandsMinFreq.TabIndex = 54
        txt_BandsMinFreq.Text = "80"
        txt_BandsMinFreq.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label12
        ' 
        Label12.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.Black
        Label12.Location = New Point(19, 177)
        Label12.Margin = New Padding(6, 0, 6, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(90, 25)
        Label12.TabIndex = 40
        Label12.Text = "Min freq."
        Label12.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Label13
        ' 
        Label13.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.Black
        Label13.Location = New Point(19, 98)
        Label13.Margin = New Padding(6, 0, 6, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(90, 25)
        Label13.TabIndex = 36
        Label13.Text = "Min dB"
        Label13.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' btnToggle
        ' 
        btnToggle.Location = New Point(553, 458)
        btnToggle.Margin = New Padding(4, 5, 4, 5)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(107, 39)
        btnToggle.TabIndex = 238
        btnToggle.Text = "Toggle"
        btnToggle.UseVisualStyleBackColor = True
        ' 
        ' lblSyncStatus
        ' 
        lblSyncStatus.AutoSize = True
        lblSyncStatus.Location = New Point(396, 502)
        lblSyncStatus.Margin = New Padding(4, 0, 4, 0)
        lblSyncStatus.Name = "lblSyncStatus"
        lblSyncStatus.Size = New Size(102, 25)
        lblSyncStatus.TabIndex = 237
        lblSyncStatus.Text = "Not synced"
        ' 
        ' chkEnableServer
        ' 
        chkEnableServer.AutoSize = True
        chkEnableServer.Location = New Point(563, 378)
        chkEnableServer.Margin = New Padding(4, 5, 4, 5)
        chkEnableServer.Name = "chkEnableServer"
        chkEnableServer.Size = New Size(87, 29)
        chkEnableServer.TabIndex = 236
        chkEnableServer.Text = "Server"
        chkEnableServer.UseVisualStyleBackColor = True
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
        btn_AudioInputs.Location = New Point(314, 17)
        btn_AudioInputs.Margin = New Padding(4, 5, 4, 5)
        btn_AudioInputs.Name = "btn_AudioInputs"
        btn_AudioInputs.Shape = MyButton.eShape.Rectangle
        btn_AudioInputs.SideImage = Nothing
        btn_AudioInputs.SideImageAlign = ContentAlignment.MiddleCenter
        btn_AudioInputs.SideImageSize = New Size(32, 32)
        btn_AudioInputs.Size = New Size(113, 30)
        btn_AudioInputs.TabIndex = 233
        btn_AudioInputs.Text = "Audio inputs"
        btn_AudioInputs.TextImageRelation = TextImageRelation.ImageAboveText
        btn_AudioInputs.TextMargin = New Padding(0)
        btn_AudioInputs.TextShadow = Color.Transparent
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightGoldenrodYellow
        GroupBox4.Controls.Add(cmb_AudioInDevices)
        GroupBox4.Controls.Add(btn_AudioInputs)
        GroupBox4.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox4.ForeColor = Color.Navy
        GroupBox4.Location = New Point(10, 10)
        GroupBox4.Margin = New Padding(4, 5, 4, 5)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(4, 5, 4, 5)
        GroupBox4.Size = New Size(441, 65)
        GroupBox4.TabIndex = 235
        GroupBox4.TabStop = False
        GroupBox4.Text = "Input"
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
        cmb_AudioInDevices.Location = New Point(80, 27)
        cmb_AudioInDevices.Margin = New Padding(4, 5, 4, 5)
        cmb_AudioInDevices.Name = "cmb_AudioInDevices"
        cmb_AudioInDevices.ShadowColor = Color.LightGray
        cmb_AudioInDevices.Size = New Size(200, 17)
        cmb_AudioInDevices.TabIndex = 234
        cmb_AudioInDevices.TextPosition = 1
        ' 
        ' lblConnectionStatus
        ' 
        lblConnectionStatus.AutoSize = True
        lblConnectionStatus.Location = New Point(573, 517)
        lblConnectionStatus.Margin = New Padding(4, 0, 4, 0)
        lblConnectionStatus.Name = "lblConnectionStatus"
        lblConnectionStatus.Size = New Size(66, 25)
        lblConnectionStatus.TabIndex = 239
        lblConnectionStatus.Text = "Closed"
        ' 
        ' btnSyncNTP
        ' 
        btnSyncNTP.Location = New Point(394, 421)
        btnSyncNTP.Margin = New Padding(4, 5, 4, 5)
        btnSyncNTP.Name = "btnSyncNTP"
        btnSyncNTP.Size = New Size(107, 76)
        btnSyncNTP.TabIndex = 240
        btnSyncNTP.Text = "Sync Clocks"
        btnSyncNTP.UseVisualStyleBackColor = True
        ' 
        ' lstClients
        ' 
        lstClients.FormattingEnabled = True
        lstClients.ItemHeight = 25
        lstClients.Location = New Point(772, 378)
        lstClients.Margin = New Padding(4, 5, 4, 5)
        lstClients.Name = "lstClients"
        lstClients.Size = New Size(415, 154)
        lstClients.TabIndex = 241
        ' 
        ' btnGetTemplate
        ' 
        btnGetTemplate.Location = New Point(233, 393)
        btnGetTemplate.Margin = New Padding(4, 5, 4, 5)
        btnGetTemplate.Name = "btnGetTemplate"
        btnGetTemplate.Size = New Size(107, 67)
        btnGetTemplate.TabIndex = 242
        btnGetTemplate.Text = "Get Template"
        btnGetTemplate.UseVisualStyleBackColor = True
        ' 
        ' btnSaveTemplate
        ' 
        btnSaveTemplate.Location = New Point(233, 475)
        btnSaveTemplate.Margin = New Padding(4, 5, 4, 5)
        btnSaveTemplate.Name = "btnSaveTemplate"
        btnSaveTemplate.Size = New Size(107, 67)
        btnSaveTemplate.TabIndex = 243
        btnSaveTemplate.Text = "Save Template"
        btnSaveTemplate.UseVisualStyleBackColor = True
        ' 
        ' txtCount
        ' 
        txtCount.ArrowsIncrement = 0R
        txtCount.BackColor_Over = SystemColors.Window
        txtCount.Increment = 0R
        txtCount.Location = New Point(58, 397)
        txtCount.MaxValue = 100R
        txtCount.MinValue = 0R
        txtCount.Name = "txtCount"
        txtCount.NumericValue = 0R
        txtCount.RectangleColor = Color.Transparent
        txtCount.RectangleStyle = ButtonBorderStyle.None
        txtCount.RoundingStep = 0R
        txtCount.ShadowColor = Color.Transparent
        txtCount.Size = New Size(150, 31)
        txtCount.TabIndex = 244
        txtCount.Text = "0"
        ' 
        ' btnEngageSystem
        ' 
        btnEngageSystem.BackColor = Color.WhiteSmoke
        btnEngageSystem.BorderColor = Color.DarkGray
        DesignerRectTracker9.IsActive = False
        DesignerRectTracker9.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker9.TrackerRectangle"), RectangleF)
        btnEngageSystem.CenterPtTracker = DesignerRectTracker9
        CBlendItems9.iColor = New Color() {Color.AliceBlue, Color.RoyalBlue, Color.Navy}
        CBlendItems9.iPoint = New Single() {0F, 0.5F, 1F}
        btnEngageSystem.ColorFillBlend = CBlendItems9
        CBlendItems10.iColor = New Color() {Color.Red, Color.Orange, Color.Orange}
        CBlendItems10.iPoint = New Single() {0F, 0.5F, 1F}
        btnEngageSystem.ColorFillBlendChecked = CBlendItems10
        btnEngageSystem.ColorFillSolid = SystemColors.Control
        btnEngageSystem.ColorFillSolidChecked = SystemColors.Control
        btnEngageSystem.Corners.All = 6S
        btnEngageSystem.Corners.LowerLeft = 6S
        btnEngageSystem.Corners.LowerRight = 6S
        btnEngageSystem.Corners.UpperLeft = 6S
        btnEngageSystem.Corners.UpperRight = 6S
        btnEngageSystem.FillType = MyButton.eFillType.LinearVertical
        btnEngageSystem.FillTypeChecked = MyButton.eFillType.LinearHorizontal
        btnEngageSystem.FocalPoints.CenterPtX = 0.5F
        btnEngageSystem.FocalPoints.CenterPtY = 0.5F
        btnEngageSystem.FocalPoints.FocusPtX = 0F
        btnEngageSystem.FocalPoints.FocusPtY = 0F
        btnEngageSystem.FocalPointsChecked.CenterPtX = 0.5F
        btnEngageSystem.FocalPointsChecked.CenterPtY = 0.5F
        btnEngageSystem.FocalPointsChecked.FocusPtX = 0F
        btnEngageSystem.FocalPointsChecked.FocusPtY = 0F
        DesignerRectTracker10.IsActive = False
        DesignerRectTracker10.TrackerRectangle = CType(resources.GetObject("DesignerRectTracker10.TrackerRectangle"), RectangleF)
        btnEngageSystem.FocusPtTracker = DesignerRectTracker10
        btnEngageSystem.ForeColor = Color.Navy
        btnEngageSystem.Image = Nothing
        btnEngageSystem.ImageAlign = ContentAlignment.MiddleCenter
        btnEngageSystem.ImageIndex = 0
        btnEngageSystem.ImageSize = New Size(16, 16)
        btnEngageSystem.Location = New Point(75, 447)
        btnEngageSystem.Name = "btnEngageSystem"
        btnEngageSystem.Shape = MyButton.eShape.Rectangle
        btnEngageSystem.SideImage = Nothing
        btnEngageSystem.SideImageSize = New Size(48, 48)
        btnEngageSystem.Size = New Size(112, 95)
        btnEngageSystem.TabIndex = 245
        btnEngageSystem.Text = "Engage System"
        btnEngageSystem.TextImageRelation = TextImageRelation.Overlay
        btnEngageSystem.TextMargin = New Padding(0)
        btnEngageSystem.TextShadow = Color.Transparent
        ' 
        ' btnGetStroke
        ' 
        btnGetStroke.Location = New Point(233, 563)
        btnGetStroke.Margin = New Padding(4, 5, 4, 5)
        btnGetStroke.Name = "btnGetStroke"
        btnGetStroke.Size = New Size(107, 67)
        btnGetStroke.TabIndex = 246
        btnGetStroke.Text = "Locate Strokes"
        btnGetStroke.UseVisualStyleBackColor = True
        ' 
        ' txtCorrelation
        ' 
        txtCorrelation.ArrowsIncrement = 0R
        txtCorrelation.BackColor_Over = SystemColors.Window
        txtCorrelation.Increment = 0R
        txtCorrelation.Location = New Point(58, 613)
        txtCorrelation.MaxValue = 100R
        txtCorrelation.MinValue = 0R
        txtCorrelation.Name = "txtCorrelation"
        txtCorrelation.NumericValue = 0R
        txtCorrelation.RectangleColor = Color.Transparent
        txtCorrelation.RectangleStyle = ButtonBorderStyle.None
        txtCorrelation.RoundingStep = 0R
        txtCorrelation.ShadowColor = Color.Transparent
        txtCorrelation.Size = New Size(150, 31)
        txtCorrelation.TabIndex = 247
        txtCorrelation.Text = "0"
        ' 
        ' txtDelay
        ' 
        txtDelay.ArrowsIncrement = 0R
        txtDelay.BackColor_Over = SystemColors.Window
        txtDelay.Increment = 0R
        txtDelay.Location = New Point(462, 576)
        txtDelay.MaxValue = 100R
        txtDelay.MinValue = 0R
        txtDelay.Name = "txtDelay"
        txtDelay.NumericValue = 0R
        txtDelay.RectangleColor = Color.Transparent
        txtDelay.RectangleStyle = ButtonBorderStyle.None
        txtDelay.RoundingStep = 0R
        txtDelay.ShadowColor = Color.Transparent
        txtDelay.Size = New Size(150, 31)
        txtDelay.TabIndex = 248
        txtDelay.Text = "0"
        ' 
        ' txtCorrelationForDelay
        ' 
        txtCorrelationForDelay.ArrowsIncrement = 0R
        txtCorrelationForDelay.BackColor_Over = SystemColors.Window
        txtCorrelationForDelay.Increment = 0R
        txtCorrelationForDelay.Location = New Point(462, 613)
        txtCorrelationForDelay.MaxValue = 100R
        txtCorrelationForDelay.MinValue = 0R
        txtCorrelationForDelay.Name = "txtCorrelationForDelay"
        txtCorrelationForDelay.NumericValue = 0R
        txtCorrelationForDelay.RectangleColor = Color.Transparent
        txtCorrelationForDelay.RectangleStyle = ButtonBorderStyle.None
        txtCorrelationForDelay.RoundingStep = 0R
        txtCorrelationForDelay.ShadowColor = Color.Transparent
        txtCorrelationForDelay.Size = New Size(150, 31)
        txtCorrelationForDelay.TabIndex = 249
        txtCorrelationForDelay.Text = "0"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(364, 579)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 250
        Label2.Text = "Delay"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(685, 324)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 25)
        Label9.TabIndex = 251
        Label9.Text = "Delay"
        ' 
        ' lblCorrelation
        ' 
        lblCorrelation.AutoSize = True
        lblCorrelation.Location = New Point(364, 616)
        lblCorrelation.Name = "lblCorrelation"
        lblCorrelation.Size = New Size(99, 25)
        lblCorrelation.TabIndex = 252
        lblCorrelation.Text = "Correlation"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(664, 324)
        Label11.Name = "Label11"
        Label11.Size = New Size(99, 25)
        Label11.TabIndex = 253
        Label11.Text = "Correlation"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(75, 585)
        Label15.Name = "Label15"
        Label15.Size = New Size(99, 25)
        Label15.TabIndex = 254
        Label15.Text = "Correlation"
        ' 
        ' btnSaveWave
        ' 
        btnSaveWave.Location = New Point(619, 577)
        btnSaveWave.Margin = New Padding(4, 5, 4, 5)
        btnSaveWave.Name = "btnSaveWave"
        btnSaveWave.Size = New Size(107, 67)
        btnSaveWave.TabIndex = 255
        btnSaveWave.Text = "Save Wave"
        btnSaveWave.UseVisualStyleBackColor = True
        ' 
        ' chkTimeSync
        ' 
        chkTimeSync.AutoSize = True
        chkTimeSync.Location = New Point(372, 378)
        chkTimeSync.Margin = New Padding(4, 5, 4, 5)
        chkTimeSync.Name = "chkTimeSync"
        chkTimeSync.Size = New Size(150, 29)
        chkTimeSync.TabIndex = 256
        chkTimeSync.Text = "Clocks Synced"
        chkTimeSync.UseVisualStyleBackColor = True
        ' 
        ' btnConnect
        ' 
        btnConnect.Location = New Point(553, 417)
        btnConnect.Margin = New Padding(4, 5, 4, 5)
        btnConnect.Name = "btnConnect"
        btnConnect.Size = New Size(107, 39)
        btnConnect.TabIndex = 257
        btnConnect.Text = "Open"
        btnConnect.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(807, 534)
        Label16.Name = "Label16"
        Label16.Size = New Size(101, 25)
        Label16.TabIndex = 259
        Label16.Text = "Server's IPs"
        ' 
        ' txtIpServer
        ' 
        txtIpServer.ArrowsIncrement = 0R
        txtIpServer.BackColor_Over = SystemColors.Window
        txtIpServer.Increment = 0R
        txtIpServer.Location = New Point(774, 562)
        txtIpServer.MaxValue = 100R
        txtIpServer.MinValue = 0R
        txtIpServer.Multiline = True
        txtIpServer.Name = "txtIpServer"
        txtIpServer.NumericValue = 100R
        txtIpServer.NumericValueInteger = 100
        txtIpServer.RectangleColor = Color.Transparent
        txtIpServer.RectangleStyle = ButtonBorderStyle.None
        txtIpServer.RoundingStep = 0R
        txtIpServer.ShadowColor = Color.Transparent
        txtIpServer.Size = New Size(166, 79)
        txtIpServer.TabIndex = 258
        txtIpServer.Text = "127.0.0.1"
        txtIpServer.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(782, 348)
        Label17.Name = "Label17"
        Label17.Size = New Size(151, 25)
        Label17.TabIndex = 260
        Label17.Text = "Clients connected"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(1426, 672)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txtIpServer)
        Controls.Add(btnConnect)
        Controls.Add(chkTimeSync)
        Controls.Add(btnSaveWave)
        Controls.Add(Label15)
        Controls.Add(Label11)
        Controls.Add(lblCorrelation)
        Controls.Add(Label9)
        Controls.Add(Label2)
        Controls.Add(txtCorrelationForDelay)
        Controls.Add(txtDelay)
        Controls.Add(txtCorrelation)
        Controls.Add(btnGetStroke)
        Controls.Add(btnEngageSystem)
        Controls.Add(txtCount)
        Controls.Add(btnSaveTemplate)
        Controls.Add(btnGetTemplate)
        Controls.Add(lstClients)
        Controls.Add(btnSyncNTP)
        Controls.Add(lblConnectionStatus)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox_Bands)
        Controls.Add(btnToggle)
        Controls.Add(GroupBox3)
        Controls.Add(lblSyncStatus)
        Controls.Add(GroupBox1)
        Controls.Add(chkEnableServer)
        Controls.Add(GroupBox2)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(6, 5, 6, 5)
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
        PerformLayout()

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableServer As CheckBox
    Friend WithEvents lblSyncStatus As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents lblConnectionStatus As Label
    Friend WithEvents btnSyncNTP As Button
    Friend WithEvents lstClients As ListBox
    Friend WithEvents cmb_AudioInDevices As MyComboBox
    Friend WithEvents btnGetTemplate As Button
    Friend WithEvents btnSaveTemplate As Button
    Friend WithEvents txtCount As MyTextBox
    Friend WithEvents btnEngageSystem As MyButton
    Friend WithEvents btnGetStroke As Button
    Friend WithEvents txtCorrelation As MyTextBox
    Friend WithEvents txtDelay As MyTextBox
    Friend WithEvents txtCorrelationForDelay As MyTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblCorrelation As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnSaveWave As Button
    Friend WithEvents chkTimeSync As CheckBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents txtIpServer As MyTextBox
    Friend WithEvents Label17 As Label
End Class
