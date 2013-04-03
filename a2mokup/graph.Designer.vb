<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class graph
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
        Me.closegraph = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'closegraph
        '
        Me.closegraph.Location = New System.Drawing.Point(507, 394)
        Me.closegraph.Name = "closegraph"
        Me.closegraph.Size = New System.Drawing.Size(106, 23)
        Me.closegraph.TabIndex = 0
        Me.closegraph.Text = "Close Graphs"
        Me.closegraph.UseVisualStyleBackColor = True
        '
        'graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 429)
        Me.Controls.Add(Me.closegraph)
        Me.Name = "graph"
        Me.Text = "Graphs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closegraph As System.Windows.Forms.Button
End Class
