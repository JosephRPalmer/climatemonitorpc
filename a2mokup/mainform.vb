Public Class mainform
    Dim uptimenumber As TimeSpan
    Dim WithEvents Client As NetComm.Client
    Dim timenow As Date = Date.Now
    Dim IP As String
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
        rawtcpdump.outputtcp(ID & ": " & Msg & vbNewLine)
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
