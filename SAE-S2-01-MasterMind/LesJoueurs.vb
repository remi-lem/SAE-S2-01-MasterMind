Module LesJoueurs

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

        Dim nomJoueur As String = nom
        Dim score As Integer = 0
        Dim BestTime As TimeSpan = New TimeSpan(0, 0, 0, 0, 0)
        Dim nbFirst As Integer = 0
        Dim nbSecond As Integer = 0
        Dim Cumul As TimeSpan = New TimeSpan(0, 0, 0, 0, 0)

        AjoutJoueurComplet(nomJoueur, score, BestTime, nbFirst, nbSecond, Cumul)

    End Sub

    Sub AjoutJoueurComplet(nom As String, score As Integer, bestTime As TimeSpan,
                           nbFirst As Integer, nbSecond As Integer, timeCumul As TimeSpan)
        Dim j As Joueur

        j.nom = nom
        j.score = score
        j.timeCumulé = timeCumul
        j.bestTime = bestTime
        j.nbFirstPlayer = nbFirst
        j.nbSecondPlayer = nbSecond

        If compteur >= joueurs.Length Then
            ReDim Preserve joueurs(compteur + pasExtension)
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
        Dim t0 As TimeSpan = TimeSpan.Zero
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                If joueurs(i).GetBestTime > temps Xor TimeSpan.Compare(temps, t0) Then
                    joueurs(i).SetBestTime(temps)
                End If
                Return
            End If
        Next
    End Sub



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

    Public Function GetNbSecondPlayer(nom As String) As Integer
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return joueurs(i).GetNbSecondPlayer()
            End If
        Next
        Return 0
    End Function

    Public Function GetNbFirstPlayer(nom As String) As Integer
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return joueurs(i).GetNbFirstPlayer()
            End If
        Next
        Return 0
    End Function

    Public Function GetTimeCumulePlayer(nom As String) As TimeSpan
        Debug.Assert(ContainsPlayer(nom))
        For i As Integer = 0 To GetNb() - 1
            If joueurs(i).GetNom = nom Then
                Return joueurs(i).GetTimeCumulé()
            End If
        Next
    End Function


    Public Function Recup_Noms() As List(Of String)
        Dim noms As New List(Of String)
        For i As Integer = 0 To GetNb() - 1
            noms.Add(GetNomPlayer(i))
        Next
        Return noms
    End Function

    Public Function Recup_Scores() As List(Of Integer)
        Dim scores As New List(Of Integer)
        For i As Integer = 0 To GetNb() - 1
            scores.Add(GetScorePlayer(i))
        Next
        Return scores
    End Function

    Public Sub FlushJoueurs()
        Form_Accueil.cbx_Joueur1.Items.Clear()
        Form_Accueil.cbx_Joueur2.Items.Clear()
        Form_Accueil.cbx_Joueur1.Text = ""
        Form_Accueil.cbx_Joueur2.Text = ""
        ReDim joueurs(0) ' pas de preserve pour supprimmer
        compteur = 0
    End Sub
End Module
