Module LesCouleurs
    Private Absent As Color = Color.Black
    Private Present As Color = Color.Blue
    Private PresentPlace As Color = Color.Green

    Public Sub SetAbsent(couleur As Color)
        Absent = couleur
    End Sub

    Public Sub SetPresent(couleur As Color)
        Present = couleur
    End Sub

    Public Sub SetPresentPlace(couleur As Color)
        PresentPlace = couleur
    End Sub

    Public Function GetAbsent() As Color
        Return Absent
    End Function

    Public Function GetPresent() As Color
        Return Present
    End Function

    Public Function GetPresentPlace() As Color
        Return PresentPlace
    End Function
End Module
