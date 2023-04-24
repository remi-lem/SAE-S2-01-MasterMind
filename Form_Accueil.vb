Public Class Form_Accueil
    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim choix As Integer = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo)
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If cbx_Joueur1.Text = "" Or cbx_Joueur2.Text = "" Then
            MsgBox("Veuillez saisir un nom pour le joueur")

        ElseIf cbx_Joueur1.Text = cbx_Joueur2.Text Then
            MsgBox("Les joueurs ne peuvent avoir le même nom")
        Else
            Form_Faire_Deviner.Show()

        End If


    End Sub

    Private Sub btn_Score_Click(sender As Object, e As EventArgs) Handles btn_Score.Click
        Form_Tableau_Score.Show()
    End Sub
End Class