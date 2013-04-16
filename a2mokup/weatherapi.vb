Imports System.Xml
Imports System.IO
Imports System.Text
Imports System.Net
Public Class WeatherAPI
    Public xmlstring As String
    Public readable As String
    

    Sub writeapi()
        'Dim newWeather As New WeatherAPI
        Dim postfirst As String = "PR9"
        Dim inStream As StreamReader
        Try
            Dim callreq As WebRequest
            Dim respweb As WebResponse
            callreq = WebRequest.Create("http://www.myweather2.com/developer/forecast.ashx?uac=KTRvlm3BTu&output=xml&query=" + postfirst)
            respweb = callreq.GetResponse()
            inStream = New StreamReader(respweb.GetResponseStream())
            Me.xmlstring = inStream.ReadToEnd.ToString()
        Catch ex As Exception
            mainformfunctions.infoinlog("ERROR: " + ex.ToString)
        End Try

        My.Computer.FileSystem.WriteAllText("C:\Users\Joseph\Test.txt", Me.xmlstring, True)

    End Sub
    Function getvalue(initialtag As String, finaltag As String) As String
        Dim newWeather As New WeatherAPI
        newWeather.writeapi()
        'should parse xml feed
        Dim temp As String = newWeather.xmlstring
        If temp IsNot Nothing Then
            Dim x As Integer = initialtag.Length
            Do While temp.Substring(0, x) <> initialtag
                temp = temp.Remove(0, 1)
            Loop
            temp = temp.Remove(0, x)
            Dim i As Integer = 0
            Do While temp.Substring(i, finaltag.Length) <> finaltag
                i += 1
            Loop
            getvalue = temp.Substring(0, i)
            Return getvalue
        Else
            Return "N/A"
        End If
        mainformfunctions.infoinlog("Weather Updated")
    End Function
End Class
