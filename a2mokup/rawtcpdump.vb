Public Class rawtcpdump

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles tcpdump.TextChanged

    End Sub
    Public Shared Function outputtcp(write As String)
        Dim time As DateTime = DateTime.Now
        Dim format As String = "[ddd d MMM yyyy HH:mm:ss]: "
        Dim timestamp As String
        timestamp = (time.ToString(format))
        rawtcpdump.tcpdump.Text = rawtcpdump.tcpdump.Text + timestamp + write + vbCrLf
        Return 1
    End Function
    Private Sub texchangetcpdump() Handles tcpdump.TextChanged
        mainform.scroltocaret(Me.tcpdump)
    End Sub

    Private Sub savetcpdump_Click(sender As Object, e As EventArgs) Handles savetcpdump.Click
        Dim time As DateTime = DateTime.Now
        Dim format As String = "dddd.MMM.yyyy.HH.mm.ss"
        Dim timestamp As String
        timestamp = (time.ToString(format))
        tcpdump.SaveFile("C:\tcpdump" + timestamp + ".txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub cleartcpdump_Click(sender As Object, e As EventArgs) Handles cleartcpdump.Click

        If MsgBox("Do you really want to clear the TCP Dump?", MsgBoxStyle.YesNo, "Preparing to clear the TCP Dump...") = MsgBoxResult.Yes Then
            tcpdump.Clear()
        Else
            Exit Sub

        End If
    End Sub

    Private Sub closetcpdump_Click(sender As Object, e As EventArgs) Handles closetcpdump.Click
        Me.Hide()
    End Sub
End Class