Public Class Form_Accueil
    Private Sub btn_Quitter_Click(sender As Object, e As EventArgs) Handles btn_Quitter.Click
        Dim choix As Integer = MsgBox("Voulez-vous vraiment quitter ?", MsgBoxStyle.YesNo)
        If choix = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Start_Click(sender As Object, e As EventArgs) Handles btn_Start.Click
        If cbx_Joueur1.Text = "" Or cbx_Joueur2.Text = "" Then
            MsgBox("Veuillez saisir un nom pour chaque joueur")

        ElseIf cbx_Joueur1.Text = cbx_Joueur2.Text Then
            MsgBox("Les joueurs ne peuvent avoir le même nom")
        Else
            Form_Faire_Deviner.Close()
            Form_Faire_Deviner.Show()
            Me.Hide()
        End If

        Dim joueurSelec1 As String = cbx_Joueur1.Text
        Dim joueurSelec2 As String = cbx_Joueur2.Text

        If Not containsPlayer(joueurSelec1) Then
            ajouterJoueur(joueurSelec1)
        End If

        If Not containsPlayer(joueurSelec2) Then
            ajouterJoueur(joueurSelec2)
        End If



    End Sub

    Private Sub btn_Score_Click(sender As Object, e As EventArgs) Handles btn_Score.Click
        Me.Hide()
        Form_Tableau_Score.Show()

    End Sub

    Private Sub ajouterJoueur(nom As String)
        Personne.AjoutJoueur(nom)
    End Sub

    Private Sub Form_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim nom_j_tmp As String

        If DEBUG_MODE Then
            cbx_Joueur1.Text = "Pass"
            cbx_Joueur2.Text = "Tèk"
        End If

        For i As Integer = 0 To getNb() - 1
            nom_j_tmp = Personne.getNomPlayer(i)
            If Not cbx_Joueur1.Items.Contains(nom_j_tmp) Then
                cbx_Joueur1.Items.Add(nom_j_tmp)
            End If
            If Not cbx_Joueur2.Items.Contains(nom_j_tmp) Then
                cbx_Joueur2.Items.Add(nom_j_tmp)
            End If
        Next

    End Sub

    Public Function inverser_joueurs()
        Dim tmp As String = cbx_Joueur1.Text
        cbx_Joueur1.Text = cbx_Joueur2.Text
        cbx_Joueur2.Text = tmp
    End Function
End Class