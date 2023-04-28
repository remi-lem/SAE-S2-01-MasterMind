Public Class Form_Essais_Joueur_2

    Private nb_coups_restants As Integer
    Private temps_restant As New TimeSpan()

    Private Const MAX_NB_COUP_RESTANTS As Integer = 15
    Private ReadOnly MAX_TEMPS_COUP As New TimeSpan(0, 1, 30)

    Private ReadOnly UNE_SECONDE As New TimeSpan(0, 0, 1)
    ' optimisation possible : mettre Const ou truc qui y ressemble

    Dim symbParDefaut1 As String = "#"
    Dim symbParDefaut2 As String = "$"
    Dim symbParDefaut3 As String = "£"
    Dim symbParDefaut4 As String = "%"
    Dim symbParDefaut5 As String = "@"

    Dim symbParDefaut As List(Of String) = New List(Of String) From {symbParDefaut1, symbParDefaut2, symbParDefaut3, symbParDefaut4, symbParDefaut5}
    ' TODO mettre en commun

    Private joueur_a_gagne As Boolean = False

    Private Sub Form_Essais_Joueur_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nb_coups_restants = MAX_NB_COUP_RESTANTS
        temps_restant = New TimeSpan(0, 0, 0)

        'If DEBUG_MODE Then
        'temps_restant = New TimeSpan(UNE_SECONDE.Ticks)
        'End If

        tmr_temps_restant.Start()

        init_char_jouables()
        recalc_coups_restants()
        recalc_temps_restant()
    End Sub

    Private Sub recalc_coups_restants()
        If nb_coups_restants <= 0 Then
            MsgBox(Form_Accueil.cbx_Joueur2.Text & " n'a pas trouvé le pattern de " & Form_Accueil.cbx_Joueur1.Text, vbOKOnly, "Perdu !")
            a_perdu()
            Me.Close()

        Else
            Me.Text = "Il vous reste " & nb_coups_restants & " coups"
            lbl_coups_restants.Text = nb_coups_restants & " coups restants"
        End If

    End Sub

    Private Sub recalc_temps_restant()
        lbl_temps_restant.Text = temps_restant.Minutes & " minute et " & vbCrLf & temps_restant.Seconds & " secondes écoulées" & vbCrLf & "Max : " & MAX_TEMPS_COUP.Minutes & ":" & MAX_TEMPS_COUP.Seconds
    End Sub

    Private Sub tmr_temps_restant_Tick(sender As Object, e As EventArgs) Handles tmr_temps_restant.Tick
        If temps_restant.TotalSeconds >= MAX_TEMPS_COUP.TotalSeconds Then
            tmr_temps_restant.Stop()
            MsgBox("temps écoulé !")
            a_perdu()
            Me.Close()
        Else
            temps_restant = temps_restant.Add(UNE_SECONDE)
        End If
        recalc_temps_restant()
    End Sub

    Private Sub txtSymb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_symb1.KeyPress, txt_symb2.KeyPress, txt_symb3.KeyPress, txt_symb4.KeyPress, txt_symb5.KeyPress
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

    Private Sub init_char_jouables()
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

    Private Sub btn_guess_Click(sender As Object, e As EventArgs) Handles btn_guess.Click
        If txt_symb1.Text = "" Or txt_symb2.Text = "" Or txt_symb3.Text = "" Or txt_symb4.Text = "" Or txt_symb5.Text = "" Then
            MsgBox("Merci de remplir tous les caractères")
        Else
            verif_proposition()
            nb_coups_restants -= 1
            recalc_coups_restants()
            If Not joueur_a_gagne Then
                txt_symb1.Focus()
            Else
                btn_partir.Focus()
            End If
        End If
    End Sub

    Private Sub verif_proposition()
        Dim symbChoisi As List(Of String) = Form_Faire_Deviner.get_choisi()
        Dim lst_symb As List(Of TextBox) = New List(Of TextBox) From {txt_symb1, txt_symb2, txt_symb3, txt_symb4, txt_symb5}

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

        If Form_Faire_Deviner.txt_Symb1.Text = txt_symb1.Text And Form_Faire_Deviner.txt_Symb2.Text = txt_symb2.Text And Form_Faire_Deviner.txt_Symb3.Text = txt_symb3.Text And Form_Faire_Deviner.txt_Symb4.Text = txt_symb4.Text And Form_Faire_Deviner.txt_Symb5.Text = txt_symb5.Text Then
            a_gagner()
        End If
    End Sub

    Private Sub a_gagner()
        joueur_a_gagne = True
        lbl_trouve.Visible = True
        btn_partir.Visible = True
        tmr_temps_restant.Stop()
        Personne.AjouteUnPointA(Form_Accueil.cbx_Joueur2.Text)
        Personne.ajouternBSecondPlayer(Form_Accueil.cbx_Joueur2.Text)
        Personne.ajouternBFirstPlayer(Form_Accueil.cbx_Joueur1.Text)
    End Sub

    Private Sub a_perdu()
        joueur_a_gagne = False
        Personne.AjouteUnPointA(Form_Accueil.cbx_Joueur1.Text)
    End Sub

    Private Function InList(List As List(Of String), symbole As String) As Boolean
        For Each s As String In List
            If s = symbole Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub txt_symb_Click(sender As Object, e As EventArgs) Handles txt_symb1.Click, txt_symb2.Click, txt_symb3.Click, txt_symb4.Click, txt_symb5.Click
        sender.Text = ""
        sender.BackColor = Color.White
    End Sub

    Private Sub btn_partir_Click(sender As Object, e As EventArgs) Handles btn_partir.Click
        Me.Close()
    End Sub

    Private Sub Form_Essais_Joueur_2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        tmr_temps_restant.Stop() ' utile ?
        Form_Faire_Deviner.Close()
        Form_Accueil.inverser_joueurs()
        Form_Accueil.Show()
    End Sub

End Class