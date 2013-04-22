Public Class alert

    Private Sub alert_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 100
            ComboBoxhh.Items.Add(i)
            ComboBoxhl.Items.Add(i)
            ComboBoxht.Items.Add(i)
            ComboBoxlh.Items.Add(i)
            ComboBoxll.Items.Add(i)
            ComboBoxlt.Items.Add(i)
        Next
    End Sub
    Private Sub comboboxchanges(sender As Object, e As EventArgs) Handles ComboBoxht.SelectionChangeCommitted
        mainform.temph = Me.ComboBoxht.SelectedItem
    End Sub

    Private Sub Hide_Click(sender As Object, e As EventArgs) Handles Hidebtn.Click
        Me.Hide()
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