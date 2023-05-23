Public Class Form_Modif_Options
    Private IsLoaded As Boolean = False

    Private Sub Change_Label_Temps()
        lbl_temps.Text = "Temps : " & GetTemps().Minutes & ":" & GetTemps().Seconds
        If (GetTemps().Seconds < 10) Then
            lbl_temps.Text = lbl_temps.Text & "0"
        End If
    End Sub

    Private Sub Form_Modif_Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_symbole1.Text = "Symbole 1 : " & Symboles.GetSymbole(0)
        lbl_symbole2.Text = "Symbole 2 : " & Symboles.GetSymbole(1)
        lbl_symbole3.Text = "Symbole 3 : " & Symboles.GetSymbole(2)
        lbl_symbole4.Text = "Symbole 4 : " & Symboles.GetSymbole(3)
        lbl_symbole5.Text = "Symbole 5 : " & Symboles.GetSymbole(4)

        BtnColorPlace.BackColor = GetPresentPlace()
        BtnColorPresent.BackColor = GetPresent()

        nud_propositions.Value = Get_Nb_Prop()
        Change_Label_Temps()
        IsLoaded = True
    End Sub
    Private Sub Form_Modif_Options_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form_Accueil.Show()
    End Sub

    Private Sub Btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
    End Sub

    Private Sub Traitement_Caractere(IndexCharDeBase As Integer)
        Dim rep As String = InputBox("Nouveau Symbole : ", "Changement de symbole", Symboles.GetSymbole(IndexCharDeBase))
        If rep = "" Then
            MsgBox("Merci de rentrer un charactère", vbOKOnly, "Erreur")
        ElseIf Not rep.Length = 1 Then
            MsgBox("Le symbole renseigné est trop long. Il ne doit pas dépasser un caractère.", MsgBoxStyle.OkOnly, "Erreur")
        ElseIf AlreadyUsed(IndexCharDeBase, rep) Then
            MsgBox("Le symbole renseigné est déjà uilisé. Merci d'en choisir un autre.", MsgBoxStyle.OkOnly, "Erreur")
        Else
            Symboles.SetSymbole(IndexCharDeBase, rep)
        End If
    End Sub

    Private Sub Btn_modif_symb_1_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_1.Click
        Traitement_Caractere(0)
        lbl_symbole1.Text = "Symbole 1 : " & Symboles.GetSymbole(0)
    End Sub
    Private Sub Btn_modif_symb_2_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_2.Click
        Traitement_Caractere(1)
        lbl_symbole2.Text = "Symbole 2 : " & Symboles.GetSymbole(1)
    End Sub
    Private Sub Btn_modif_symb_3_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_3.Click
        Traitement_Caractere(2)
        lbl_symbole3.Text = "Symbole 3 : " & Symboles.GetSymbole(2)
    End Sub
    Private Sub Btn_modif_symb_4_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_4.Click
        Traitement_Caractere(3)
        lbl_symbole4.Text = "Symbole 4 : " & Symboles.GetSymbole(3)
    End Sub
    Private Sub Btn_modif_symb_5_Click(sender As Object, e As EventArgs) Handles btn_modif_symb_5.Click
        Traitement_Caractere(4)
        lbl_symbole5.Text = "Symbole 5 : " & Symboles.GetSymbole(4)
    End Sub

    Private Sub Btn_modif_temps_Click(sender As Object, e As EventArgs) Handles Btn_modif_temps.Click
        Dim message As String
        message = "Vous allez devoir entrer les minutes puis les secondes"
        message &= vbCrLf & "Pour ne mettre aucune minute ou seconde, mettre '0'"
        MsgBox(message, vbOKOnly, "Changement du temps")
        Dim min As Integer = InputBox("Nombre de minutes : ", "Changement du temps (1/2)", LeTemps.GetMinutes())
        Dim sec As Integer = InputBox("Nombre de secondes : ", "Changement du temps (2/2)", LeTemps.GetSecondes())
        If min = 0 And sec = 0 Then
            MsgBox("0 secondes ? Cela ne fait pas beaucoup...", vbOKOnly, "Erreur")
        ElseIf min < 0 Xor sec < 0 Then
            MsgBox("Oula, un temps négatif ? Cela n'existe pas", vbOKOnly, "Erreur")
        Else
            Dim temps As New TimeSpan(0, min, sec)
            LeTemps.UpdateTemps(temps)
            Change_Label_Temps()
        End If
    End Sub

    Private Sub Nud_propositions_ValueChanged(sender As Object, e As EventArgs) Handles nud_propositions.ValueChanged
        If IsLoaded Then
            Set_Nb_Prop(nud_propositions.Value)
        End If
    End Sub

    Private Sub BtnColorPresent_Click(sender As Object, e As EventArgs) Handles BtnColorPresent.Click
        Dim nouvelleCouleur As New ColorDialog()
        nouvelleCouleur.Color = GetPresent()
        If nouvelleCouleur.ShowDialog() = DialogResult.OK Then
            If Not nouvelleCouleur.Color = GetPresentPlace() Then
                SetPresent(nouvelleCouleur.Color)
                BtnColorPresent.BackColor = nouvelleCouleur.Color
            Else
                MsgBox("impossible de mettre la même couleur pour les deux")
            End If
        End If
    End Sub

    Private Sub BtnColorPlace_Click(sender As Object, e As EventArgs) Handles BtnColorPlace.Click
        Dim nouvelleCouleur As New ColorDialog()
        nouvelleCouleur.Color = GetPresent()
        If nouvelleCouleur.ShowDialog() = DialogResult.OK Then
            If Not nouvelleCouleur.Color = GetPresent() Then
                SetPresentPlace(nouvelleCouleur.Color)
                BtnColorPlace.BackColor = nouvelleCouleur.Color
            Else
                MsgBox("impossible de mettre la même couleur pour les deux")
            End If

        End If
    End Sub

    Private Sub Btn_modif_chemin_fic_svg_Click(sender As Object, e As EventArgs) Handles Btn_modif_chemin_fic_svg.Click
        Gestion_fichier.EcritureDuFichier()
        Dim ancien_chemin As String = GetChemin()
        Dim repChemin As String = InputBox("Nouveau chemin : ", "Changement du chemin", LeFichier.GetChemin())
        If repChemin = "" Then
            LeFichier.SetChemin(ancien_chemin)
        Else
            LeFichier.SetChemin(repChemin)
        End If
        LesJoueurs.FlushJoueurs()
        Gestion_fichier.LectureDuFichier()
        Form_Accueil.Init_Joueurs_Acc()
    End Sub
End Class