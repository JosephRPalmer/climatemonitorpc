Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.ComponentModel

Public Class mainform
    Dim connection As New OleDbConnection(My.Settings.db)
    Dim uptimenumber As TimeSpan
    Dim timenow As Date = Date.Now
    Dim IP As String
    Dim thedate As New Date
    Dim i1, i2, i3 As Integer
    Public temph, templ As Integer
    Dim strreceived As String
    Dim systemip As String
    Dim getdataworker As BackgroundWorker = New BackgroundWorker
    Dim emailad As String

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainformfunctions.programstart()
        remoteipc.Text = systemip
        portsc.Text = "80"
        getdata.Enabled = True
        getdataworker.WorkerSupportsCancellation = True
        getdataworker.WorkerReportsProgress = True
        AddHandler getdataworker.ProgressChanged, AddressOf bw_ProgressChanged
        AddHandler getdataworker.RunWorkerCompleted, AddressOf bw_RunWorkerCompleted
        AddHandler getdataworker.DoWork, AddressOf workerwork
        getdata.Start()
        
    End Sub

    Private Sub exitb_Click(sender As Object, e As EventArgs) Handles exitb.Click
        If MsgBox(("Do you really want to exit? Exiting will close all active connections to climate monitoring devices."), MsgBoxStyle.YesNoCancel, "You are about to close connections") = MsgBoxResult.Yes Then
            End
        Else
            mainformfunctions.logfile("You just tried to close all connections and exit")
        End If
    End Sub
    Private Sub Connected()
        mainformfunctions.infoinlog("Connection successful")
        connectionc.Text = "Connected"
        mainformfunctions.titlebar("CONNECTED")
        rawtcpdump.outputtcp("CONNECTED")
    End Sub
    Private Sub connectionproblems()
        mainformfunctions.infoinlog("Connection Unsuccessful")
        connectionc.Text = "Not Connected"
        mainformfunctions.titlebar("PENDING")
        rawtcpdump.outputtcp("Connection Failure")
    End Sub
    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        emailad = emailonec.Text
        mainformfunctions.infoinlog("Email Saved")
    End Sub

    Private Sub textchangelog() Handles Log.TextChanged
        mainformfunctions.scroltocaret(Me.Log)
    End Sub
    Private Sub Graphs_Click(sender As Object, e As EventArgs) Handles Graphs.Click
        graph.Show()
    End Sub

    Public Shared Function IsConnected() As Boolean
        Try
            Return My.Computer.Network.Ping("74.125.132.94")
        Catch
            Return False
        End Try
    End Function
    Function IsGConnected() As Boolean
        Try
            Return My.Computer.Network.Ping(systemip)
        Catch
            Return False
        End Try
    End Function
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        emailcheck.Checked = False
        smscheck.Checked = False
        smsonec.Clear()
    End Sub

    Function prepinfo()
        Dim newstr As String
        Dim len As Integer = strreceived.Length
        newstr = strreceived.Substring(6, len - 6)
        rawtcpdump.outputtcp(newstr)
        mainformfunctions.infoinlog(newstr)
        Return 1
    End Function
    Function prepsystemmessage()
        Dim newstr As String
        Dim len As Integer = strreceived.Length
        newstr = strreceived.Substring(6, len - 6)
        rawtcpdump.outputtcp(newstr)
        mainformfunctions.logfile(newstr)
        Return 1
    End Function

    Private Sub dtahandling()
        Try
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
        Catch ex As Exception
            mainformfunctions.logfile("Database Write Operation Failed.")
            rawtcpdump.outputtcp("Database Write Operation Failed. Technical Data: " + ex.TargetSite.ToString)

        End Try

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

    Private Sub Windspeedp_Click(sender As Object, e As EventArgs) Handles Windspeedp.Click

    End Sub

    Private Sub updateweather_Click(sender As Object, e As EventArgs) Handles updateweather.Click
        mainformfunctions.gettemperature()
        mainformfunctions.logfile("Weather Updated")
    End Sub

    Private Sub checkconnectivity_Tick(sender As Object, e As EventArgs) Handles checkconnectivity.Tick
        If IsGConnected() = True Then
            Connected()
        Else
            connectionproblems()
        End If
    End Sub
    Function getip()
        systemip = InputBox("Please enter the address shown on the Climate Monitor", "Connection Information", "192.168.1.1")

        Return 1
    End Function

    Private Sub getdata_Tick(sender As Object, e As EventArgs) Handles getdata.Tick

        If Not getdataworker.IsBusy = True Then
            getdataworker.RunWorkerAsync()
            mainformfunctions.logfile("Starting Process")
        End If


    End Sub
    Private Sub workerwork(ByVal sender As Object, ByVal e As DoWorkEventArgs)
        getdataworker.ReportProgress(5)
        mainformfunctions.infoinlog("DATA RETRIEVAL ATTEMPT IN PROGRESS! THIS APPLICATION MAY HANG FOR UP TO 3 MINUTES DEPENDENT ON SYSTEM")
        Try
            Dim authenticationstring As String = New System.Net.WebClient().DownloadString("http://" + systemip + "/authenticate")
            'If parsehtml(authenticationstring, "<h1>", "</h1>") Is "connectionsuccessfulrunprogram" Then
            mainformfunctions.logfile("Connecting ...")
            'getdataworker.ReportProgress(20)
            Dim htmltemp As String = New System.Net.WebClient().DownloadString("http://" + systemip + "/gettemp")
            getdataworker.ReportProgress(30)
            Dim htmlhumid As String = New System.Net.WebClient().DownloadString("http://" + systemip + "/gethumid")
            'getdataworker.ReportProgress(40)
            Dim htmllight As String = New System.Net.WebClient().DownloadString("http://" + systemip + "/getlight")
        

        getdataworker.ReportProgress(60)
        i1 = parsehtml(htmltemp, "<h1>", "</h1>")
        i2 = parsehtml(htmlhumid, "<h1>", "</h1>")
        i3 = parsehtml(htmllight, "<h1>", "</h1>")
        getdataworker.ReportProgress(87)
        thedate = Date.Now
        mainformfunctions.logfile("Connection Terminated")
        dtahandling()
        ' Else
        'mainformfunctions.logfile("Failed to connect to Climate Monitor, reconnection attempt in 60 seconds")
            'End If
        Catch ex As Exception

        End Try
        getdataworker.ReportProgress(100)
        getdataworker.CancelAsync()


    End Sub
    Private Sub bw_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs)
        If e.Cancelled = True Then

        ElseIf e.Error IsNot Nothing Then
            mainformfunctions.logfile("Error in background processing. Code: E1RBGDF0")
        Else
            wrlbl()
            checksend()
        End If
    End Sub
    Sub checksend()
        If emailcheck.Checked = True Then
            If alert.ComboBoxht.SelectedItem <> Nothing Then
                If alert.ComboBoxht.SelectedItem < i1 Then
                    email.MailAlert(emailad, "HIGH TEMPERATURE")
                    Exit Sub
                ElseIf alert.ComboBoxlt.SelectedItem > i1 Then
                    email.MailAlert(emailad, "LOW TEMPERATURE")
                    Exit Sub
                Else
                    Exit Sub
                End If
            End If
            If alert.ComboBoxhh.SelectedItem <> Nothing Then
                If alert.ComboBoxlh.SelectedItem <> Nothing Then
                    If alert.ComboBoxhh.SelectedItem < i2 Then
                        email.MailAlert(emailad, "HIGH HUMIDITY")
                        Exit Sub
                    ElseIf alert.ComboBoxlh.SelectedItem > i2 Then
                        email.MailAlert(emailad, "LOW HUMIDITY")
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
            If alert.ComboBoxhl.SelectedItem <> Nothing Then
                If alert.ComboBoxll.SelectedItem <> Nothing Then
                    If alert.ComboBoxhl.SelectedItem < i2 Then
                        email.MailAlert(emailad, "HIGH LIGHT LEVELS")
                        Exit Sub
                    ElseIf alert.ComboBoxll.SelectedItem > i2 Then
                        email.MailAlert(emailad, "LOW LIGHT LEVELS")
                        Exit Sub
                    Else
                        Exit Sub
                    End If
                End If
            End If
        End If
        



    End Sub
    Sub wrlbl()
        templrc.Text = i1
        humlrc.Text = i2
        lightlrc.Text = i3
    End Sub
    
    Function parsehtml(input As String, initialtag As String, finaltag As String) As String

        Dim x As Integer = initialtag.Length
        Do While input.Substring(0, x) <> initialtag
            input = input.Remove(0, 1)
        Loop
        input = input.Remove(0, x)
        Dim i As Integer = 0
        Do While input.Substring(i, finaltag.Length) <> finaltag
            i += 1
        Loop
        parsehtml = input.Substring(0, i)
        Return parsehtml

    End Function
    Private Sub bw_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        mainformfunctions.logfile("Pulling Data:" & e.ProgressPercentage.ToString() & "%")
    End Sub

    Private Sub alertsettings_Enter(sender As Object, e As EventArgs) Handles alertsettings.Enter

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lightlrp.Click

    End Sub

    Private Sub editalertsettings_Click(sender As Object, e As EventArgs) Handles editalertsettings.Click
        alert.Show()
    End Sub
End Class
