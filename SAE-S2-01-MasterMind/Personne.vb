﻿Module Personne

    Public DEBUG_MODE = True ' METTRE FALSE AVANT DE RENDRE !!!!

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
            Me.timeCumulé.Add(temps)
        End Sub

        Public Sub AjoutenbFirstPlayer()
            Me.nbFirstPlayer += 1
        End Sub

        Public Sub AjoutenbSecondPlayer()
            Me.nbSecondPlayer += 1
        End Sub

        Public Sub setBestTime(meilleurTemps As TimeSpan)
            Me.bestTime = meilleurTemps
        End Sub

        Public Function getNom() As String
            Return Me.nom
        End Function

    End Structure

    Private Const pasExtension As Integer = 10
    Private joueurs() As Joueur

    Sub Main()
        Dim nombre As Integer = 20
        ReDim joueurs(nombre)
        Application.Run(Form_Accueil)
    End Sub

    Private compteur As Integer = 0

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

    Public Function getNb() As Integer
        Return compteur
    End Function

    Private Function getPlayer(i As Integer) As Joueur
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

    Public Sub AjouteUnPointA(nom As String)
        For i As Integer = 0 To getNb() - 1
            If getPlayer(i).nom = nom Then
                getPlayer(i).AjouteUnPoint()
            End If
        Next
    End Sub

    Public Sub ajouternBFirstPlayer(nom As String)
        Debug.Assert(containsPlayer(nom))
        For i As Integer = 0 To getNb() - 1
            If joueurs(i).nom = nom Then
                joueurs(i).AjoutenbFirstPlayer()
            End If
        Next
    End Sub
    Public Sub ajouternBSecondPlayer(nom As String)
        Debug.Assert(containsPlayer(nom))
        For i As Integer = 0 To getNb() - 1
            If joueurs(i).nom = nom Then
                joueurs(i).AjoutenbSecondPlayer()
            End If
        Next
    End Sub

    Public Function getNomPlayer(i As Integer) As String
        Return joueurs(i).nom
    End Function

    Public Function getScorePlayer(i As Integer) As Integer
        Return joueurs(i).score
    End Function
    Public Function getBestTimePlayer(i As Integer) As TimeSpan
        Return joueurs(i).bestTime
    End Function
    Public Function getNbJ1Player(i As Integer) As Integer
        Return joueurs(i).nbFirstPlayer
    End Function
    Public Function getNbJ2Player(i As Integer) As Integer
        Return joueurs(i).nbSecondPlayer
    End Function
    Public Function getTimeCumulePlayer(i As Integer) As TimeSpan
        Return joueurs(i).timeCumulé
    End Function




    Public Function getPoints(nom As String) As Integer
        Debug.Assert(containsPlayer(nom))
        For i As Integer = 0 To getNb() - 1
            If joueurs(i).nom = nom Then
                Return joueurs(i).score
            End If
        Next
    End Function
    Public Function getBestTime(nom As String) As TimeSpan
        Debug.Assert(containsPlayer(nom))
        For i As Integer = 0 To getNb() - 1
            If joueurs(i).nom = nom Then
                Return joueurs(i).bestTime
            End If
        Next
    End Function

End Module
