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
        Application.Run(Form_Accueil)
    End Sub

    Private compteur As Integer = 0

    Sub Ajout(j As Joueur)

        If compteur >= joueurs.Length Then
            ReDim joueurs(compteur + pasExtension)

        End If
        joueurs(compteur) = j
        compteur += 1

    End Sub

    Public Function getNb() As Integer
        Return compteur
    End Function

    Public Function getPlayer(i As Integer) As Joueur
        Debug.Assert(i <= compteur)
        Return joueurs(i)
    End Function

    Public Function containsPlayer(nom As String) As Boolean
        Dim contient As Boolean = False
        For i As Integer = 0 To getNb() - 1
            If getPlayer(i).nom = nom Then
                contient = True
            End If
        Next
        Return contient
    End Function

    Public Function JoueurCourant(nom As String) As Joueur
        For i As Integer = 0 To getNb() - 1
            If getPlayer(i).nom = nom Then
                Return getPlayer(i)
            End If
        Next
    End Function


End Module
