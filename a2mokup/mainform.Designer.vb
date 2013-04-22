<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainform
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
        Me.components = New System.ComponentModel.Container()
        Me.networksetting = New System.Windows.Forms.GroupBox()
        Me.uptimec = New System.Windows.Forms.TextBox()
        Me.portsc = New System.Windows.Forms.TextBox()
        Me.activeportsp = New System.Windows.Forms.Label()
        Me.connectionc = New System.Windows.Forms.TextBox()
        Me.macc = New System.Windows.Forms.TextBox()
        Me.remoteipc = New System.Windows.Forms.TextBox()
        Me.localipc = New System.Windows.Forms.TextBox()
        Me.uptimep = New System.Windows.Forms.Label()
        Me.connectionstatusp = New System.Windows.Forms.Label()
        Me.localmacp = New System.Windows.Forms.Label()
        Me.remoteipp = New System.Windows.Forms.Label()
        Me.localipp = New System.Windows.Forms.Label()
        Me.alertsettings = New System.Windows.Forms.GroupBox()
        Me.editalertsettings = New System.Windows.Forms.Button()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Apply = New System.Windows.Forms.Button()
        Me.smsonec = New System.Windows.Forms.TextBox()
        Me.countrycodeone = New System.Windows.Forms.Label()
        Me.smsonep = New System.Windows.Forms.Label()
        Me.emailonec = New System.Windows.Forms.TextBox()
        Me.emailonep = New System.Windows.Forms.Label()
        Me.smscheck = New System.Windows.Forms.CheckBox()
        Me.emailcheck = New System.Windows.Forms.CheckBox()
        Me.alertstatusp = New System.Windows.Forms.Label()
        Me.systemstatus = New System.Windows.Forms.GroupBox()
        Me.rawtcpp = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.RichTextBox()
        Me.statusc = New System.Windows.Forms.Label()
        Me.statusp = New System.Windows.Forms.Label()
        Me.Graphs = New System.Windows.Forms.Button()
        Me.exitb = New System.Windows.Forms.Button()
        Me.uptimeclocktimer = New System.Windows.Forms.Timer(Me.components)
        Me.reselectnic = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.updateweather = New System.Windows.Forms.Button()
        Me.windspeedc = New System.Windows.Forms.Label()
        Me.pressurec = New System.Windows.Forms.Label()
        Me.humididtyc = New System.Windows.Forms.Label()
        Me.temperaturec = New System.Windows.Forms.Label()
        Me.outlookc = New System.Windows.Forms.TextBox()
        Me.outlookp = New System.Windows.Forms.Label()
        Me.pressurep = New System.Windows.Forms.Label()
        Me.humidityp = New System.Windows.Forms.Label()
        Me.Windspeedp = New System.Windows.Forms.Label()
        Me.temperaturep = New System.Windows.Forms.Label()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.checkconnectivity = New System.Windows.Forms.Timer(Me.components)
        Me.getdata = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lightlrc = New System.Windows.Forms.Label()
        Me.humlrc = New System.Windows.Forms.Label()
        Me.templrc = New System.Windows.Forms.Label()
        Me.lightlrp = New System.Windows.Forms.Label()
        Me.humlrp = New System.Windows.Forms.Label()
        Me.templrp = New System.Windows.Forms.Label()
        Me.networksetting.SuspendLayout()
        Me.alertsettings.SuspendLayout()
        Me.systemstatus.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'networksetting
        '
        Me.networksetting.Controls.Add(Me.uptimec)
        Me.networksetting.Controls.Add(Me.portsc)
        Me.networksetting.Controls.Add(Me.activeportsp)
        Me.networksetting.Controls.Add(Me.connectionc)
        Me.networksetting.Controls.Add(Me.macc)
        Me.networksetting.Controls.Add(Me.remoteipc)
        Me.networksetting.Controls.Add(Me.localipc)
        Me.networksetting.Controls.Add(Me.uptimep)
        Me.networksetting.Controls.Add(Me.connectionstatusp)
        Me.networksetting.Controls.Add(Me.localmacp)
        Me.networksetting.Controls.Add(Me.remoteipp)
        Me.networksetting.Controls.Add(Me.localipp)
        Me.networksetting.Location = New System.Drawing.Point(25, 29)
        Me.networksetting.Name = "networksetting"
        Me.networksetting.Size = New System.Drawing.Size(226, 209)
        Me.networksetting.TabIndex = 0
        Me.networksetting.TabStop = False
        Me.networksetting.Text = "Network Settings"
        '
        'uptimec
        '
        Me.uptimec.Location = New System.Drawing.Point(119, 177)
        Me.uptimec.Name = "uptimec"
        Me.uptimec.ReadOnly = True
        Me.uptimec.Size = New System.Drawing.Size(95, 20)
        Me.uptimec.TabIndex = 11
        Me.uptimec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'portsc
        '
        Me.portsc.Location = New System.Drawing.Point(119, 148)
        Me.portsc.Name = "portsc"
        Me.portsc.ReadOnly = True
        Me.portsc.Size = New System.Drawing.Size(95, 20)
        Me.portsc.TabIndex = 10
        '
        'activeportsp
        '
        Me.activeportsp.AutoSize = True
        Me.activeportsp.Location = New System.Drawing.Point(6, 151)
        Me.activeportsp.Name = "activeportsp"
        Me.activeportsp.Size = New System.Drawing.Size(64, 13)
        Me.activeportsp.TabIndex = 9
        Me.activeportsp.Text = "Active Ports"
        '
        'connectionc
        '
        Me.connectionc.Location = New System.Drawing.Point(119, 119)
        Me.connectionc.Name = "connectionc"
        Me.connectionc.ReadOnly = True
        Me.connectionc.Size = New System.Drawing.Size(95, 20)
        Me.connectionc.TabIndex = 8
        '
        'macc
        '
        Me.macc.Location = New System.Drawing.Point(119, 94)
        Me.macc.Name = "macc"
        Me.macc.ReadOnly = True
        Me.macc.Size = New System.Drawing.Size(95, 20)
        Me.macc.TabIndex = 7
        '
        'remoteipc
        '
        Me.remoteipc.Location = New System.Drawing.Point(119, 67)
        Me.remoteipc.Name = "remoteipc"
        Me.remoteipc.ReadOnly = True
        Me.remoteipc.Size = New System.Drawing.Size(95, 20)
        Me.remoteipc.TabIndex = 6
        '
        'localipc
        '
        Me.localipc.Location = New System.Drawing.Point(119, 37)
        Me.localipc.Name = "localipc"
        Me.localipc.ReadOnly = True
        Me.localipc.Size = New System.Drawing.Size(95, 20)
        Me.localipc.TabIndex = 5
        '
        'uptimep
        '
        Me.uptimep.AutoSize = True
        Me.uptimep.Location = New System.Drawing.Point(6, 180)
        Me.uptimep.Name = "uptimep"
        Me.uptimep.Size = New System.Drawing.Size(40, 13)
        Me.uptimep.TabIndex = 4
        Me.uptimep.Text = "Uptime"
        '
        'connectionstatusp
        '
        Me.connectionstatusp.AutoSize = True
        Me.connectionstatusp.Location = New System.Drawing.Point(7, 122)
        Me.connectionstatusp.Name = "connectionstatusp"
        Me.connectionstatusp.Size = New System.Drawing.Size(94, 13)
        Me.connectionstatusp.TabIndex = 3
        Me.connectionstatusp.Text = "Connection Status"
        '
        'localmacp
        '
        Me.localmacp.AutoSize = True
        Me.localmacp.Location = New System.Drawing.Point(6, 97)
        Me.localmacp.Name = "localmacp"
        Me.localmacp.Size = New System.Drawing.Size(100, 13)
        Me.localmacp.TabIndex = 2
        Me.localmacp.Text = "Local MAC Address"
        '
        'remoteipp
        '
        Me.remoteipp.AutoSize = True
        Me.remoteipp.Location = New System.Drawing.Point(6, 70)
        Me.remoteipp.Name = "remoteipp"
        Me.remoteipp.Size = New System.Drawing.Size(98, 13)
        Me.remoteipp.TabIndex = 1
        Me.remoteipp.Text = "Remote IP Address"
        '
        'localipp
        '
        Me.localipp.AutoSize = True
        Me.localipp.Location = New System.Drawing.Point(6, 38)
        Me.localipp.Name = "localipp"
        Me.localipp.Size = New System.Drawing.Size(87, 13)
        Me.localipp.TabIndex = 0
        Me.localipp.Text = "Local IP Address"
        '
        'alertsettings
        '
        Me.alertsettings.Controls.Add(Me.editalertsettings)
        Me.alertsettings.Controls.Add(Me.Reset)
        Me.alertsettings.Controls.Add(Me.Apply)
        Me.alertsettings.Controls.Add(Me.smsonec)
        Me.alertsettings.Controls.Add(Me.countrycodeone)
        Me.alertsettings.Controls.Add(Me.smsonep)
        Me.alertsettings.Controls.Add(Me.emailonec)
        Me.alertsettings.Controls.Add(Me.emailonep)
        Me.alertsettings.Controls.Add(Me.smscheck)
        Me.alertsettings.Controls.Add(Me.emailcheck)
        Me.alertsettings.Controls.Add(Me.alertstatusp)
        Me.alertsettings.Location = New System.Drawing.Point(257, 29)
        Me.alertsettings.Name = "alertsettings"
        Me.alertsettings.Size = New System.Drawing.Size(227, 231)
        Me.alertsettings.TabIndex = 1
        Me.alertsettings.TabStop = False
        Me.alertsettings.Text = "Alert Settings"
        '
        'editalertsettings
        '
        Me.editalertsettings.Location = New System.Drawing.Point(9, 141)
        Me.editalertsettings.Name = "editalertsettings"
        Me.editalertsettings.Size = New System.Drawing.Size(211, 36)
        Me.editalertsettings.TabIndex = 15
        Me.editalertsettings.Text = "Edit Alert Settings"
        Me.editalertsettings.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(116, 183)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(104, 39)
        Me.Reset.TabIndex = 14
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(9, 184)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(104, 38)
        Me.Apply.TabIndex = 13
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'smsonec
        '
        Me.smsonec.Enabled = False
        Me.smsonec.Location = New System.Drawing.Point(147, 107)
        Me.smsonec.Name = "smsonec"
        Me.smsonec.Size = New System.Drawing.Size(74, 20)
        Me.smsonec.TabIndex = 9
        '
        'countrycodeone
        '
        Me.countrycodeone.AutoSize = True
        Me.countrycodeone.Location = New System.Drawing.Point(108, 110)
        Me.countrycodeone.Name = "countrycodeone"
        Me.countrycodeone.Size = New System.Drawing.Size(25, 13)
        Me.countrycodeone.TabIndex = 8
        Me.countrycodeone.Text = "+44"
        '
        'smsonep
        '
        Me.smsonep.AutoSize = True
        Me.smsonep.Location = New System.Drawing.Point(6, 110)
        Me.smsonep.Name = "smsonep"
        Me.smsonep.Size = New System.Drawing.Size(70, 13)
        Me.smsonep.TabIndex = 7
        Me.smsonep.Text = "SMS Number"
        '
        'emailonec
        '
        Me.emailonec.Location = New System.Drawing.Point(111, 76)
        Me.emailonec.Name = "emailonec"
        Me.emailonec.Size = New System.Drawing.Size(110, 20)
        Me.emailonec.TabIndex = 4
        '
        'emailonep
        '
        Me.emailonep.AutoSize = True
        Me.emailonep.Location = New System.Drawing.Point(6, 83)
        Me.emailonep.Name = "emailonep"
        Me.emailonep.Size = New System.Drawing.Size(73, 13)
        Me.emailonep.TabIndex = 3
        Me.emailonep.Text = "Email Address"
        '
        'smscheck
        '
        Me.smscheck.AutoSize = True
        Me.smscheck.Enabled = False
        Me.smscheck.Location = New System.Drawing.Point(90, 53)
        Me.smscheck.Name = "smscheck"
        Me.smscheck.Size = New System.Drawing.Size(49, 17)
        Me.smscheck.TabIndex = 2
        Me.smscheck.Text = "SMS"
        Me.smscheck.UseVisualStyleBackColor = True
        '
        'emailcheck
        '
        Me.emailcheck.AutoSize = True
        Me.emailcheck.Location = New System.Drawing.Point(9, 53)
        Me.emailcheck.Name = "emailcheck"
        Me.emailcheck.Size = New System.Drawing.Size(51, 17)
        Me.emailcheck.TabIndex = 1
        Me.emailcheck.Text = "Email"
        Me.emailcheck.UseVisualStyleBackColor = True
        '
        'alertstatusp
        '
        Me.alertstatusp.AutoSize = True
        Me.alertstatusp.Location = New System.Drawing.Point(6, 26)
        Me.alertstatusp.Name = "alertstatusp"
        Me.alertstatusp.Size = New System.Drawing.Size(61, 13)
        Me.alertstatusp.TabIndex = 0
        Me.alertstatusp.Text = "Alert Status"
        '
        'systemstatus
        '
        Me.systemstatus.Controls.Add(Me.rawtcpp)
        Me.systemstatus.Controls.Add(Me.Log)
        Me.systemstatus.Controls.Add(Me.statusc)
        Me.systemstatus.Controls.Add(Me.statusp)
        Me.systemstatus.Location = New System.Drawing.Point(490, 29)
        Me.systemstatus.Name = "systemstatus"
        Me.systemstatus.Size = New System.Drawing.Size(320, 381)
        Me.systemstatus.TabIndex = 2
        Me.systemstatus.TabStop = False
        Me.systemstatus.Text = "System Status"
        '
        'rawtcpp
        '
        Me.rawtcpp.Location = New System.Drawing.Point(16, 331)
        Me.rawtcpp.Name = "rawtcpp"
        Me.rawtcpp.Size = New System.Drawing.Size(298, 39)
        Me.rawtcpp.TabIndex = 3
        Me.rawtcpp.Text = "Technical Information"
        Me.rawtcpp.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(16, 63)
        Me.Log.Name = "Log"
        Me.Log.ReadOnly = True
        Me.Log.Size = New System.Drawing.Size(298, 249)
        Me.Log.TabIndex = 2
        Me.Log.Text = ""
        '
        'statusc
        '
        Me.statusc.AutoSize = True
        Me.statusc.Location = New System.Drawing.Point(119, 32)
        Me.statusc.Name = "statusc"
        Me.statusc.Size = New System.Drawing.Size(47, 13)
        Me.statusc.TabIndex = 1
        Me.statusc.Text = "ONLINE"
        '
        'statusp
        '
        Me.statusp.AutoSize = True
        Me.statusp.Location = New System.Drawing.Point(16, 31)
        Me.statusp.Name = "statusp"
        Me.statusp.Size = New System.Drawing.Size(73, 13)
        Me.statusp.TabIndex = 0
        Me.statusp.Text = "Overall Status"
        '
        'Graphs
        '
        Me.Graphs.Location = New System.Drawing.Point(25, 253)
        Me.Graphs.Name = "Graphs"
        Me.Graphs.Size = New System.Drawing.Size(226, 37)
        Me.Graphs.TabIndex = 3
        Me.Graphs.Text = "To Graphs"
        Me.Graphs.UseVisualStyleBackColor = True
        '
        'exitb
        '
        Me.exitb.Location = New System.Drawing.Point(25, 341)
        Me.exitb.Name = "exitb"
        Me.exitb.Size = New System.Drawing.Size(226, 38)
        Me.exitb.TabIndex = 4
        Me.exitb.Text = "Exit"
        Me.exitb.UseVisualStyleBackColor = True
        '
        'uptimeclocktimer
        '
        Me.uptimeclocktimer.Enabled = True
        Me.uptimeclocktimer.Interval = 1000
        '
        'reselectnic
        '
        Me.reselectnic.Location = New System.Drawing.Point(25, 296)
        Me.reselectnic.Name = "reselectnic"
        Me.reselectnic.Size = New System.Drawing.Size(226, 39)
        Me.reselectnic.TabIndex = 5
        Me.reselectnic.Text = "Select Network Interface"
        Me.reselectnic.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.updateweather)
        Me.GroupBox1.Controls.Add(Me.windspeedc)
        Me.GroupBox1.Controls.Add(Me.pressurec)
        Me.GroupBox1.Controls.Add(Me.humididtyc)
        Me.GroupBox1.Controls.Add(Me.temperaturec)
        Me.GroupBox1.Controls.Add(Me.outlookc)
        Me.GroupBox1.Controls.Add(Me.outlookp)
        Me.GroupBox1.Controls.Add(Me.pressurep)
        Me.GroupBox1.Controls.Add(Me.humidityp)
        Me.GroupBox1.Controls.Add(Me.Windspeedp)
        Me.GroupBox1.Controls.Add(Me.temperaturep)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 416)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(785, 94)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Current Weather"
        '
        'updateweather
        '
        Me.updateweather.Location = New System.Drawing.Point(645, 38)
        Me.updateweather.Name = "updateweather"
        Me.updateweather.Size = New System.Drawing.Size(134, 23)
        Me.updateweather.TabIndex = 10
        Me.updateweather.Text = "Update"
        Me.updateweather.UseVisualStyleBackColor = True
        '
        'windspeedc
        '
        Me.windspeedc.AutoSize = True
        Me.windspeedc.Location = New System.Drawing.Point(319, 57)
        Me.windspeedc.Name = "windspeedc"
        Me.windspeedc.Size = New System.Drawing.Size(13, 13)
        Me.windspeedc.TabIndex = 9
        Me.windspeedc.Text = "0"
        '
        'pressurec
        '
        Me.pressurec.AutoSize = True
        Me.pressurec.Location = New System.Drawing.Point(319, 25)
        Me.pressurec.Name = "pressurec"
        Me.pressurec.Size = New System.Drawing.Size(13, 13)
        Me.pressurec.TabIndex = 8
        Me.pressurec.Text = "0"
        '
        'humididtyc
        '
        Me.humididtyc.AutoSize = True
        Me.humididtyc.Location = New System.Drawing.Point(135, 57)
        Me.humididtyc.Name = "humididtyc"
        Me.humididtyc.Size = New System.Drawing.Size(13, 13)
        Me.humididtyc.TabIndex = 7
        Me.humididtyc.Text = "0"
        '
        'temperaturec
        '
        Me.temperaturec.AutoSize = True
        Me.temperaturec.Location = New System.Drawing.Point(135, 25)
        Me.temperaturec.Name = "temperaturec"
        Me.temperaturec.Size = New System.Drawing.Size(13, 13)
        Me.temperaturec.TabIndex = 6
        Me.temperaturec.Text = "0"
        '
        'outlookc
        '
        Me.outlookc.HideSelection = False
        Me.outlookc.Location = New System.Drawing.Point(379, 54)
        Me.outlookc.Name = "outlookc"
        Me.outlookc.ReadOnly = True
        Me.outlookc.Size = New System.Drawing.Size(244, 20)
        Me.outlookc.TabIndex = 5
        '
        'outlookp
        '
        Me.outlookp.AutoSize = True
        Me.outlookp.Location = New System.Drawing.Point(376, 25)
        Me.outlookp.Name = "outlookp"
        Me.outlookp.Size = New System.Drawing.Size(81, 13)
        Me.outlookp.TabIndex = 4
        Me.outlookp.Text = "Current Outlook"
        '
        'pressurep
        '
        Me.pressurep.AutoSize = True
        Me.pressurep.Location = New System.Drawing.Point(184, 25)
        Me.pressurep.Name = "pressurep"
        Me.pressurep.Size = New System.Drawing.Size(85, 13)
        Me.pressurep.TabIndex = 3
        Me.pressurep.Text = "Current Pressure"
        '
        'humidityp
        '
        Me.humidityp.AutoSize = True
        Me.humidityp.Location = New System.Drawing.Point(7, 57)
        Me.humidityp.Name = "humidityp"
        Me.humidityp.Size = New System.Drawing.Size(84, 13)
        Me.humidityp.TabIndex = 2
        Me.humidityp.Text = "Current Humidity"
        '
        'Windspeedp
        '
        Me.Windspeedp.AutoSize = True
        Me.Windspeedp.Location = New System.Drawing.Point(184, 57)
        Me.Windspeedp.Name = "Windspeedp"
        Me.Windspeedp.Size = New System.Drawing.Size(98, 13)
        Me.Windspeedp.TabIndex = 1
        Me.Windspeedp.Text = "Current Windspeed"
        '
        'temperaturep
        '
        Me.temperaturep.AutoSize = True
        Me.temperaturep.Location = New System.Drawing.Point(7, 25)
        Me.temperaturep.Name = "temperaturep"
        Me.temperaturep.Size = New System.Drawing.Size(104, 13)
        Me.temperaturep.TabIndex = 0
        Me.temperaturep.Text = "Current Temperature"
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'checkconnectivity
        '
        Me.checkconnectivity.Interval = 240000
        '
        'getdata
        '
        Me.getdata.Interval = 20000
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lightlrc)
        Me.GroupBox2.Controls.Add(Me.humlrc)
        Me.GroupBox2.Controls.Add(Me.templrc)
        Me.GroupBox2.Controls.Add(Me.lightlrp)
        Me.GroupBox2.Controls.Add(Me.humlrp)
        Me.GroupBox2.Controls.Add(Me.templrp)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 266)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(227, 144)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Latest Readings"
        '
        'lightlrc
        '
        Me.lightlrc.AutoSize = True
        Me.lightlrc.Location = New System.Drawing.Point(138, 94)
        Me.lightlrc.Name = "lightlrc"
        Me.lightlrc.Size = New System.Drawing.Size(13, 13)
        Me.lightlrc.TabIndex = 5
        Me.lightlrc.Text = "0"
        '
        'humlrc
        '
        Me.humlrc.AutoSize = True
        Me.humlrc.Location = New System.Drawing.Point(138, 62)
        Me.humlrc.Name = "humlrc"
        Me.humlrc.Size = New System.Drawing.Size(13, 13)
        Me.humlrc.TabIndex = 4
        Me.humlrc.Text = "0"
        '
        'templrc
        '
        Me.templrc.AutoSize = True
        Me.templrc.Location = New System.Drawing.Point(138, 30)
        Me.templrc.Name = "templrc"
        Me.templrc.Size = New System.Drawing.Size(13, 13)
        Me.templrc.TabIndex = 3
        Me.templrc.Text = "0"
        '
        'lightlrp
        '
        Me.lightlrp.AutoSize = True
        Me.lightlrp.Location = New System.Drawing.Point(11, 94)
        Me.lightlrp.Name = "lightlrp"
        Me.lightlrp.Size = New System.Drawing.Size(30, 13)
        Me.lightlrp.TabIndex = 2
        Me.lightlrp.Text = "Light"
        '
        'humlrp
        '
        Me.humlrp.AutoSize = True
        Me.humlrp.Location = New System.Drawing.Point(11, 62)
        Me.humlrp.Name = "humlrp"
        Me.humlrp.Size = New System.Drawing.Size(47, 13)
        Me.humlrp.TabIndex = 1
        Me.humlrp.Text = "Humidity"
        '
        'templrp
        '
        Me.templrp.AutoSize = True
        Me.templrp.Location = New System.Drawing.Point(11, 30)
        Me.templrp.Name = "templrp"
        Me.templrp.Size = New System.Drawing.Size(67, 13)
        Me.templrp.TabIndex = 0
        Me.templrp.Text = "Temperature"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 520)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.reselectnic)
        Me.Controls.Add(Me.exitb)
        Me.Controls.Add(Me.Graphs)
        Me.Controls.Add(Me.systemstatus)
        Me.Controls.Add(Me.alertsettings)
        Me.Controls.Add(Me.networksetting)
        Me.Name = "mainform"
        Me.networksetting.ResumeLayout(False)
        Me.networksetting.PerformLayout()
        Me.alertsettings.ResumeLayout(False)
        Me.alertsettings.PerformLayout()
        Me.systemstatus.ResumeLayout(False)
        Me.systemstatus.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents networksetting As System.Windows.Forms.GroupBox
    Friend WithEvents activeportsp As System.Windows.Forms.Label
    Friend WithEvents uptimep As System.Windows.Forms.Label
    Friend WithEvents connectionstatusp As System.Windows.Forms.Label
    Friend WithEvents localmacp As System.Windows.Forms.Label
    Friend WithEvents remoteipp As System.Windows.Forms.Label
    Friend WithEvents localipp As System.Windows.Forms.Label
    Friend WithEvents alertsettings As System.Windows.Forms.GroupBox
    Friend WithEvents systemstatus As System.Windows.Forms.GroupBox
    Friend WithEvents Graphs As System.Windows.Forms.Button
    Friend WithEvents exitb As System.Windows.Forms.Button
    Friend WithEvents Reset As System.Windows.Forms.Button
    Friend WithEvents Apply As System.Windows.Forms.Button
    Friend WithEvents smsonec As System.Windows.Forms.TextBox
    Friend WithEvents countrycodeone As System.Windows.Forms.Label
    Friend WithEvents smsonep As System.Windows.Forms.Label
    Friend WithEvents emailonec As System.Windows.Forms.TextBox
    Friend WithEvents emailonep As System.Windows.Forms.Label
    Friend WithEvents smscheck As System.Windows.Forms.CheckBox
    Friend WithEvents emailcheck As System.Windows.Forms.CheckBox
    Friend WithEvents alertstatusp As System.Windows.Forms.Label
    Friend WithEvents Log As System.Windows.Forms.RichTextBox
    Friend WithEvents statusc As System.Windows.Forms.Label
    Friend WithEvents statusp As System.Windows.Forms.Label
    Friend WithEvents uptimeclocktimer As System.Windows.Forms.Timer
    Friend WithEvents reselectnic As System.Windows.Forms.Button
    Friend WithEvents uptimec As System.Windows.Forms.TextBox
    Friend WithEvents portsc As System.Windows.Forms.TextBox
    Friend WithEvents connectionc As System.Windows.Forms.TextBox
    Friend WithEvents macc As System.Windows.Forms.TextBox
    Friend WithEvents remoteipc As System.Windows.Forms.TextBox
    Friend WithEvents localipc As System.Windows.Forms.TextBox
    Friend WithEvents rawtcpp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Windspeedp As System.Windows.Forms.Label
    Friend WithEvents temperaturep As System.Windows.Forms.Label
    Friend WithEvents pressurep As System.Windows.Forms.Label
    Friend WithEvents humidityp As System.Windows.Forms.Label
    Friend WithEvents EventLog1 As System.Diagnostics.EventLog
    Friend WithEvents windspeedc As System.Windows.Forms.Label
    Friend WithEvents pressurec As System.Windows.Forms.Label
    Friend WithEvents humididtyc As System.Windows.Forms.Label
    Friend WithEvents temperaturec As System.Windows.Forms.Label
    Friend WithEvents outlookc As System.Windows.Forms.TextBox
    Friend WithEvents outlookp As System.Windows.Forms.Label
    Friend WithEvents updateweather As System.Windows.Forms.Button
    Friend WithEvents checkconnectivity As System.Windows.Forms.Timer
    Friend WithEvents getdata As System.Windows.Forms.Timer
    Friend WithEvents editalertsettings As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lightlrp As System.Windows.Forms.Label
    Friend WithEvents humlrp As System.Windows.Forms.Label
    Friend WithEvents templrp As System.Windows.Forms.Label
    Friend WithEvents lightlrc As System.Windows.Forms.Label
    Friend WithEvents humlrc As System.Windows.Forms.Label
    Friend WithEvents templrc As System.Windows.Forms.Label

End Class
