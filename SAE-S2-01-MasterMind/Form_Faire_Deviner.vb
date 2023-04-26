Public Class Form_Faire_Deviner

    Dim symbParDefaut1 As String = "#"
    Dim symbParDefaut2 As String = "$"
    Dim symbParDefaut3 As String = "£"
    Dim symbParDefaut4 As String = "%"
    Dim symbParDefaut5 As String = "@"

    Dim symbParDefaut As List(Of String) = New List(Of String) From {symbParDefaut1, symbParDefaut2, symbParDefaut3, symbParDefaut4, symbParDefaut5}

    Private Sub txtSymb1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Symb1.KeyPress, txt_Symb2.KeyPress, txt_Symb3.KeyPress, txt_Symb4.KeyPress, txt_Symb5.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        e.KeyChar = UCase(e.KeyChar)
        If e.KeyChar <> symbParDefaut1 And e.KeyChar <> symbParDefaut2 And e.KeyChar <> symbParDefaut3 And e.KeyChar <> symbParDefaut4 And e.KeyChar <> symbParDefaut5 Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_char_jouables()
        lbl_only_j1.Text = "ATTENTION : seul " & Form_Accueil.cbx_Joueur1.Text & " doit voir cet écran !"

        If DEBUG_MODE Then
            txt_Symb1.Text = "#"
            txt_Symb2.Text = "#"
            txt_Symb3.Text = "#"
            txt_Symb4.Text = "#"
            txt_Symb5.Text = "#"
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
        lbl_CarJouables2.Text = str_char_jouables
    End Sub


    Private Sub btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        If txt_Symb1.Text = "" Or txt_Symb2.Text = "" Or txt_Symb3.Text = "" Or txt_Symb4.Text = "" Or txt_Symb5.Text = "" Then
            MsgBox("Merci de remplir tous les caractères")
        Else
            Me.Hide()
            Form_Essais_Joueur_2.Show()
        End If
    End Sub

    Public Function get_choisi() As List(Of String)
        Dim symbChoisi As List(Of String) = New List(Of String) From {txt_Symb1.Text, txt_Symb2.Text, txt_Symb3.Text, txt_Symb4.Text, txt_Symb5.Text}
        Return symbChoisi
    End Function
End Class
