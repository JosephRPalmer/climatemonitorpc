Public Class rawtcpdump

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles tcpdump.TextChanged

    End Sub
    Public Shared Function outputtcp(ByVal bytes() As Byte, ByVal dataChannel As Integer)
        Dim dontReport As Boolean = False
        If dataChannel < 251 Then

            'Me.ListBox1.Items.Add(BytesToString(bytes))
        ElseIf dataChannel = 255 Then

        End If
        Dim msg As String = tcpCommClient.BytesToString(bytes)
        Dim tmp As String = ""
        Return 1
    End Function


End Class