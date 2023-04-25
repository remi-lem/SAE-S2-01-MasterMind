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
            Form_Faire_Deviner.Show()

        End If

        Dim joueurSelec1 As String = cbx_Joueur1.Text
        Dim joueurSelec2 As String = cbx_Joueur2.Text

        If Not containsPlayer(joueurSelec1) Then
            ajouterJoueur(joueurSelec1)
        End If

        If Not containsPlayer(joueurSelec2) Then
            ajouterJoueur(joueurSelec2)
        End If

        Dim j1 As Joueur = JoueurCourant(joueurSelec1)
        Dim j2 As Joueur = JoueurCourant(joueurSelec2)


    End Sub

    Private Sub btn_Score_Click(sender As Object, e As EventArgs) Handles btn_Score.Click
        Me.Hide()
        Form_Tableau_Score.Show()

    End Sub

    Private Sub ajouterJoueur(nom As String)
        Dim j1 As Joueur = New Joueur
        j1.nom = nom
        j1.score = 0
        j1.timeCumulé = New TimeSpan(0, 0, 0, 0, 0)
        j1.bestTime = New TimeSpan(0, 0, 0, 0, 0)
        j1.nbFirstPlayer = 0
        j1.nbSecondPlayer = 0
        Ajout(j1)
    End Sub

    Private Sub Form_Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If DEBUG_MODE Then
            cbx_Joueur1.Text = "Pass"
            cbx_Joueur2.Text = "Tèk"
        End If

        For i As Integer = 0 To getNb() - 1
            If Not cbx_Joueur1.Items.Contains(getPlayer(i).nom) Then
                cbx_Joueur1.Items.Add(getPlayer(i).nom)
            End If
            If Not cbx_Joueur2.Items.Contains(getPlayer(i).nom) Then
                cbx_Joueur2.Items.Add(getPlayer(i).nom)
            End If
        Next

        cbx_Joueur1.DropDownStyle = ComboBoxStyle.DropDown
        cbx_Joueur1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx_Joueur1.AutoCompleteSource = AutoCompleteSource.ListItems
        cbx_Joueur2.DropDownStyle = ComboBoxStyle.DropDown
        cbx_Joueur2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cbx_Joueur2.AutoCompleteSource = AutoCompleteSource.ListItems
    End Sub
End Class