<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rawtcpdump
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
        Me.tcpdump = New System.Windows.Forms.RichTextBox()
        Me.savetcpdump = New System.Windows.Forms.Button()
        Me.cleartcpdump = New System.Windows.Forms.Button()
        Me.closetcpdump = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tcpdump
        '
        Me.tcpdump.Location = New System.Drawing.Point(12, 12)
        Me.tcpdump.Name = "tcpdump"
        Me.tcpdump.Size = New System.Drawing.Size(453, 269)
        Me.tcpdump.TabIndex = 0
        Me.tcpdump.Text = ""
        '
        'savetcpdump
        '
        Me.savetcpdump.Location = New System.Drawing.Point(12, 287)
        Me.savetcpdump.Name = "savetcpdump"
        Me.savetcpdump.Size = New System.Drawing.Size(144, 23)
        Me.savetcpdump.TabIndex = 1
        Me.savetcpdump.Text = "Save TCP Dump"
        Me.savetcpdump.UseVisualStyleBackColor = True
        '
        'cleartcpdump
        '
        Me.cleartcpdump.Location = New System.Drawing.Point(162, 287)
        Me.cleartcpdump.Name = "cleartcpdump"
        Me.cleartcpdump.Size = New System.Drawing.Size(151, 23)
        Me.cleartcpdump.TabIndex = 2
        Me.cleartcpdump.Text = "Clear TCP Dump"
        Me.cleartcpdump.UseVisualStyleBackColor = True
        '
        'closetcpdump
        '
        Me.closetcpdump.Location = New System.Drawing.Point(319, 287)
        Me.closetcpdump.Name = "closetcpdump"
        Me.closetcpdump.Size = New System.Drawing.Size(146, 23)
        Me.closetcpdump.TabIndex = 3
        Me.closetcpdump.Text = "Close "
        Me.closetcpdump.UseVisualStyleBackColor = True
        '
        'rawtcpdump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 315)
        Me.Controls.Add(Me.closetcpdump)
        Me.Controls.Add(Me.cleartcpdump)
        Me.Controls.Add(Me.savetcpdump)
        Me.Controls.Add(Me.tcpdump)
        Me.Name = "rawtcpdump"
        Me.Text = "Raw TCP Dump"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcpdump As System.Windows.Forms.RichTextBox
    Friend WithEvents savetcpdump As System.Windows.Forms.Button
    Friend WithEvents cleartcpdump As System.Windows.Forms.Button
    Friend WithEvents closetcpdump As System.Windows.Forms.Button
End Class
