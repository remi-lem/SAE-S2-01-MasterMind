Public Class Form_Tableau_Score
    Private trisPar() As String = {"Temps", "Score", "Alphabétique"}
    Private Sub LstNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Nom.SelectedIndexChanged,
        lst_Score.SelectedIndexChanged, lst_BestTime.SelectedIndexChanged, lst_TempsCumulé.SelectedIndexChanged,
        lst_FirstPLayer.SelectedIndexChanged, lst_SecondPlayer.SelectedIndexChanged

        Dim i As Integer = sender.SelectedIndex
        lst_Nom.SelectedIndex = i
        lst_Score.SelectedIndex = i
        lst_BestTime.SelectedIndex = i
        lst_TempsCumulé.SelectedIndex = i
        lst_FirstPLayer.SelectedIndex = i
        lst_SecondPlayer.SelectedIndex = i
    End Sub

    Private Sub Btn_Accueil_Click(sender As Object, e As EventArgs) Handles btn_Accueil.Click
        Me.Close()
    End Sub

    Private Sub Cbx_NomSelec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_NomSelec.SelectedIndexChanged
        Dim t0 As TimeSpan = TimeSpan.Zero
        Dim message As String = ""
        If GetNbSecondPlayer(cbx_NomSelec.Text) > 0 AndAlso Not TimeSpan.Compare(t0, GetBestTimePlayer(cbx_NomSelec.Text)) Then
            message = "Le joueur " & cbx_NomSelec.Text & " a un total de " & getScorePlayer(cbx_NomSelec.Text)
            message &= " point et n'a pas encore gagné et eu de meilleur temps"
        Else
            message = "Le joueur " & cbx_NomSelec.Text & " a un total de " & getScorePlayer(cbx_NomSelec.Text)
            message &= " points et son meilleur temps est " & GetBestTimePlayer(cbx_NomSelec.Text).Minutes
            message &= " minute et " & GetBestTimePlayer(cbx_NomSelec.Text).Seconds & " secondes."
        End If
        MsgBox(message, vbOKOnly, "Informations sur le joueur")
    End Sub

    Private Sub Form_Tableau_Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To GetNb() - 1
            If Not cbx_NomSelec.Items.Contains(LesJoueurs.GetNomPlayer(i)) Then
                cbx_NomSelec.Items.Add(LesJoueurs.GetNomPlayer(i))
            End If
            If Not lst_Nom.Items.Contains(LesJoueurs.GetNomPlayer(i)) Then
                lst_Nom.Items.Add(LesJoueurs.GetNomPlayer(i))
                lst_Score.Items.Add(LesJoueurs.GetScorePlayer(i))
                lst_BestTime.Items.Add(LesJoueurs.GetBestTimePlayer(i))
                lst_TempsCumulé.Items.Add(LesJoueurs.GetTimeCumulePlayer(i))
                lst_FirstPLayer.Items.Add(LesJoueurs.GetNbJ1Player(i) & " fois")
                lst_SecondPlayer.Items.Add(LesJoueurs.GetNbJ2Player(i) & " fois")

            End If
        Next


        For Each elem As String In trisPar
            cbx_tris.Items.Add(elem)
        Next
    End Sub

    Private Sub Form_Tableau_Score_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub

    Private Sub cbx_tris_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_tris.SelectedIndexChanged
        Vider_lstBox()
        If cbx_tris.Text = "Alphabétique" Then
            Dim noms As List(Of String) = LesJoueurs.Recup_Noms()

            Tri_Noms(noms)
            For Each nom As String In noms
                Ajout_Apres_Tri_Noms(nom)

            Next

        End If
        If cbx_tris.Text = "Score" Then
            Dim scores As List(Of Integer) = LesJoueurs.Recup_Scores()
            Tri_Scores(scores)
            Dim noms As List(Of String) = LesJoueurs.Recup_Noms()
            For i As Integer = 0 To scores.Count - 1
                For j As Integer = 0 To noms.Count - 1
                    If getScorePlayer(noms(j)) = scores(i) And Not lst_Nom.Items.Contains(noms(j)) Then
                        lst_Nom.Items.Add(noms(j))
                        lst_Score.Items.Add(LesJoueurs.getScorePlayer(noms(j)))
                        lst_BestTime.Items.Add(LesJoueurs.GetBestTimePlayer(noms(j)))
                        lst_TempsCumulé.Items.Add(LesJoueurs.GetTimeCumulePlayer(noms(j)))
                        lst_FirstPLayer.Items.Add(LesJoueurs.GetNbFirstPlayer(noms(j)) & " fois")
                        lst_SecondPlayer.Items.Add(LesJoueurs.GetNbSecondPlayer(noms(j)) & " fois")
                    End If
                Next
            Next
        End If
        If cbx_tris.Text = "Temps" Then
            Dim times As List(Of TimeSpan) = LesJoueurs.Recup_Time()
            Tri_Temps(times)
            Dim noms As List(Of String) = LesJoueurs.Recup_Noms()
            For i As Integer = 0 To times.Count - 1
                For j As Integer = 0 To noms.Count - 1
                    If GetBestTimePlayer(noms(j)) = times(i) And Not lst_Nom.Items.Contains(noms(j)) Then
                        lst_Nom.Items.Add(noms(j))
                        lst_Score.Items.Add(LesJoueurs.getScorePlayer(noms(j)))
                        lst_BestTime.Items.Add(LesJoueurs.GetBestTimePlayer(noms(j)))
                        lst_TempsCumulé.Items.Add(LesJoueurs.GetTimeCumulePlayer(noms(j)))
                        lst_FirstPLayer.Items.Add(LesJoueurs.GetNbFirstPlayer(noms(j)) & " fois")
                        lst_SecondPlayer.Items.Add(LesJoueurs.GetNbSecondPlayer(noms(j)) & " fois")
                    End If
                Next
            Next
        End If

    End Sub


    Private Sub Vider_lstBox()
        lst_Nom.Items.Clear()
        lst_Score.Items.Clear()
        lst_BestTime.Items.Clear()
        lst_TempsCumulé.Items.Clear()
        lst_FirstPLayer.Items.Clear()
        lst_SecondPlayer.Items.Clear()
    End Sub

    Private Sub Tri_Noms(noms As List(Of String))
        noms.Sort()
    End Sub

    Private Sub Tri_Scores(scores As List(Of Integer))
        scores.Sort()
        scores.Reverse()
    End Sub

    Private Sub Tri_Temps(times As List(Of TimeSpan))
        times.Sort()
    End Sub

    Private Sub Ajout_Apres_Tri_Noms(nom As String)
        lst_Nom.Items.Add(nom)
        lst_Score.Items.Add(LesJoueurs.getScorePlayer(nom))
        lst_BestTime.Items.Add(LesJoueurs.GetBestTimePlayer(nom))
        lst_TempsCumulé.Items.Add(LesJoueurs.GetTimeCumulePlayer(nom))
        lst_FirstPLayer.Items.Add(LesJoueurs.GetNbFirstPlayer(nom) & " fois")
        lst_SecondPlayer.Items.Add(LesJoueurs.GetNbSecondPlayer(nom) & " fois")

    End Sub


End Class

