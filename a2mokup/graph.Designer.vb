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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.closegraph = New System.Windows.Forms.Button()
        Me.graphingbox = New System.Windows.Forms.PictureBox()
        Me.DataSet1 = New System.Data.DataSet()
        Me.graphtowriteto = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.selectwhattograph = New System.Windows.Forms.ComboBox()
        Me.drawgraph = New System.Windows.Forms.Button()
        CType(Me.graphingbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graphtowriteto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'graphtowriteto
        '
        ChartArea1.Name = "ChartArea1"
        Me.graphtowriteto.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.graphtowriteto.Legends.Add(Legend1)
        Me.graphtowriteto.Location = New System.Drawing.Point(12, 12)
        Me.graphtowriteto.Name = "graphtowriteto"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.graphtowriteto.Series.Add(Series1)
        Me.graphtowriteto.Size = New System.Drawing.Size(601, 376)
        Me.graphtowriteto.TabIndex = 2
        Me.graphtowriteto.Text = "Chart1"
        '
        'selectwhattograph
        '
        Me.selectwhattograph.FormattingEnabled = True
        Me.selectwhattograph.Items.AddRange(New Object() {"Temperature", "Light", "Humidity"})
        Me.selectwhattograph.Location = New System.Drawing.Point(235, 396)
        Me.selectwhattograph.Name = "selectwhattograph"
        Me.selectwhattograph.Size = New System.Drawing.Size(159, 21)
        Me.selectwhattograph.TabIndex = 3
        '
        'drawgraph
        '
        Me.drawgraph.Location = New System.Drawing.Point(400, 394)
        Me.drawgraph.Name = "drawgraph"
        Me.drawgraph.Size = New System.Drawing.Size(101, 23)
        Me.drawgraph.TabIndex = 4
        Me.drawgraph.Text = "Draw"
        Me.drawgraph.UseVisualStyleBackColor = True
        '
        'graph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 429)
        Me.Controls.Add(Me.drawgraph)
        Me.Controls.Add(Me.selectwhattograph)
        Me.Controls.Add(Me.graphtowriteto)
        Me.Controls.Add(Me.graphingbox)
        Me.Controls.Add(Me.closegraph)
        Me.Name = "graph"
        Me.Text = "Graphs"
        CType(Me.graphingbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graphtowriteto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closegraph As System.Windows.Forms.Button
    Friend WithEvents graphingbox As System.Windows.Forms.PictureBox
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents graphtowriteto As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents selectwhattograph As System.Windows.Forms.ComboBox
    Friend WithEvents drawgraph As System.Windows.Forms.Button
End Class
