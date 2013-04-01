'Module weatherapi
'    Public Class Features

'        Public Property forecast As Integer
'        End Property
'    End Class

'    Public Class Response

'        Public Property version As String
'        End Property

'        Public Property termsofService As String
'        End Property

'        Public Property features As Features
'        End Property
'    End Class
'    Public Class Forecastday

'        Public Property period As Integer
'        End Property

'        Public Property icon As String
'        End Property

'        Public Property icon_url As String
'        End Property

'        Public Property title As String
'        End Property

'        Public Property fcttext As String
'        End Property

'        Public Property fcttext_metric As String
'        End Property

'        Public Property pop As String
'        End Property
'    End Class
'    Public Class TxtForecast

'     Public Property date As String
'        End Property

'        Public Property forecastday As List(Of Forecastday)
'        End Property
'    End Class
' Public Class Date

'        Public Property epoch As String
'        End Property

'        Public Property pretty As String
'        End Property

'        Public Property day As Integer
'        End Property

'        Public Property month As Integer
'        End Property

'        Public Property year As Integer
'        End Property

'        Public Property yday As Integer
'        End Property

'        Public Property hour As Integer
'        End Property

'        Public Property min As String
'        End Property

'        Public Property sec As Integer
'        End Property

'        Public Property isdst As String
'        End Property

'        Public Property monthname As String
'        End Property

'        Public Property weekday_short As String
'        End Property

'        Public Property weekday As String
'        End Property

'        Public Property ampm As String
'        End Property

'        Public Property tz_short As String
'        End Property

'        Public Property tz_long As String
'        End Property
'    End Class
'    Public Class High

'        Public Property fahrenheit As String
'        End Property

'        Public Property celsius As String
'        End Property
'    End Class
'    Public Class Low

'        Public Property fahrenheit As String
'        End Property

'        Public Property celsius As String
'        End Property
'    End Class
'    Public Class QpfAllday

'     Public Property in As Double
'        End Property

'        Public Property mm As Double
'        End Property
'    End Class
'    Public Class QpfDay

'     Public Property in As Double
'        End Property

'        Public Property mm As Double
'        End Property
'    End Class
'    Public Class QpfNight

'     Public Property in As Double
'        End Property

'        Public Property mm As Double
'        End Property
'    End Class
'    Public Class SnowAllday

'     Public Property in As Integer
'        End Property

'        Public Property cm As Integer
'        End Property
'    End Class
'    Public Class SnowDay

'     Public Property in As Integer
'        End Property

'        Public Property cm As Integer
'        End Property
'    End Class
'    Public Class SnowNight

'     Public Property in As Integer
'        End Property

'        Public Property cm As Integer
'        End Property
'    End Class
'    Public Class Maxwind

'        Public Property mph As Integer
'        End Property

'        Public Property kph As Integer
'        End Property

'        Public Property dir As String
'        End Property

'        Public Property degrees As Integer
'        End Property
'    End Class
'    Public Class Avewind

'        Public Property mph As Integer
'        End Property

'        Public Property kph As Integer
'        End Property

'        Public Property dir As String
'        End Property

'        Public Property degrees As Integer
'        End Property
'    End Class
'    Public Class Forecastday2

'     Public Property date As Date
'        End Property

'        Public Property period As Integer
'        End Property

'        Public Property high As High
'        End Property

'        Public Property low As Low
'        End Property

'        Public Property conditions As String
'        End Property

'        Public Property icon As String
'        End Property

'        Public Property icon_url As String
'        End Property

'        Public Property skyicon As String
'        End Property

'        Public Property pop As Integer
'        End Property

'        Public Property qpf_allday As QpfAllday
'        End Property

'        Public Property qpf_day As QpfDay
'        End Property

'        Public Property qpf_night As QpfNight
'        End Property

'        Public Property snow_allday As SnowAllday
'        End Property

'        Public Property snow_day As SnowDay
'        End Property

'        Public Property snow_night As SnowNight
'        End Property

'        Public Property maxwind As Maxwind
'        End Property

'        Public Property avewind As Avewind
'        End Property

'        Public Property avehumidity As Integer
'        End Property

'        Public Property maxhumidity As Integer
'        End Property

'        Public Property minhumidity As Integer
'        End Property
'    End Class
'    Public Class Simpleforecast

'        Public Property forecastday As List(Of Forecastday2)
'        End Property
'    End Class
'    Public Class Forecast

'        Public Property txt_forecast As TxtForecast
'        End Property

'        Public Property simpleforecast As Simpleforecast
'        End Property
'    End Class
'    Public Class RootObject

'        Public Property response As Response
'        End Property

'        Public Property forecast As Forecast
'        End Property
'    End Class


'End Module
