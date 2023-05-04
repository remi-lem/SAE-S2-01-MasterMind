Public Class Form_Faire_Deviner
    Private Sub TxtSymb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Symb1.KeyPress, txt_Symb2.KeyPress, txt_Symb3.KeyPress, txt_Symb4.KeyPress, txt_Symb5.KeyPress
        sender.Text = ""

        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If e.KeyChar <> Symboles.GetSymbole(0) And e.KeyChar <> Symboles.GetSymbole(1) And e.KeyChar <> Symboles.GetSymbole(2) And e.KeyChar <> Symboles.GetSymbole(3) And e.KeyChar <> Symboles.GetSymbole(4) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init_char_jouables()
        lbl_only_j1.Text = "ATTENTION : seul " & Form_Accueil.cbx_Joueur1.Text & " doit voir cet écran !"

        If DEBUG_MODE Then
            txt_Symb1.Text = Symboles.GetSymbole(0)
            txt_Symb2.Text = Symboles.GetSymbole(1)
            txt_Symb3.Text = Symboles.GetSymbole(2)
            txt_Symb4.Text = Symboles.GetSymbole(3)
            txt_Symb5.Text = Symboles.GetSymbole(4)
        End If
    End Sub

    Private Sub Init_char_jouables()
        Dim str_char_jouables As String = ""
        Dim first As Boolean = True
        For Each charJouable As String In {Symboles.GetSymbole(0), Symboles.GetSymbole(1), Symboles.GetSymbole(2), Symboles.GetSymbole(3), Symboles.GetSymbole(4)}
            If Not first Then
                str_char_jouables += " "
            Else
                first = False
            End If
            str_char_jouables += charJouable
        Next
        lbl_CarJouables2.Text = str_char_jouables
    End Sub


    Private Sub Btn_Ok_Click(sender As Object, e As EventArgs) Handles btn_Ok.Click
        If txt_Symb1.Text = "" Or txt_Symb2.Text = "" Or txt_Symb3.Text = "" Or txt_Symb4.Text = "" Or txt_Symb5.Text = "" Then
            MsgBox("Merci de remplir tous les caractères")
        Else
            Me.Hide()
            Form_Essais_Joueur_2.Show()
        End If
    End Sub

    Private Sub Txt_Symb_Click(sender As Object, e As EventArgs) Handles txt_Symb1.Click, txt_Symb2.Click, txt_Symb3.Click, txt_Symb4.Click, txt_Symb5.Click
        sender.Text = ""
    End Sub

    Private Sub Form_Faire_Deviner_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub

    Public Function Get_choisi() As List(Of String)
        Dim symbChoisi As New List(Of String) From {txt_Symb1.Text, txt_Symb2.Text, txt_Symb3.Text, txt_Symb4.Text, txt_Symb5.Text}
        Return symbChoisi
    End Function

End Class
