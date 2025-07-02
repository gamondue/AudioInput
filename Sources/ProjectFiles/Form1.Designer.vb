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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        GroupBox3 = New GroupBox()
        pBox1 = New PictureBox()
        GroupBox_Bands = New GroupBox()
        Label5 = New Label()
        pbox_SpectrumBars = New PictureBox()
        Label10 = New Label()
        Label6 = New Label()
        Label14 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        btnToggleUdpServer = New Button()
        lblSyncStatus = New Label()
        chkEnableServer = New CheckBox()
        GroupBox4 = New GroupBox()
        lblServerStatus = New Label()
        btnSyncNTP = New Button()
        lstClients = New ListBox()
        CType(tk_TriggerLevel, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(tk_DeadTime, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(pBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox_Bands.SuspendLayout()
        CType(pbox_SpectrumBars, ComponentModel.ISupportInitialize).BeginInit()
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
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label8)
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
        GroupBox_Bands.Controls.Add(Label5)
        GroupBox_Bands.Controls.Add(pbox_SpectrumBars)
        GroupBox_Bands.Controls.Add(Label10)
        GroupBox_Bands.Controls.Add(Label6)
        GroupBox_Bands.Controls.Add(Label14)
        GroupBox_Bands.Controls.Add(Label12)
        GroupBox_Bands.Controls.Add(Label13)
        GroupBox_Bands.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        GroupBox_Bands.ForeColor = Color.Navy
        GroupBox_Bands.Location = New Point(376, 8)
        GroupBox_Bands.Margin = New Padding(4, 3, 4, 3)
        GroupBox_Bands.MinimumSize = New Size(362, 167)
        GroupBox_Bands.Name = "GroupBox_Bands"
        GroupBox_Bands.Padding = New Padding(4, 3, 4, 3)
        GroupBox_Bands.Size = New Size(604, 193)
        GroupBox_Bands.TabIndex = 152
        GroupBox_Bands.TabStop = False
        GroupBox_Bands.Text = "FHT Spectrum bands"
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
        pbox_SpectrumBars.Size = New Size(380, 156)
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
        ' btnToggleUdpServer
        ' 
        btnToggleUdpServer.Location = New Point(257, 368)
        btnToggleUdpServer.Name = "btnToggleUdpServer"
        btnToggleUdpServer.Size = New Size(75, 23)
        btnToggleUdpServer.TabIndex = 238
        btnToggleUdpServer.Text = "Server UDP"
        btnToggleUdpServer.UseVisualStyleBackColor = True
        ' 
        ' lblSyncStatus
        ' 
        lblSyncStatus.AutoSize = True
        lblSyncStatus.Location = New Point(257, 310)
        lblSyncStatus.Name = "lblSyncStatus"
        lblSyncStatus.Size = New Size(77, 15)
        lblSyncStatus.TabIndex = 237
        lblSyncStatus.Text = "lblSyncStatus"
        ' 
        ' chkEnableServer
        ' 
        chkEnableServer.AutoSize = True
        chkEnableServer.Location = New Point(257, 276)
        chkEnableServer.Name = "chkEnableServer"
        chkEnableServer.Size = New Size(58, 19)
        chkEnableServer.TabIndex = 236
        chkEnableServer.Text = "Server"
        chkEnableServer.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.BackColor = Color.LightGoldenrodYellow
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
        ' lblServerStatus
        ' 
        lblServerStatus.AutoSize = True
        lblServerStatus.Location = New Point(257, 338)
        lblServerStatus.Name = "lblServerStatus"
        lblServerStatus.Size = New Size(84, 15)
        lblServerStatus.TabIndex = 239
        lblServerStatus.Text = "lblServerStatus"
        ' 
        ' btnSyncNTP
        ' 
        btnSyncNTP.Location = New Point(257, 236)
        btnSyncNTP.Name = "btnSyncNTP"
        btnSyncNTP.Size = New Size(75, 23)
        btnSyncNTP.TabIndex = 240
        btnSyncNTP.Text = "Sync"
        btnSyncNTP.UseVisualStyleBackColor = True
        ' 
        ' lstClients
        ' 
        lstClients.FormattingEnabled = True
        lstClients.ItemHeight = 15
        lstClients.Location = New Point(404, 231)
        lstClients.Name = "lstClients"
        lstClients.Size = New Size(120, 94)
        lstClients.TabIndex = 241
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(998, 403)
        Controls.Add(lstClients)
        Controls.Add(btnSyncNTP)
        Controls.Add(lblServerStatus)
        Controls.Add(GroupBox4)
        Controls.Add(btnToggleUdpServer)
        Controls.Add(GroupBox3)
        Controls.Add(lblSyncStatus)
        Controls.Add(GroupBox1)
        Controls.Add(chkEnableServer)
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
        CType(pbox_SpectrumBars, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmb_AudioInDevices As MyComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableServer As CheckBox
    Friend WithEvents lblSyncStatus As Label
    Friend WithEvents btnToggleUdpServer As Button
    Friend WithEvents lblServerStatus As Label
    Friend WithEvents btnSyncNTP As Button
    Friend WithEvents lstClients As ListBox
End Class
