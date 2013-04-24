Imports System.Drawing
Imports System.Threading
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Windows.Forms.DataVisualization.Charting
Public Class graph
    Dim connection As New OleDbConnection(My.Settings.db)
    Private Sub closegraph_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub
    Dim prop As String = ""
    Dim datetime As Integer = 0
    Private Sub drawgraph_Click(sender As Object, e As EventArgs) Handles drawgraph.Click
        For Each z As Series In graphtowriteto.Series
            z.Dispose()
        Next
        graphtowriteto.Titles.Clear()
        Dim STR As String = "SELECT TOP 20 [" + selectwhattograph.SelectedItem.ToString + "], Datetimeofrecord FROM readings ORDER BY Minute (Datetimeofrecord) "
        Dim oCmd As New OleDbCommand(STR, connection)
        Dim oData As New OleDbDataAdapter(STR, connection)
        Dim ds As New DataSet
        connection.Open()
        oData.Fill(ds)
        connection.Close()
        rawdataview.DataGridView1.DataSource = ds.Tables(0)
        graphtowriteto.Series.Clear()
        graphtowriteto.Titles.Add("Latest Data Graph")
        Dim Item As New Series
        Item.Name = selectwhattograph.SelectedItem.ToString
        Item.ChartType = SeriesChartType.Point
        graphtowriteto.Palette = ChartColorPalette.Bright
        For Each row In rawdataview.DataGridView1.Rows
            prop = row.Cells(0).Value
            datetime = CDate(row.Cells(1).Value).Minute
            Item.Points.AddXY(datetime, prop)
        Next
        graphtowriteto.Series.Add(Item)
    End Sub
End Class