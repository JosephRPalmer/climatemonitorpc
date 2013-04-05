Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class mainform
    Dim connection As New OleDbConnection(My.Settings.db)
    Dim uptimenumber As TimeSpan
    Dim WithEvents Client As NetComm.Client
    Dim timenow As Date = Date.Now
    Dim IP As String
    Dim thedate As New Date
    Dim i1, i2, i3 As Integer
    Dim strreceived As String
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainformfunctions.programstart()
        connecttomonitor()
        remoteipc.Text = IP
        portsc.Text = "8080"
    End Sub
    Private Sub connecttomonitor()
        Client = New NetComm.Client()
        Dim ID As String = "1"
        IP = InputBox("Enter the IP address shown on the climate monitor", "Connecting...")
        Client.Connect(IP, 8080, ID)
    End Sub
    Private Sub exitb_Click(sender As Object, e As EventArgs) Handles exitb.Click
        Client.Disconnect()
        End
    End Sub
    Private Sub Connected() Handles Client.Connected
        mainformfunctions.infoinlog("Connection successful")
        connectionc.Text = "Connected"
        mainformfunctions.titlebar("CONNECTED")
        rawtcpdump.outputtcp("CONNECTED")
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        thedate = Date.Now
        i1 = 3
        i2 = 4
        i3 = 67
        dtahandling()

    End Sub

    Private Sub textchangelog() Handles Log.TextChanged
        mainformfunctions.scroltocaret(Me.Log)
    End Sub
    Private Sub Graphs_Click(sender As Object, e As EventArgs) Handles Graphs.Click
        graph.Show()
    End Sub
    Private Sub lostconnection() Handles Client.Disconnected
        mainformfunctions.logfile("CONNECTION LOST")
        connectionc.Text = "Connection Lost"
        mainformfunctions.titlebar("CONNECTION LOST")
        rawtcpdump.outputtcp("CONNECTION LOST")
        Client = New NetComm.Client()
        Dim ID As String = "1"
        Client.Connect(IP, 8080, ID)
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        emailcheck.Checked = False
        smscheck.Checked = False
        smsonec.Clear()
        smstwoc.Clear()
        emailonec.Clear()
        emailtwoc.Clear()
    End Sub
    Private Sub handleserrors(ByVal ex As Exception) Handles Client.errEncounter
        mainformfunctions.infoinlog(ex.ToString)
    End Sub
    Private Sub DataReceived(ByVal Data() As Byte, ByVal ID As String) Handles Client.DataReceived

        If ID = Nothing Then ID = "CCMonitor"
        Dim Msg As String = NetComm.Client.ConvertFromAscii(Data)
        'rawtcpdump.tcpdump.AppendText(ID & ": " & Msg & vbNewLine)
        'check to see the message prefix
        strreceived = Msg
        If Mid(Msg, 1, 5) = "DISPL" Then
            prepsystemmessage()
        ElseIf Mid(Msg, 1, 5) = "SR2DB" Then
            prepdata()
        ElseIf Mid(Msg, 1, 5) = "INFOR" Then

        End If
    End Sub
    Function prepsystemmessage()
        Dim newstr As String
        Dim len As Integer = strreceived.Length
        newstr = strreceived.Substring(6, len - 6)
        rawtcpdump.outputtcp(newstr)
        mainformfunctions.logfile(newstr)
        Return 1
    End Function
    Function prepdata()
        Dim a1, a2, a3, adate As String
        adate = strreceived.Substring(6, 22)
        a1 = strreceived.Substring(29, 1)
        a2 = strreceived.Substring(31, 1)
        a3 = strreceived.Substring(33, 1)
        thedate = CDate(adate)
        i1 = CInt(a1)
        i2 = CInt(a2)
        i3 = CInt(a3)
        dtahandling()
        Return 1
    End Function
    Private Sub dtahandling()
        connection.Open()
        Dim insertSQL As String = "INSERT INTO readings (Datetimeofrecord, Temperature, Humidity, Light) VALUES (@thedate, @i1, @i2, @i3)"
        Dim command As New OleDbCommand(insertSQL, connection)
        With command.Parameters
            .AddWithValue("@thedate", CDate(thedate.ToString("yyyy/MM/dd hh:mm:ss tt")))
            .AddWithValue("@i1", i1)
            .AddWithValue("@i2", i2)
            .AddWithValue("@i3", i3)
        End With
        command.ExecuteNonQuery()
        connection.Close()
        mainformfunctions.logfile("Database Write Operation Successful")
        rawtcpdump.outputtcp("Database Write Operation Successful")
    End Sub
    Private Sub uptimeclocktimer_Tick(sender As Object, e As EventArgs) Handles uptimeclocktimer.Tick
        Dim currentime As Date = Date.Now
        uptimenumber = currentime.Subtract(timenow)
        uptimec.Text = uptimenumber.ToString("hh\:mm\:ss")
    End Sub
    Private Sub reselectnic_Click(sender As Object, e As EventArgs) Handles reselectnic.Click
        mainformfunctions.clearcombonic()
        mainformfunctions.displaypossiblemac()
    End Sub
    Private Sub rawtcpp_Click(sender As Object, e As EventArgs) Handles rawtcpp.Click
        rawtcpdump.Show()
    End Sub
End Class
