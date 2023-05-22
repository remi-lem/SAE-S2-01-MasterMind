Public Class Form_Accueil
    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim choix As Integer = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo, "Confirmation")
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If cbx_Joueur1.Text = "" Or cbx_Joueur2.Text = "" Then
            MsgBox("Veuillez saisir un nom pour chaque joueur", vbOKOnly, "Erreur")
        ElseIf cbx_Joueur1.Text = cbx_Joueur2.Text Then
            MsgBox("Les joueurs ne peuvent pas avoir le même nom", vbOKOnly, "Erreur")
        Else
            Form_Faire_Deviner.Close()
            Form_Faire_Deviner.Show()
            Me.Hide()


            Dim joueurSelec1 As String = cbx_Joueur1.Text
            Dim joueurSelec2 As String = cbx_Joueur2.Text

            If Not ContainsPlayer(joueurSelec1) Then
                AjouterJoueur(joueurSelec1)
            End If

            If Not ContainsPlayer(joueurSelec2) Then
                AjouterJoueur(joueurSelec2)
            End If
        End If
    End Sub

    Private Sub Btn_Score_Click(sender As Object, e As EventArgs) Handles btn_Score.Click
        Me.Hide()
        Form_Tableau_Score.Show()
    End Sub

    Private Sub AjouterJoueur(nom As String)
        LesJoueurs.AjoutJoueur(nom)
    End Sub

    Private Sub Form_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DEBUG_MODE Then
            cbx_Joueur1.Text = "Pass"
            cbx_Joueur2.Text = "Tèk"
        End If
        Init_Joueurs_Acc()
    End Sub

    Public Sub Init_Joueurs_Acc()
        Dim nom_j_tmp As String
        For i As Integer = 0 To GetNb() - 1
            nom_j_tmp = LesJoueurs.GetNomPlayer(i)
            If Not cbx_Joueur1.Items.Contains(nom_j_tmp) Then
                cbx_Joueur1.Items.Add(nom_j_tmp)
            End If
            If Not cbx_Joueur2.Items.Contains(nom_j_tmp) Then
                cbx_Joueur2.Items.Add(nom_j_tmp)
            End If
        Next
    End Sub

    Public Sub Inverser_joueurs()
        Dim tmp As String = cbx_Joueur1.Text
        cbx_Joueur1.Text = cbx_Joueur2.Text
        cbx_Joueur2.Text = tmp
    End Sub

    Private Sub Btn_modif_options_Click(sender As Object, e As EventArgs) Handles btn_modif_options.Click
        Me.Hide()
        Form_Modif_Options.Show()
    End Sub

    Private Sub Form_Accueil_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        EcritureDuFichier()
    End Sub

    Private Sub cbx_Joueur1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbx_Joueur1.KeyPress, cbx_Joueur2.KeyPress
        If e.KeyChar = vbBack Then Exit Sub
        If e.KeyChar = "," Xor e.KeyChar = ";" Xor e.KeyChar = ":" Then
            e.Handled = True
        End If
    End Sub
End Class