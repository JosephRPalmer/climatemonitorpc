Public Class mainform
    Dim uptimenumber As TimeSpan
    Dim timenow As Date = Date.Now
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mainformfunctions.programstart()
    End Sub
    Private Sub exitb_Click(sender As Object, e As EventArgs) Handles exitb.Click
        End
    End Sub

    Private Sub Apply_Click(sender As Object, e As EventArgs) Handles Apply.Click
        
    End Sub

    Private Sub Graphs_Click(sender As Object, e As EventArgs) Handles Graphs.Click
        graph.Show()
    End Sub
    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        emailcheck.Checked = False
        smscheck.Checked = False
        smsonec.Clear()
        smstwoc.Clear()
        emailonec.Clear()
        emailtwoc.Clear()
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
