Public Class Form_Modif_Options
    Private Sub Form_Modif_Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub

    Private Sub Btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
    End Sub

    ' TODO : VERIFIER QUE LE NOUVEAU SYMBOLE N'EST PAS UTILISE DANS LES *AUTRES* SYMBOLES

    Private Sub Btn_modif_symb_1_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_1.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef1)
        If Not rep = "" Then
            Symboles.setSymbDef1(rep)
        End If
    End Sub
    Private Sub Btn_modif_symb_2_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_2.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef2)
        If Not rep = "" Then
            Symboles.setSymbDef2(rep)
        End If
    End Sub
    Private Sub Btn_modif_symb_3_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_3.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef3)
        If Not rep = "" Then
            Symboles.setSymbDef3(rep)
        End If
    End Sub
    Private Sub Btn_modif_symb_4_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_4.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef4)
        If Not rep = "" Then
            Symboles.setSymbDef4(rep)
        End If
    End Sub
    Private Sub Btn_modif_symb_5_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_5.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef5)
        If (Not rep = "") Then
            Symboles.setSymbDef5(rep)
        End If
    End Sub

    Private Sub Form_Modif_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class