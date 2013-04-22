<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alert
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
        Me.GroupBoxTemp = New System.Windows.Forms.GroupBox()
        Me.GroupBoxHumidity = New System.Windows.Forms.GroupBox()
        Me.GroupBoxLight = New System.Windows.Forms.GroupBox()
        Me.hightp = New System.Windows.Forms.Label()
        Me.lowtp = New System.Windows.Forms.Label()
        Me.highhp = New System.Windows.Forms.Label()
        Me.lowhp = New System.Windows.Forms.Label()
        Me.highlp = New System.Windows.Forms.Label()
        Me.lowlp = New System.Windows.Forms.Label()
        Me.ComboBoxht = New System.Windows.Forms.ComboBox()
        Me.ComboBoxlt = New System.Windows.Forms.ComboBox()
        Me.ComboBoxhh = New System.Windows.Forms.ComboBox()
        Me.ComboBoxlh = New System.Windows.Forms.ComboBox()
        Me.ComboBoxhl = New System.Windows.Forms.ComboBox()
        Me.ComboBoxll = New System.Windows.Forms.ComboBox()
        Me.Hidebtn = New System.Windows.Forms.Button()
        Me.GroupBoxTemp.SuspendLayout()
        Me.GroupBoxHumidity.SuspendLayout()
        Me.GroupBoxLight.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTemp
        '
        Me.GroupBoxTemp.Controls.Add(Me.ComboBoxlt)
        Me.GroupBoxTemp.Controls.Add(Me.ComboBoxht)
        Me.GroupBoxTemp.Controls.Add(Me.lowtp)
        Me.GroupBoxTemp.Controls.Add(Me.hightp)
        Me.GroupBoxTemp.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxTemp.Name = "GroupBoxTemp"
        Me.GroupBoxTemp.Size = New System.Drawing.Size(145, 203)
        Me.GroupBoxTemp.TabIndex = 0
        Me.GroupBoxTemp.TabStop = False
        Me.GroupBoxTemp.Text = "Temperature"
        '
        'GroupBoxHumidity
        '
        Me.GroupBoxHumidity.Controls.Add(Me.ComboBoxlh)
        Me.GroupBoxHumidity.Controls.Add(Me.ComboBoxhh)
        Me.GroupBoxHumidity.Controls.Add(Me.lowhp)
        Me.GroupBoxHumidity.Controls.Add(Me.highhp)
        Me.GroupBoxHumidity.Location = New System.Drawing.Point(163, 13)
        Me.GroupBoxHumidity.Name = "GroupBoxHumidity"
        Me.GroupBoxHumidity.Size = New System.Drawing.Size(147, 202)
        Me.GroupBoxHumidity.TabIndex = 1
        Me.GroupBoxHumidity.TabStop = False
        Me.GroupBoxHumidity.Text = "Humidity"
        '
        'GroupBoxLight
        '
        Me.GroupBoxLight.Controls.Add(Me.ComboBoxll)
        Me.GroupBoxLight.Controls.Add(Me.ComboBoxhl)
        Me.GroupBoxLight.Controls.Add(Me.lowlp)
        Me.GroupBoxLight.Controls.Add(Me.highlp)
        Me.GroupBoxLight.Location = New System.Drawing.Point(316, 13)
        Me.GroupBoxLight.Name = "GroupBoxLight"
        Me.GroupBoxLight.Size = New System.Drawing.Size(157, 202)
        Me.GroupBoxLight.TabIndex = 2
        Me.GroupBoxLight.TabStop = False
        Me.GroupBoxLight.Text = "Light"
        '
        'hightp
        '
        Me.hightp.AutoSize = True
        Me.hightp.Location = New System.Drawing.Point(6, 65)
        Me.hightp.Name = "hightp"
        Me.hightp.Size = New System.Drawing.Size(29, 13)
        Me.hightp.TabIndex = 0
        Me.hightp.Text = "High"
        '
        'lowtp
        '
        Me.lowtp.AutoSize = True
        Me.lowtp.Location = New System.Drawing.Point(6, 140)
        Me.lowtp.Name = "lowtp"
        Me.lowtp.Size = New System.Drawing.Size(27, 13)
        Me.lowtp.TabIndex = 1
        Me.lowtp.Text = "Low"
        '
        'highhp
        '
        Me.highhp.AutoSize = True
        Me.highhp.Location = New System.Drawing.Point(6, 64)
        Me.highhp.Name = "highhp"
        Me.highhp.Size = New System.Drawing.Size(29, 13)
        Me.highhp.TabIndex = 0
        Me.highhp.Text = "High"
        '
        'lowhp
        '
        Me.lowhp.AutoSize = True
        Me.lowhp.Location = New System.Drawing.Point(6, 139)
        Me.lowhp.Name = "lowhp"
        Me.lowhp.Size = New System.Drawing.Size(27, 13)
        Me.lowhp.TabIndex = 1
        Me.lowhp.Text = "Low"
        '
        'highlp
        '
        Me.highlp.AutoSize = True
        Me.highlp.Location = New System.Drawing.Point(6, 64)
        Me.highlp.Name = "highlp"
        Me.highlp.Size = New System.Drawing.Size(29, 13)
        Me.highlp.TabIndex = 0
        Me.highlp.Text = "High"
        '
        'lowlp
        '
        Me.lowlp.AutoSize = True
        Me.lowlp.Location = New System.Drawing.Point(6, 139)
        Me.lowlp.Name = "lowlp"
        Me.lowlp.Size = New System.Drawing.Size(27, 13)
        Me.lowlp.TabIndex = 1
        Me.lowlp.Text = "Low"
        '
        'ComboBoxht
        '
        Me.ComboBoxht.FormattingEnabled = True
        Me.ComboBoxht.Location = New System.Drawing.Point(67, 62)
        Me.ComboBoxht.Name = "ComboBoxht"
        Me.ComboBoxht.Size = New System.Drawing.Size(72, 21)
        Me.ComboBoxht.TabIndex = 2
        '
        'ComboBoxlt
        '
        Me.ComboBoxlt.FormattingEnabled = True
        Me.ComboBoxlt.Location = New System.Drawing.Point(67, 137)
        Me.ComboBoxlt.Name = "ComboBoxlt"
        Me.ComboBoxlt.Size = New System.Drawing.Size(72, 21)
        Me.ComboBoxlt.TabIndex = 3
        '
        'ComboBoxhh
        '
        Me.ComboBoxhh.FormattingEnabled = True
        Me.ComboBoxhh.Location = New System.Drawing.Point(65, 61)
        Me.ComboBoxhh.Name = "ComboBoxhh"
        Me.ComboBoxhh.Size = New System.Drawing.Size(76, 21)
        Me.ComboBoxhh.TabIndex = 2
        '
        'ComboBoxlh
        '
        Me.ComboBoxlh.FormattingEnabled = True
        Me.ComboBoxlh.Location = New System.Drawing.Point(65, 136)
        Me.ComboBoxlh.Name = "ComboBoxlh"
        Me.ComboBoxlh.Size = New System.Drawing.Size(76, 21)
        Me.ComboBoxlh.TabIndex = 3
        '
        'ComboBoxhl
        '
        Me.ComboBoxhl.FormattingEnabled = True
        Me.ComboBoxhl.Location = New System.Drawing.Point(74, 61)
        Me.ComboBoxhl.Name = "ComboBoxhl"
        Me.ComboBoxhl.Size = New System.Drawing.Size(77, 21)
        Me.ComboBoxhl.TabIndex = 2
        '
        'ComboBoxll
        '
        Me.ComboBoxll.FormattingEnabled = True
        Me.ComboBoxll.Location = New System.Drawing.Point(74, 136)
        Me.ComboBoxll.Name = "ComboBoxll"
        Me.ComboBoxll.Size = New System.Drawing.Size(77, 21)
        Me.ComboBoxll.TabIndex = 3
        '
        'Hidebtn
        '
        Me.Hidebtn.Location = New System.Drawing.Point(12, 226)
        Me.Hidebtn.Name = "Hidebtn"
        Me.Hidebtn.Size = New System.Drawing.Size(455, 23)
        Me.Hidebtn.TabIndex = 3
        Me.Hidebtn.TabStop = False
        Me.Hidebtn.Text = "Hide"
        Me.Hidebtn.UseVisualStyleBackColor = True
        '
        'alert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 261)
        Me.Controls.Add(Me.Hidebtn)
        Me.Controls.Add(Me.GroupBoxLight)
        Me.Controls.Add(Me.GroupBoxHumidity)
        Me.Controls.Add(Me.GroupBoxTemp)
        Me.Name = "alert"
        Me.Text = "Alert Settings"
        Me.GroupBoxTemp.ResumeLayout(False)
        Me.GroupBoxTemp.PerformLayout()
        Me.GroupBoxHumidity.ResumeLayout(False)
        Me.GroupBoxHumidity.PerformLayout()
        Me.GroupBoxLight.ResumeLayout(False)
        Me.GroupBoxLight.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxTemp As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxlt As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxht As System.Windows.Forms.ComboBox
    Friend WithEvents lowtp As System.Windows.Forms.Label
    Friend WithEvents hightp As System.Windows.Forms.Label
    Friend WithEvents GroupBoxHumidity As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxlh As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxhh As System.Windows.Forms.ComboBox
    Friend WithEvents lowhp As System.Windows.Forms.Label
    Friend WithEvents highhp As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLight As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxll As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxhl As System.Windows.Forms.ComboBox
    Friend WithEvents lowlp As System.Windows.Forms.Label
    Friend WithEvents highlp As System.Windows.Forms.Label
    Friend WithEvents Hidebtn As System.Windows.Forms.Button
End Class
