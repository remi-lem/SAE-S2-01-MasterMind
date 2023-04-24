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
        Me.Hide()
        Form_Accueil.Show()
    End Sub

    Private Sub cbx_NomSelec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_NomSelec.SelectedIndexChanged
        MsgBox("ok")
    End Sub

    Private Sub Form_Tableau_Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 0 To getNb() - 1
            If Not cbx_NomSelec.Items.Contains(getPlayer(i).nom) Then
                cbx_NomSelec.Items.Add(getPlayer(i).nom)
            End If
            If Not lst_Nom.Items.Contains(getPlayer(i).nom) Then
                lst_Nom.Items.Add(getPlayer(i).nom)
                lst_Score.Items.Add(getPlayer(i).score)
                lst_BestTime.Items.Add(getPlayer(i).bestTime)
                lst_TempsCumulé.Items.Add(getPlayer(i).timeCumulé)
                lst_FirstPLayer.Items.Add(getPlayer(i).nbFirstPlayer)
                lst_SecondPlayer.Items.Add(getPlayer(i).nbSecondPlayer)

            End If
        Next
    End Sub


End Class