Public Class Form_Essais_Joueur_2

    Private nb_coups_restants As Integer
    Private temps_ecoule As New TimeSpan()

    Private Const MAX_NB_COUP_RESTANTS As Integer = 15
    Private ReadOnly MAX_TEMPS_COUP As New TimeSpan(0, 1, 30)

    Private ReadOnly UNE_SECONDE As New TimeSpan(0, 0, 1)

    ReadOnly symbParDefaut1 As String = Symboles.GetSymbDef1()
    ReadOnly symbParDefaut2 As String = Symboles.GetSymbDef2()
    ReadOnly symbParDefaut3 As String = Symboles.GetSymbDef3()
    ReadOnly symbParDefaut4 As String = Symboles.GetSymbDef4()
    ReadOnly symbParDefaut5 As String = Symboles.GetSymbDef5()

    ReadOnly symbParDefaut As New List(Of String) From {symbParDefaut1, symbParDefaut2, symbParDefaut3, symbParDefaut4, symbParDefaut5}
    Private joueur_a_gagne As Boolean = False

    Private Sub Form_Essais_Joueur_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nb_coups_restants = MAX_NB_COUP_RESTANTS
        temps_ecoule = New TimeSpan(0, 0, 0)

        tmr_temps_restant.Start()

        Init_char_jouables()
        Recalc_coups_restants()
        Recalc_temps_ecoule()
    End Sub

    Private Sub Recalc_coups_restants()
        Me.Text = "Il vous reste " & nb_coups_restants & " coups"
        lbl_coups_restants.Text = nb_coups_restants & " coups restants"

        If nb_coups_restants <= 0 Then
            MsgBox(Form_Accueil.cbx_Joueur2.Text & " n'a pas trouvé le pattern de " & Form_Accueil.cbx_Joueur1.Text, vbOKOnly, "Perdu !")
            A_perdu()
            Me.Close()
        End If
    End Sub

    Private Sub Recalc_temps_ecoule()
        lbl_temps_ecoule.Text = temps_ecoule.Minutes & " minute et " & vbCrLf & temps_ecoule.Seconds & " secondes écoulées" & vbCrLf & "Max : " & MAX_TEMPS_COUP.Minutes & ":" & MAX_TEMPS_COUP.Seconds
    End Sub

    Private Sub Tmr_temps_restant_Tick(sender As Object, e As EventArgs) Handles tmr_temps_restant.Tick
        If temps_ecoule.TotalSeconds >= MAX_TEMPS_COUP.TotalSeconds Then
            tmr_temps_restant.Stop()
            MsgBox("temps écoulé !")
            A_perdu()
            Me.Close()
        Else
            temps_ecoule = temps_ecoule.Add(UNE_SECONDE)
        End If
        Recalc_temps_ecoule()
    End Sub

    Private Sub TxtSymb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_symb1.KeyPress, txt_symb2.KeyPress, txt_symb3.KeyPress, txt_symb4.KeyPress, txt_symb5.KeyPress
        sender.Text = ""
        sender.BackColor = Color.White

        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar <> symbParDefaut1 And e.KeyChar <> symbParDefaut2 And e.KeyChar <> symbParDefaut3 And e.KeyChar <> symbParDefaut4 And e.KeyChar <> symbParDefaut5 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Init_char_jouables()
        Dim str_char_jouables As String = ""
        Dim first As Boolean = True
        For Each charJouable As String In symbParDefaut
            If Not first Then
                str_char_jouables += " "
            Else
                first = False
            End If
            str_char_jouables += charJouable
        Next
        lbl_char_jouables.Text = str_char_jouables
    End Sub

    Private Sub Btn_guess_Click(sender As Object, e As EventArgs) Handles btn_guess.Click
        If txt_symb1.Text = "" Or txt_symb2.Text = "" Or txt_symb3.Text = "" Or txt_symb4.Text = "" Or txt_symb5.Text = "" Then
            MsgBox("Merci de remplir tous les caractères")
        Else
            Verif_proposition()
            nb_coups_restants -= 1
            Recalc_coups_restants()
            If Not joueur_a_gagne Then
                txt_symb1.Focus()
            Else
                btn_partir.Focus()
            End If
        End If
    End Sub

    Private Sub Verif_proposition()

        ' TODO : un symbole deja trouvé peut etre marqué comme existant mais pas a la bonne place, à corriger
        ' idée : mettre un compteur du nombre de fois ou est le carctere en question

        Dim symbChoisi As List(Of String) = Form_Faire_Deviner.Get_choisi()
        Dim lst_symb As New List(Of TextBox) From {txt_symb1, txt_symb2, txt_symb3, txt_symb4, txt_symb5}

        For Each txt_box As TextBox In lst_symb
            txt_box.BackColor = Color.White
            If InList(symbChoisi, txt_box.Text) Then
                txt_box.BackColor = Color.Blue
            End If
        Next
        For i As Integer = 0 To symbChoisi.Count - 1
            If lst_symb.Item(i).Text = symbChoisi.Item(i) Then
                lst_symb.Item(i).BackColor = Color.Green
            End If
        Next

        Ajout_essai_liste_essais_prec(lst_symb)

        If Form_Faire_Deviner.txt_Symb1.Text = txt_symb1.Text And Form_Faire_Deviner.txt_Symb2.Text = txt_symb2.Text And Form_Faire_Deviner.txt_Symb3.Text = txt_symb3.Text And Form_Faire_Deviner.txt_Symb4.Text = txt_symb4.Text And Form_Faire_Deviner.txt_Symb5.Text = txt_symb5.Text Then
            A_gagne()
        End If
    End Sub

    Private Sub Ajout_essai_liste_essais_prec(lst_symb As List(Of TextBox))
        rtb_essais_prec.AppendText(" ")
        For Each txt_box As TextBox In lst_symb
            If txt_box.BackColor = Color.Green Then
                rtb_essais_prec.SelectionColor = Color.Green
            ElseIf txt_box.BackColor = Color.Blue Then
                rtb_essais_prec.SelectionColor = Color.Blue
            Else
                rtb_essais_prec.SelectionColor = Color.Black
            End If
            rtb_essais_prec.AppendText(txt_box.Text)
            rtb_essais_prec.AppendText(" ")
        Next
        rtb_essais_prec.AppendText(vbCrLf)
    End Sub

    Private Sub A_gagne()
        joueur_a_gagne = True
        lbl_trouve.Visible = True
        btn_partir.Visible = True
        tmr_temps_restant.Stop()
        LesJoueurs.AjouteUnPointA(Form_Accueil.cbx_Joueur2.Text)
        LesJoueurs.AjouterNbSecondPlayer(Form_Accueil.cbx_Joueur2.Text)
        LesJoueurs.AjouterNbFirstPlayer(Form_Accueil.cbx_Joueur1.Text)
        LesJoueurs.AjouterTempsCumuleA(Form_Accueil.cbx_Joueur2.Text, temps_ecoule)
        LesJoueurs.UpdateMeilleurTemps(Form_Accueil.cbx_Joueur2.Text, temps_ecoule)
        Ajouter_Noms_Aux_Combobox_Accueil()
    End Sub

    Private Sub A_perdu()
        joueur_a_gagne = False
        LesJoueurs.AjouteUnPointA(Form_Accueil.cbx_Joueur1.Text)
        LesJoueurs.AjouterNbSecondPlayer(Form_Accueil.cbx_Joueur2.Text)
        LesJoueurs.AjouterNbFirstPlayer(Form_Accueil.cbx_Joueur1.Text)
        LesJoueurs.AjouterTempsCumuleA(Form_Accueil.cbx_Joueur2.Text, temps_ecoule)
        Ajouter_Noms_Aux_Combobox_Accueil()
    End Sub

    Private Function InList(List As List(Of String), symbole As String) As Boolean
        For Each s As String In List
            If s = symbole Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Txt_symb_Click(sender As Object, e As EventArgs) Handles txt_symb1.Click, txt_symb2.Click, txt_symb3.Click, txt_symb4.Click, txt_symb5.Click
        sender.Text = ""
        sender.BackColor = Color.White
    End Sub

    Private Sub Btn_partir_Click(sender As Object, e As EventArgs) Handles btn_partir.Click
        Me.Close()
    End Sub

    Private Sub Form_Essais_Joueur_2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmr_temps_restant.Stop()
        Form_Faire_Deviner.Close()
        Form_Accueil.inverser_joueurs()
        Form_Accueil.Show()
    End Sub

    Private Sub Ajouter_Noms_Aux_Combobox_Accueil()
        If Not Form_Accueil.cbx_Joueur1.Items.Contains(Form_Accueil.cbx_Joueur1.Text) Then
            Form_Accueil.cbx_Joueur1.Items.Add(Form_Accueil.cbx_Joueur1.Text)
        End If
        If Not Form_Accueil.cbx_Joueur2.Items.Contains(Form_Accueil.cbx_Joueur2.Text) Then
            Form_Accueil.cbx_Joueur2.Items.Add(Form_Accueil.cbx_Joueur2.Text)
        End If
        If Not Form_Accueil.cbx_Joueur1.Items.Contains(Form_Accueil.cbx_Joueur2.Text) Then
            Form_Accueil.cbx_Joueur1.Items.Add(Form_Accueil.cbx_Joueur2.Text)
        End If
        If Not Form_Accueil.cbx_Joueur2.Items.Contains(Form_Accueil.cbx_Joueur1.Text) Then
            Form_Accueil.cbx_Joueur2.Items.Add(Form_Accueil.cbx_Joueur1.Text)
        End If
    End Sub

End Class