Module LeTemps

    Private temps As TimeSpan

    ReadOnly tempsDeBase As New TimeSpan(0, 1, 30)
    Public Sub UpdateTemps(tmps_arg As TimeSpan)
        temps = tmps_arg
    End Sub

    Friend Sub InitTempsDeBase()
        temps = tempsDeBase
    End Sub

    Public Function GetTemps() As TimeSpan
        Return temps
    End Function

    Friend Function GetMinutes() As String
        Return temps.Minutes
    End Function

    Friend Function GetSecondes() As String
        Return temps.Seconds
    End Function
End Module
