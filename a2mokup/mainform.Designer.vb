﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Reset = New System.Windows.Forms.Button()
        Me.Apply = New System.Windows.Forms.Button()
        Me.smstwoc = New System.Windows.Forms.TextBox()
        Me.countrycodetwo = New System.Windows.Forms.Label()
        Me.smstwop = New System.Windows.Forms.Label()
        Me.smsonec = New System.Windows.Forms.TextBox()
        Me.countrycodeone = New System.Windows.Forms.Label()
        Me.smsonep = New System.Windows.Forms.Label()
        Me.emailtwoc = New System.Windows.Forms.TextBox()
        Me.emailtwop = New System.Windows.Forms.Label()
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
        Me.networksetting.SuspendLayout()
        Me.alertsettings.SuspendLayout()
        Me.systemstatus.SuspendLayout()
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
        Me.alertsettings.Controls.Add(Me.Reset)
        Me.alertsettings.Controls.Add(Me.Apply)
        Me.alertsettings.Controls.Add(Me.smstwoc)
        Me.alertsettings.Controls.Add(Me.countrycodetwo)
        Me.alertsettings.Controls.Add(Me.smstwop)
        Me.alertsettings.Controls.Add(Me.smsonec)
        Me.alertsettings.Controls.Add(Me.countrycodeone)
        Me.alertsettings.Controls.Add(Me.smsonep)
        Me.alertsettings.Controls.Add(Me.emailtwoc)
        Me.alertsettings.Controls.Add(Me.emailtwop)
        Me.alertsettings.Controls.Add(Me.emailonec)
        Me.alertsettings.Controls.Add(Me.emailonep)
        Me.alertsettings.Controls.Add(Me.smscheck)
        Me.alertsettings.Controls.Add(Me.emailcheck)
        Me.alertsettings.Controls.Add(Me.alertstatusp)
        Me.alertsettings.Location = New System.Drawing.Point(257, 29)
        Me.alertsettings.Name = "alertsettings"
        Me.alertsettings.Size = New System.Drawing.Size(227, 381)
        Me.alertsettings.TabIndex = 1
        Me.alertsettings.TabStop = False
        Me.alertsettings.Text = "Alert Settings"
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(9, 330)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(211, 39)
        Me.Reset.TabIndex = 14
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Apply
        '
        Me.Apply.Location = New System.Drawing.Point(9, 280)
        Me.Apply.Name = "Apply"
        Me.Apply.Size = New System.Drawing.Size(212, 38)
        Me.Apply.TabIndex = 13
        Me.Apply.Text = "Apply"
        Me.Apply.UseVisualStyleBackColor = True
        '
        'smstwoc
        '
        Me.smstwoc.Location = New System.Drawing.Point(148, 221)
        Me.smstwoc.Name = "smstwoc"
        Me.smstwoc.Size = New System.Drawing.Size(73, 20)
        Me.smstwoc.TabIndex = 12
        '
        'countrycodetwo
        '
        Me.countrycodetwo.AutoSize = True
        Me.countrycodetwo.Location = New System.Drawing.Point(116, 224)
        Me.countrycodetwo.Name = "countrycodetwo"
        Me.countrycodetwo.Size = New System.Drawing.Size(25, 13)
        Me.countrycodetwo.TabIndex = 11
        Me.countrycodetwo.Text = "+44"
        '
        'smstwop
        '
        Me.smstwop.AutoSize = True
        Me.smstwop.Location = New System.Drawing.Point(6, 224)
        Me.smstwop.Name = "smstwop"
        Me.smstwop.Size = New System.Drawing.Size(91, 13)
        Me.smstwop.TabIndex = 10
        Me.smstwop.Text = "2nd SMS Number"
        '
        'smsonec
        '
        Me.smsonec.Location = New System.Drawing.Point(147, 192)
        Me.smsonec.Name = "smsonec"
        Me.smsonec.Size = New System.Drawing.Size(74, 20)
        Me.smsonec.TabIndex = 9
        '
        'countrycodeone
        '
        Me.countrycodeone.AutoSize = True
        Me.countrycodeone.Location = New System.Drawing.Point(116, 196)
        Me.countrycodeone.Name = "countrycodeone"
        Me.countrycodeone.Size = New System.Drawing.Size(25, 13)
        Me.countrycodeone.TabIndex = 8
        Me.countrycodeone.Text = "+44"
        '
        'smsonep
        '
        Me.smsonep.AutoSize = True
        Me.smsonep.Location = New System.Drawing.Point(6, 195)
        Me.smsonep.Name = "smsonep"
        Me.smsonep.Size = New System.Drawing.Size(70, 13)
        Me.smsonep.TabIndex = 7
        Me.smsonep.Text = "SMS Number"
        '
        'emailtwoc
        '
        Me.emailtwoc.Location = New System.Drawing.Point(111, 145)
        Me.emailtwoc.Name = "emailtwoc"
        Me.emailtwoc.Size = New System.Drawing.Size(110, 20)
        Me.emailtwoc.TabIndex = 6
        '
        'emailtwop
        '
        Me.emailtwop.AutoSize = True
        Me.emailtwop.Location = New System.Drawing.Point(6, 148)
        Me.emailtwop.Name = "emailtwop"
        Me.emailtwop.Size = New System.Drawing.Size(94, 13)
        Me.emailtwop.TabIndex = 5
        Me.emailtwop.Text = "2nd Email Address"
        '
        'emailonec
        '
        Me.emailonec.Location = New System.Drawing.Point(111, 116)
        Me.emailonec.Name = "emailonec"
        Me.emailonec.Size = New System.Drawing.Size(110, 20)
        Me.emailonec.TabIndex = 4
        '
        'emailonep
        '
        Me.emailonep.AutoSize = True
        Me.emailonep.Location = New System.Drawing.Point(6, 119)
        Me.emailonep.Name = "emailonep"
        Me.emailonep.Size = New System.Drawing.Size(73, 13)
        Me.emailonep.TabIndex = 3
        Me.emailonep.Text = "Email Address"
        '
        'smscheck
        '
        Me.smscheck.AutoSize = True
        Me.smscheck.Location = New System.Drawing.Point(9, 76)
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
        Me.systemstatus.Location = New System.Drawing.Point(492, 35)
        Me.systemstatus.Name = "systemstatus"
        Me.systemstatus.Size = New System.Drawing.Size(320, 375)
        Me.systemstatus.TabIndex = 2
        Me.systemstatus.TabStop = False
        Me.systemstatus.Text = "System Status"
        '
        'rawtcpp
        '
        Me.rawtcpp.Location = New System.Drawing.Point(16, 324)
        Me.rawtcpp.Name = "rawtcpp"
        Me.rawtcpp.Size = New System.Drawing.Size(298, 39)
        Me.rawtcpp.TabIndex = 3
        Me.rawtcpp.Text = "Raw TCP Dump"
        Me.rawtcpp.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Location = New System.Drawing.Point(16, 63)
        Me.Log.Name = "Log"
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
        Me.Graphs.Location = New System.Drawing.Point(49, 253)
        Me.Graphs.Name = "Graphs"
        Me.Graphs.Size = New System.Drawing.Size(178, 37)
        Me.Graphs.TabIndex = 3
        Me.Graphs.Text = "To Graphs"
        Me.Graphs.UseVisualStyleBackColor = True
        '
        'exitb
        '
        Me.exitb.Location = New System.Drawing.Point(49, 360)
        Me.exitb.Name = "exitb"
        Me.exitb.Size = New System.Drawing.Size(178, 38)
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
        Me.reselectnic.Location = New System.Drawing.Point(49, 308)
        Me.reselectnic.Name = "reselectnic"
        Me.reselectnic.Size = New System.Drawing.Size(178, 39)
        Me.reselectnic.TabIndex = 5
        Me.reselectnic.Text = "Select Network Interface"
        Me.reselectnic.UseVisualStyleBackColor = True
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 432)
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
    Friend WithEvents smstwoc As System.Windows.Forms.TextBox
    Friend WithEvents countrycodetwo As System.Windows.Forms.Label
    Friend WithEvents smstwop As System.Windows.Forms.Label
    Friend WithEvents smsonec As System.Windows.Forms.TextBox
    Friend WithEvents countrycodeone As System.Windows.Forms.Label
    Friend WithEvents smsonep As System.Windows.Forms.Label
    Friend WithEvents emailtwoc As System.Windows.Forms.TextBox
    Friend WithEvents emailtwop As System.Windows.Forms.Label
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

End Class
