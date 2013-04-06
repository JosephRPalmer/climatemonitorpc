Imports System.Xml
Imports System.IO
Imports System.Text
Imports System.Net
Public Class WeatherAPI
    Friend xmlstring As String = " "
    Sub writeapi()
        Dim windspeed As String = ""
        Dim postfirst As String = "PR9"
        Dim inStream As StreamReader
        Dim webRequest As WebRequest
        Dim webresponse As WebResponse
        webRequest = webRequest.Create("http://www.myweather2.com/developer/forecast.ashx?uac=KTRvlm3BTu&output=xml&query=" + postfirst)
        webresponse = webRequest.GetResponse()
        inStream = New StreamReader(webresponse.GetResponseStream())
        xmlstring = inStream.ReadToEnd.ToString()
        My.Computer.FileSystem.WriteAllText("C:\Users\Joseph\Test.txt", xmlstring, True)
        ''concatonates temperature correctly
        'Dim currenttemperature As String = ""
        'If wea.xmlstring.Substring(70, 7) = "</temp>" Then
        '    currenttemperature = wea.xmlstring.Substring(69, 1)
        'ElseIf wea.xmlstring.Substring(71, 7) = "</temp>" Then
        '    currenttemperature = wea.xmlstring.Substring(69, 2)
        'ElseIf wea.xmlstring.Substring(72, 7) = "</temp>" Then
        '    currenttemperature = wea.xmlstring.Substring(69, 3)
        'Else
        '    currenttemperature = "--"
        'End If
        'currenttemperature = currenttemperature + " 'c"
        ''concatonates windspeed correctly
        'windspeed = wea.getvalue("<speed>", "</speed>")
        'windspeed = windspeed + " KPH"

        'mainformfunctions.infoinlog("Temperature in " + postfirst + " = " + currenttemperature)
    End Sub
    Function getvalue(initialtag As String, finaltag As String) As String
        Dim temp As String = xmlstring
        Do While temp.Substring(0, 7) <> initialtag
            temp.Remove(0, 1)
        Loop
        temp.Remove(0, 7)
        Dim i As Integer
        Do While temp.Substring(i, finaltag.Length) <> finaltag
            i += 1
        Loop
        getvalue = temp.Substring(0, i - 1)
        Return getvalue
    End Function

End Class
