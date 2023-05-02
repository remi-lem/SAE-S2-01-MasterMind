﻿Module LesJoueurs

    Private Structure Joueur
        Dim nom As String
        Dim score As Integer
        Dim bestTime As TimeSpan
        Dim nbFirstPlayer As Integer
        Dim nbSecondPlayer As Integer
        Dim timeCumulé As TimeSpan

        Public Sub AjouteUnPoint()
            Me.score += 1
        End Sub

        Public Sub AjouterTemps(temps As TimeSpan)
            Me.timeCumulé = Me.timeCumulé.Add(temps)
        End Sub

        Public Sub AjoutenbFirstPlayer()
            Me.nbFirstPlayer += 1
        End Sub

        Public Sub AjoutenbSecondPlayer()
            Me.nbSecondPlayer += 1
        End Sub

        Public Sub SetBestTime(meilleurTemps As TimeSpan)
            Me.bestTime = meilleurTemps
        End Sub

        Public Function GetNom() As String
            Return Me.nom
        End Function

        Public Function GetBestTime() As TimeSpan
            Return Me.bestTime
        End Function

        Public Function GetScore() As Integer
            Return Me.score
        End Function

        Public Function GetNbFirstPlayer() As Integer
            Return Me.nbFirstPlayer
        End Function

        Public Function GetNbSecondPlayer() As Integer
            Return Me.nbSecondPlayer
        End Function

        Public Function GetTimeCumulé() As TimeSpan
            Return Me.timeCumulé
        End Function

    End Structure

    Private Const pasExtension As Integer = 10
    Private joueurs() As Joueur
    Private compteur As Integer = 0

    Public Sub ReDimJoueurs(nombre)
        ReDim joueurs(nombre)
    End Sub

    Sub AjoutJoueur(nom As String)
        Dim j As Joueur

        j.nom = nom
        j.score = 0
        j.timeCumulé = New TimeSpan(0, 0, 0, 0, 0)
        j.bestTime = New TimeSpan(0, 0, 0, 0, 0)
        j.nbFirstPlayer = 0
        j.nbSecondPlayer = 0

        If compteur >= joueurs.Length Then
            ReDim joueurs(compteur + pasExtension)
        End If
        joueurs(compteur) = j
        compteur += 1

    End Sub

    Public Function GetNb() As Integer
        Return compteur
    End Function

    Public Function ContainsPlayer(nom As String) As Boolean
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AjouteUnPointA(nom As String)
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                joueurs(i).AjouteUnPoint()
                Return
            End If
        Next
    End Sub

    Public Sub AjouterNbFirstPlayer(nom As String)
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                joueurs(i).AjoutenbFirstPlayer()
                Return
            End If
        Next
    End Sub
    Public Sub AjouterNbSecondPlayer(nom As String)
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                joueurs(i).AjoutenbSecondPlayer()
                Return
            End If
        Next
    End Sub

    Public Sub AjouterTempsCumuleA(nom As String, temps As TimeSpan)
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                joueurs(i).AjouterTemps(temps)
                Return
            End If
        Next
    End Sub

    Public Sub UpdateMeilleurTemps(nom As String, temps As TimeSpan)
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                If joueurs(i).GetBestTime > temps Then
                    joueurs(i).SetBestTime(temps)
                End If
                Return
            End If
        Next
    End Sub

    Public Function GetScorePlayer(nom As String) As Integer
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return joueurs(i).GetScore()
            End If
        Next
        Throw New Exception("Joueur inexistant")
    End Function

    Public Function GetBestTimePlayer(nom As String) As TimeSpan
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return joueurs(i).GetBestTime()
            End If
        Next
    End Function

    Public Function GetNomPlayer(i As Integer) As String
        Return joueurs(i).GetNom
    End Function

    Public Function GetScorePlayer(i As Integer) As Integer
        Return joueurs(i).GetScore
    End Function
    Public Function GetBestTimePlayer(i As Integer) As TimeSpan
        Return joueurs(i).GetBestTime
    End Function
    Public Function GetNbJ1Player(i As Integer) As Integer
        Return joueurs(i).GetNbFirstPlayer
    End Function
    Public Function GetNbJ2Player(i As Integer) As Integer
        Return joueurs(i).GetNbSecondPlayer
    End Function
    Public Function GetTimeCumulePlayer(i As Integer) As TimeSpan
        Return joueurs(i).GetTimeCumulé
    End Function

End Module
