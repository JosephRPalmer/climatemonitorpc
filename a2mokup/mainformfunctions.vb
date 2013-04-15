Imports System.Net
Public Class mainformfunctions
    Public Shared Function logfile(write As String)
        Dim time As DateTime = DateTime.Now
        Dim format As String = "[ddd d MMM yyyy HH:mm:ss]: "
        Dim timestamp As String
        timestamp = (time.ToString(format))
        mainform.Log.Text = mainform.Log.Text + timestamp + write + vbCrLf
        Return 1
    End Function
    Public Shared Function infoinlog(write As String)
        mainform.Log.Text = mainform.Log.Text + "***** " + write + " *****" + vbCrLf
        Return 1
    End Function
    Public Shared Function clearlog()
        mainform.Log.Clear()
        Return 1
    End Function
    Public Shared Function titlebar(title As String)
        mainform.Text = "CLIMATE SENSOR: " + title
        Return 1
    End Function
    Public Shared Function resetatstart()
        titlebar("PENDING")
        Return 1
    End Function
    Public Shared Function displaypossiblemac()
        selectnic.Show()
        writecombonic()
        Return 1
    End Function
    Public Shared Function writecombonic()
        For Each nic As System.Net.NetworkInformation.NetworkInterface In System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces()
            If nic.OperationalStatus = Net.NetworkInformation.OperationalStatus.Up Then
                selectnic.possiblenic.Items.Add(String.Format("{0} = {1}{2}" + vbCrLf, nic.Description, Environment.NewLine, nic.GetPhysicalAddress()))
            End If
        Next
        Return 1
    End Function
    Public Shared Function clearcombonic()
        selectnic.possiblenic.Items.Clear()
        Return 1
    End Function
    Public Shared Function writemac()
        Dim mactowrite As String = selectnic.mac
        Dim final As String
        Dim deleteto As Integer
        deleteto = mactowrite.IndexOf("=")
        deleteto = deleteto + 2
        final = mactowrite.Remove(0, deleteto)
        mainform.macc.Text = final
        Return 1
    End Function
    Public Shared Function connectionstatus(status As String)
        mainform.connectionc.Text = status
        Return 1
    End Function
    Public Shared Function getlocalip()
        Dim address As String
        Dim host As String
        host = System.Net.Dns.GetHostName()
        address = System.Net.Dns.GetHostByName(host).AddressList(0).ToString()
        mainform.localipc.Text = address
        Return 1
    End Function
    Public Shared Function programstart()
        Dim api As New WeatherAPI

        resetatstart()
        logfile("SYSTEM STARTED")
        WeatherAPI.writeapi()
        mainform.uptimeclocktimer.Enabled = True
        mainform.uptimeclocktimer.Start()
        logfile("Uptime Enabled Successfully")
        displaypossiblemac()
        connectionstatus("Pending")
        getlocalip()
        logfile("Local IP Address Captured")
        infoinlog("Checking Connection Status")
        gettemperature()
        
        Return 1
    End Function
    Public Shared Function writetcpdata(data As String)
        Dim time As DateTime = DateTime.Now
        Dim format As String = "[ddd d MMM yyyy HH:mm:ss]: "
        Dim timestamp As String
        timestamp = (time.ToString(format))
        rawtcpdump.tcpdump.Text = rawtcpdump.tcpdump.Text + timestamp + data + vbCrLf
        Return 1
    End Function
    Public Shared Function scroltocaret(objecthandle As Object)
        objecthandle.SelectionStart = objecthandle.Text.Length
        objecthandle.ScrollToCaret()
        Return 1
    End Function
    Public Shared Function gettemperature()
        Dim wea As New WeatherAPI
        Dim currenttemperature As String = ""
        currenttemperature = wea.getvalue("<temp>", "</temp>")
        currenttemperature = currenttemperature + " 'c"
        mainform.temperaturec.Text = currenttemperature
        Return 1
    End Function
End Class
