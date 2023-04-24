Module Personne
    Public Structure Joueur
        Dim nom As String
        Dim score As Integer
        Dim bestTime As TimeSpan
        Dim nbFirstPlayer As Integer
        Dim nbSecondPlayer As Integer
        Dim timeCumulé As TimeSpan

    End Structure

    Private Const pasExtension As Integer = 10
    Private joueurs() As Joueur

    Sub Main()
        Dim nombre As Integer = 20
        ReDim joueurs(nombre)
    End Sub

    Private compteur As Integer = 0

    Sub Ajout(p As Joueur)

        If compteur >= joueurs.Length Then
            ReDim joueurs(compteur + pasExtension)

        End If
        joueurs(compteur) = p
        compteur += 1

    End Sub

    Public Function getNb() As Integer
        Return compteur
    End Function

    Public Function getPers(i As Integer) As Joueur
        Debug.Assert(i <= compteur)
        Return joueurs(i)
    End Function
End Module
