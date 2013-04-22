Imports System.Net.Mail
Imports System.Net

Public Class email
    Public Shared Sub MailAlert(ByVal recepient As String, ByVal body As String)

        Dim newemail As New MailMessage()


        newemail.From = New MailAddress("test@ryan-palmer.com")

        If recepient IsNot Nothing Then
            newemail.To.Add(New MailAddress(recepient))
        Else
            mainformfunctions.infoinlog("No recipient added")
            Exit Sub
        End If

        newemail.CC.Add(New MailAddress("joseph@ryan-palmer.com"))


        newemail.Subject = "ROOM CLIMATE MONITOR ALERT " + Date.Now
        newemail.Body = "ALERT FROM ROOM CLIMATE MONITOR: SENSOR DATA: " + body
        newemail.IsBodyHtml = True
        newemail.Priority = MailPriority.High
        Dim smtp As New SmtpClient()
        smtp.EnableSsl = True
        smtp.Host = "smtp.gmail.com"
        smtp.Port = 587
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network
        smtp.UseDefaultCredentials = False
        smtp.Credentials = New NetworkCredential("alert@jpisystems.com", "password321123")

        mainformfunctions.infoinlog("Sending Alert to " + recepient)
        smtp.Send(newemail)
    End Sub
End Class

