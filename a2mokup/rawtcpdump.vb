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
End Class