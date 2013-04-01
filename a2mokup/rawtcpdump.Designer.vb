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
        Me.SuspendLayout()
        '
        'tcpdump
        '
        Me.tcpdump.Location = New System.Drawing.Point(12, 12)
        Me.tcpdump.Name = "tcpdump"
        Me.tcpdump.Size = New System.Drawing.Size(453, 288)
        Me.tcpdump.TabIndex = 0
        Me.tcpdump.Text = ""
        '
        'rawtcpdump
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 312)
        Me.Controls.Add(Me.tcpdump)
        Me.Name = "rawtcpdump"
        Me.Text = "Raw TCP Dump"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tcpdump As System.Windows.Forms.RichTextBox
End Class
