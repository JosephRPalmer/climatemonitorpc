Imports System.Drawing
Imports System.Threading
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class graph
    Dim connection As New OleDbConnection(My.Settings.db)
    Dim dater(9) As Date
    Dim temp(9) As Integer
    Dim hum(9) As Integer
    Dim light(9) As Integer
    Private Sub closegraph_Click(sender As Object, e As EventArgs) Handles closegraph.Click
        Me.Hide()
    End Sub

    Private Sub graph_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub readindata()
        connection.Open()
        Dim pullfromtable As String = "SELECT * FROM readings WHERE ID = (SELECT MAX(ID)  FROM readings)"
        Dim pullread As New OleDbDataAdapter(pullfromtable, connection)
        pullread.Fill(DataSet1)



    End Sub
End Class