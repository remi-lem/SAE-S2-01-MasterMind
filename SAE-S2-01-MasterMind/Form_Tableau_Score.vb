Public Class Form_Tableau_Score
    Private Sub lstNoms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Nom.SelectedIndexChanged, lst_Score.SelectedIndexChanged, lst_BestTime.SelectedIndexChanged, lst_TempsCumulé.SelectedIndexChanged, lst_FirstPLayer.SelectedIndexChanged, lst_SecondPlayer.SelectedIndexChanged

        Dim i As Integer = sender.SelectedIndex
        lst_Nom.SelectedIndex = i
        lst_Score.SelectedIndex = i
        lst_BestTime.SelectedIndex = i
        lst_TempsCumulé.SelectedIndex = i
        lst_FirstPLayer.SelectedIndex = i
        lst_SecondPlayer.SelectedIndex = i
    End Sub

    Private Sub btn_Accueil_Click(sender As Object, e As EventArgs) Handles btn_Accueil.Click
        Me.Close()
    End Sub

    Private Sub cbx_NomSelec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_NomSelec.SelectedIndexChanged
        MsgBox("ok")
    End Sub

    Private Sub Form_Tableau_Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To getNb() - 1
            If Not cbx_NomSelec.Items.Contains(Personne.getNomPlayer(i)) Then
                cbx_NomSelec.Items.Add(Personne.getNomPlayer(i))
            End If
            If Not lst_Nom.Items.Contains(Personne.getNomPlayer(i)) Then
                lst_Nom.Items.Add(Personne.getNomPlayer(i))
                lst_Score.Items.Add(Personne.getScorePlayer(i))
                lst_BestTime.Items.Add(Personne.getBestTimePlayer(i))
                lst_TempsCumulé.Items.Add(Personne.getTimeCumulePlayer(i))
                lst_FirstPLayer.Items.Add(Personne.getNbJ1Player(i))
                lst_SecondPlayer.Items.Add(Personne.getNbJ2Player(i))

            End If
        Next
    End Sub

    Private Sub Form_Tableau_Score_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub
End Class