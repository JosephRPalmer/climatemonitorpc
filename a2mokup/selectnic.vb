Public Class selectnic
    Public Shared mac As String
    Private Sub setnic_Click(sender As Object, e As EventArgs) Handles setnic.Click
        If possiblenic.SelectedItem Is Nothing Then
            MsgBox("You have not selected a network interface!", MsgBoxStyle.Information, "Information")
        Else
            mac = possiblenic.Text
            mainformfunctions.writemac()
            Me.Hide()
            mainformfunctions.logfile("MAC Address Captured")
        End If
    End Sub

    Private Sub selectnic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True

    End Sub

    Private Sub refreshniclist_Click(sender As Object, e As EventArgs) Handles refreshniclist.Click
        mainformfunctions.clearcombonic()
        mainformfunctions.writecombonic()
    End Sub
    Private Const CP_NOCLOSE_BUTTON As Integer = &H200 'stops form being closed
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim myCp As CreateParams = MyBase.CreateParams
            myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
            Return myCp
        End Get
    End Property
End Class