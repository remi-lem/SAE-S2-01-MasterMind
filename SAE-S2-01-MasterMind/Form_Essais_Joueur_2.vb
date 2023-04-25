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


    Private Sub Form_Essais_Joueur_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nb_coups_restants = MAX_NB_COUP_RESTANTS
        temps_restant = New TimeSpan(MAX_TEMPS_COUP.Ticks)

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
            Me.Close()
        Else
            Me.Text = "Il vous reste " & nb_coups_restants & " coups"
            lbl_coups_restants.Text = nb_coups_restants & " coups restants"
        End If

    End Sub

    Private Sub recalc_temps_restant()
        lbl_temps_restant.Text = temps_restant.Minutes & " minute et " & vbCrLf & temps_restant.Seconds & " secondes restantes"
    End Sub

    Private Sub tmr_temps_restant_Tick(sender As Object, e As EventArgs) Handles tmr_temps_restant.Tick
        If temps_restant.TotalSeconds <= 0 Then
            tmr_temps_restant.Stop()
            MsgBox("temps écoulé !")
            'TODO
            Me.Close()
        Else
            temps_restant = temps_restant.Subtract(UNE_SECONDE)
        End If
        recalc_temps_restant()
    End Sub

    Private Sub txtSymb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_symb1.KeyPress, txt_symb2.KeyPress, txt_symb3.KeyPress, txt_symb4.KeyPress, txt_symb5.KeyPress
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

        End If
    End Sub

    Private Sub verif_proposition()
        Dim prop As String = txt_symb1.Text & " " & txt_symb2.Text & " " & txt_symb3.Text & " " & txt_symb4.Text & " " & txt_symb5.Text
        lstbx_coups_prec.Items.Add(prop)
        ' TODO
        ' ANTOINE VIENS ICI
    End Sub
End Class