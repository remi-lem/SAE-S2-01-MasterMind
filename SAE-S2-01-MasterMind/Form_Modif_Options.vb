Public Class Form_Modif_Options

    Private Sub Change_Label_Temps()
        lbl_temps.Text = "Temps : " & GetTemps().Minutes & ":" & GetTemps().Seconds
        If (GetTemps().Seconds < 10) Then
            lbl_temps.Text = lbl_temps.Text & "0"
        End If
    End Sub

    Private Sub Form_Modif_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_symbole1.Text = "Symbole 1 : " & GetSymbDef1()
        lbl_symbole2.Text = "Symbole 2 : " & GetSymbDef2()
        lbl_symbole3.Text = "Symbole 3 : " & GetSymbDef3()
        lbl_symbole5.Text = "Symbole 5 : " & GetSymbDef4()
        lbl_symbole4.Text = "Symbole 4 : " & GetSymbDef5()
        Change_Label_Temps()
    End Sub
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
            If rep.Length = 1 Then
                Symboles.SetSymbDef1(rep)
                lbl_symbole1.Text = "Symbole 1 : " & GetSymbDef1()
            Else
                MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Private Sub Btn_modif_symb_2_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_2.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef2)
        If Not rep = "" Then
            If rep.Length = 1 Then
                Symboles.SetSymbDef2(rep)
                lbl_symbole2.Text = "Symbole 2 : " & GetSymbDef2()
            Else
                MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly)
            End If

        End If
    End Sub
    Private Sub Btn_modif_symb_3_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_3.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef3)
        If Not rep = "" Then
            If rep.Length = 1 Then
                Symboles.SetSymbDef3(rep)
                lbl_symbole3.Text = "Symbole 3 : " & GetSymbDef3()
            Else
                MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Private Sub Btn_modif_symb_4_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_4.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef4)
        If Not rep = "" Then
            If rep.Length = 1 Then
                Symboles.SetSymbDef4(rep)
                lbl_symbole4.Text = "Symbole 4 : " & GetSymbDef4()
            Else
                MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub
    Private Sub Btn_modif_symb_5_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_5.Click
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbDef5)
        If Not rep = "" Then
            If rep.Length = 1 Then
                Symboles.SetSymbDef5(rep)
                lbl_symbole5.Text = "Symbole 5 : " & GetSymbDef5()
            Else
                MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    Private Sub Btn_modif_temps_Click(sender As Object, e As EventArgs) Handles Btn_modif_temps.Click
        MsgBox("Vous allez devoir entrer les minutes puis les secondes" & vbCrLf & "Pour ne mettre aucune minute ou seconde, mettre '0'", vbOKOnly)
        Dim min As Integer = InputBox("Nombre de minutes : ", "Changement du temps (1/2)", LeTemps.GetMinutes())
        Dim sec As Integer = InputBox("Nombre de secondes : ", "Changement du temps (2/2)", LeTemps.GetSecondes())
        If min = 0 And sec = 0 Then
            MsgBox("0 secondes ? Cela ne fait pas beaucoup...", vbOKOnly, "Erreur")
        Else
            Dim temps As New TimeSpan(0, min, sec)
            LeTemps.UpdateTemps(temps)
            Change_Label_Temps()
        End If
    End Sub
End Class