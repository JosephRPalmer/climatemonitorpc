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
        Me.graphingbox = New System.Windows.Forms.PictureBox()
        CType(Me.graphingbox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'graphingbox
        '
        Me.graphingbox.Location = New System.Drawing.Point(12, 12)
        Me.graphingbox.Name = "graphingbox"
        Me.graphingbox.Size = New System.Drawing.Size(601, 376)
        Me.graphingbox.TabIndex = 1
        Me.graphingbox.TabStop = False
        '
        'graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 429)
        Me.Controls.Add(Me.graphingbox)
        Me.Controls.Add(Me.closegraph)
        Me.Name = "graph"
        Me.Text = "Graphs"
        CType(Me.graphingbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closegraph As System.Windows.Forms.Button
    Friend WithEvents graphingbox As System.Windows.Forms.PictureBox
End Class
