Public Class Form_Faire_Deviner

    Dim symbParDefaut1 As String = "#"
    Dim symbParDefaut2 As String = "$"
    Dim symbParDefaut3 As String = "£"
    Dim symbParDefaut4 As String = "%"
    Dim symbParDefaut5 As String = "@"

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
        lbl_CarJouables2.Text = symbParDefaut1 & symbParDefaut2 & symbParDefaut3 & symbParDefaut4 & symbParDefaut5
    End Sub

    Private Sub lbl_CarJouables_Click(sender As Object, e As EventArgs) Handles lbl_CarJouables.Click

    End Sub
End Class
