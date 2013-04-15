Imports System.Xml
Imports System.IO
Imports System.Text
Imports System.Net
Public Class WeatherAPI
    Public xmlstring As String
    Shared Sub writeapi()
        Dim newWeather As New WeatherAPI
        Dim postfirst As String = InputBox("Please enter the first part of your nearest valid postcode", "Weather Location Check", "PR9")
        Dim inStream As StreamReader
        Try
            Dim callreq As WebRequest
            Dim respweb As WebResponse
            callreq = WebRequest.Create("http://www.myweather2.com/developer/forecast.ashx?uac=KTRvlm3BTu&output=xml&query=" + postfirst)
            respweb = callreq.GetResponse()
            inStream = New StreamReader(respweb.GetResponseStream())
            newWeather.xmlstring = inStream.ReadToEnd.ToString()
        Catch ex As Exception
            mainformfunctions.infoinlog("ERROR: " + ex.ToString)
        End Try

        My.Computer.FileSystem.WriteAllText("C:\Users\Joseph\Test.txt", newWeather.xmlstring, True)
    End Sub
    Function getvalue(initialtag As String, finaltag As String) As String
        Dim newWeather As New WeatherAPI
        'should parse xml feed
        Dim temp As String = newWeather.xmlstring
        If temp <> Nothing Then
            Do While temp.Substring(0, 7) <> initialtag
                temp.Remove(0, 1)
            Loop
            temp.Remove(0, 7)
            Dim i As Integer = 0
            Do While temp.Substring(i, finaltag.Length) <> finaltag
                i += 1
            Loop
            getvalue = temp.Substring(0, i)
            Return getvalue
        Else
            Return 1
        End If

    End Function
End Class
