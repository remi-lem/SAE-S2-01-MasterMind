Public Class Form_Tableau_Score
    Private Sub LstNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Nom.SelectedIndexChanged, lst_Score.SelectedIndexChanged, lst_BestTime.SelectedIndexChanged, lst_TempsCumulé.SelectedIndexChanged, lst_FirstPLayer.SelectedIndexChanged, lst_SecondPlayer.SelectedIndexChanged

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
        If GetNbSecondPlayer(cbx_NomSelec.Text) > 0 AndAlso Not TimeSpan.Compare(t0, GetBestTimePlayer(cbx_NomSelec.Text)) Then
            MsgBox("Le joueur " & cbx_NomSelec.Text & " a un total de " & GetScorePlayer(cbx_NomSelec.Text) & " point et n'a pas encore gagné et eu de meilleur temps")
        Else
            MsgBox("Le joueur " & cbx_NomSelec.Text & " a un total de " & GetScorePlayer(cbx_NomSelec.Text) & " points et son meilleur temps est " & GetBestTimePlayer(cbx_NomSelec.Text).Minutes & " minute et " & GetBestTimePlayer(cbx_NomSelec.Text).Seconds & " secondes.")
        End If
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
                lst_FirstPLayer.Items.Add(LesJoueurs.GetNbJ1Player(i))
                lst_SecondPlayer.Items.Add(LesJoueurs.GetNbJ2Player(i))

            End If
        Next

        ' TODO
        'cbx_NomSelec.DropDownStyle = ComboBoxStyle.DropDown
        'cbx_NomSelec.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        'cbx_NomSelec.AutoCompleteSource = AutoCompleteSource.ListItems

    End Sub

    Private Sub Form_Tableau_Score_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub


End Class