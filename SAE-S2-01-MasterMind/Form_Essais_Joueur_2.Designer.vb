﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Essais_Joueur_2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmr_temps_restant = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.txt_symb1 = New System.Windows.Forms.TextBox()
        Me.txt_symb2 = New System.Windows.Forms.TextBox()
        Me.txt_symb3 = New System.Windows.Forms.TextBox()
        Me.txt_symb4 = New System.Windows.Forms.TextBox()
        Me.txt_symb5 = New System.Windows.Forms.TextBox()
        Me.btn_guess = New System.Windows.Forms.Button()
        Me.lbl_prec_essais = New System.Windows.Forms.Label()
        Me.lbl_code_couleur = New System.Windows.Forms.Label()
        Me.lbl_char_jouables_titre = New System.Windows.Forms.Label()
        Me.lbl_char_jouables = New System.Windows.Forms.Label()
        Me.lbl_code_abs = New System.Windows.Forms.Label()
        Me.lbl_code_present = New System.Windows.Forms.Label()
        Me.lbl_code_present_bien_place = New System.Windows.Forms.Label()
        Me.lbl_coups_restants = New System.Windows.Forms.Label()
        Me.lbl_temps_restant = New System.Windows.Forms.Label()
        Me.lstbx_coups_prec = New System.Windows.Forms.ListBox()
        Me.lbl_trouve = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmr_temps_restant
        '
        Me.tmr_temps_restant.Interval = 1000
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.Location = New System.Drawing.Point(105, 9)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(91, 16)
        Me.lbl_titre.TabIndex = 0
        Me.lbl_titre.Text = "Master Mind"
        '
        'txt_symb1
        '
        Me.txt_symb1.Location = New System.Drawing.Point(13, 57)
        Me.txt_symb1.MaxLength = 1
        Me.txt_symb1.Name = "txt_symb1"
        Me.txt_symb1.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb1.TabIndex = 1
        Me.txt_symb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb2
        '
        Me.txt_symb2.Location = New System.Drawing.Point(64, 57)
        Me.txt_symb2.MaxLength = 1
        Me.txt_symb2.Name = "txt_symb2"
        Me.txt_symb2.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb2.TabIndex = 2
        Me.txt_symb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb3
        '
        Me.txt_symb3.Location = New System.Drawing.Point(115, 57)
        Me.txt_symb3.MaxLength = 1
        Me.txt_symb3.Name = "txt_symb3"
        Me.txt_symb3.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb3.TabIndex = 3
        Me.txt_symb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb4
        '
        Me.txt_symb4.Location = New System.Drawing.Point(166, 57)
        Me.txt_symb4.MaxLength = 1
        Me.txt_symb4.Name = "txt_symb4"
        Me.txt_symb4.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb4.TabIndex = 4
        Me.txt_symb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb5
        '
        Me.txt_symb5.Location = New System.Drawing.Point(217, 57)
        Me.txt_symb5.MaxLength = 1
        Me.txt_symb5.Name = "txt_symb5"
        Me.txt_symb5.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb5.TabIndex = 5
        Me.txt_symb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_guess
        '
        Me.btn_guess.Location = New System.Drawing.Point(268, 57)
        Me.btn_guess.Name = "btn_guess"
        Me.btn_guess.Size = New System.Drawing.Size(75, 23)
        Me.btn_guess.TabIndex = 6
        Me.btn_guess.Text = "Valider"
        Me.btn_guess.UseVisualStyleBackColor = True
        '
        'lbl_prec_essais
        '
        Me.lbl_prec_essais.AutoSize = True
        Me.lbl_prec_essais.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_prec_essais.Location = New System.Drawing.Point(13, 102)
        Me.lbl_prec_essais.Name = "lbl_prec_essais"
        Me.lbl_prec_essais.Size = New System.Drawing.Size(136, 16)
        Me.lbl_prec_essais.TabIndex = 7
        Me.lbl_prec_essais.Text = "Précédents essais"
        '
        'lbl_code_couleur
        '
        Me.lbl_code_couleur.AutoSize = True
        Me.lbl_code_couleur.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code_couleur.Location = New System.Drawing.Point(214, 102)
        Me.lbl_code_couleur.Name = "lbl_code_couleur"
        Me.lbl_code_couleur.Size = New System.Drawing.Size(101, 16)
        Me.lbl_code_couleur.TabIndex = 8
        Me.lbl_code_couleur.Text = "Code Couleur"
        '
        'lbl_char_jouables_titre
        '
        Me.lbl_char_jouables_titre.AutoSize = True
        Me.lbl_char_jouables_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_char_jouables_titre.Location = New System.Drawing.Point(217, 189)
        Me.lbl_char_jouables_titre.Name = "lbl_char_jouables_titre"
        Me.lbl_char_jouables_titre.Size = New System.Drawing.Size(147, 16)
        Me.lbl_char_jouables_titre.TabIndex = 9
        Me.lbl_char_jouables_titre.Text = "Caractères jouables"
        '
        'lbl_char_jouables
        '
        Me.lbl_char_jouables.AutoSize = True
        Me.lbl_char_jouables.Location = New System.Drawing.Point(217, 209)
        Me.lbl_char_jouables.Name = "lbl_char_jouables"
        Me.lbl_char_jouables.Size = New System.Drawing.Size(108, 16)
        Me.lbl_char_jouables.TabIndex = 10
        Me.lbl_char_jouables.Text = "ici les caracteres"
        '
        'lbl_code_abs
        '
        Me.lbl_code_abs.AutoSize = True
        Me.lbl_code_abs.Location = New System.Drawing.Point(217, 122)
        Me.lbl_code_abs.Name = "lbl_code_abs"
        Me.lbl_code_abs.Size = New System.Drawing.Size(49, 16)
        Me.lbl_code_abs.TabIndex = 11
        Me.lbl_code_abs.Text = "Absent"
        '
        'lbl_code_present
        '
        Me.lbl_code_present.AutoSize = True
        Me.lbl_code_present.ForeColor = System.Drawing.Color.Blue
        Me.lbl_code_present.Location = New System.Drawing.Point(217, 138)
        Me.lbl_code_present.Name = "lbl_code_present"
        Me.lbl_code_present.Size = New System.Drawing.Size(53, 16)
        Me.lbl_code_present.TabIndex = 12
        Me.lbl_code_present.Text = "Présent"
        '
        'lbl_code_present_bien_place
        '
        Me.lbl_code_present_bien_place.AutoSize = True
        Me.lbl_code_present_bien_place.ForeColor = System.Drawing.Color.Green
        Me.lbl_code_present_bien_place.Location = New System.Drawing.Point(217, 154)
        Me.lbl_code_present_bien_place.Name = "lbl_code_present_bien_place"
        Me.lbl_code_present_bien_place.Size = New System.Drawing.Size(133, 16)
        Me.lbl_code_present_bien_place.TabIndex = 13
        Me.lbl_code_present_bien_place.Text = "Présent et bien placé"
        '
        'lbl_coups_restants
        '
        Me.lbl_coups_restants.AutoSize = True
        Me.lbl_coups_restants.Location = New System.Drawing.Point(217, 264)
        Me.lbl_coups_restants.Name = "lbl_coups_restants"
        Me.lbl_coups_restants.Size = New System.Drawing.Size(110, 16)
        Me.lbl_coups_restants.TabIndex = 14
        Me.lbl_coups_restants.Text = "coups restants ici"
        '
        'lbl_temps_restant
        '
        Me.lbl_temps_restant.AutoSize = True
        Me.lbl_temps_restant.Location = New System.Drawing.Point(217, 294)
        Me.lbl_temps_restant.Name = "lbl_temps_restant"
        Me.lbl_temps_restant.Size = New System.Drawing.Size(103, 16)
        Me.lbl_temps_restant.TabIndex = 15
        Me.lbl_temps_restant.Text = "temps restant ici"
        '
        'lstbx_coups_prec
        '
        Me.lstbx_coups_prec.FormattingEnabled = True
        Me.lstbx_coups_prec.ItemHeight = 16
        Me.lstbx_coups_prec.Location = New System.Drawing.Point(16, 138)
        Me.lstbx_coups_prec.Name = "lstbx_coups_prec"
        Me.lstbx_coups_prec.Size = New System.Drawing.Size(120, 244)
        Me.lstbx_coups_prec.TabIndex = 16
        '
        'lbl_trouve
        '
        Me.lbl_trouve.AutoSize = True
        Me.lbl_trouve.Location = New System.Drawing.Point(239, 349)
        Me.lbl_trouve.Name = "lbl_trouve"
        Me.lbl_trouve.Size = New System.Drawing.Size(53, 16)
        Me.lbl_trouve.TabIndex = 17
        Me.lbl_trouve.Text = "Trouvé!"
        '
        'Form_Essais_Joueur_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 426)
        Me.Controls.Add(Me.lbl_trouve)
        Me.Controls.Add(Me.lstbx_coups_prec)
        Me.Controls.Add(Me.lbl_temps_restant)
        Me.Controls.Add(Me.lbl_coups_restants)
        Me.Controls.Add(Me.lbl_code_present_bien_place)
        Me.Controls.Add(Me.lbl_code_present)
        Me.Controls.Add(Me.lbl_code_abs)
        Me.Controls.Add(Me.lbl_char_jouables)
        Me.Controls.Add(Me.lbl_char_jouables_titre)
        Me.Controls.Add(Me.lbl_code_couleur)
        Me.Controls.Add(Me.lbl_prec_essais)
        Me.Controls.Add(Me.btn_guess)
        Me.Controls.Add(Me.txt_symb5)
        Me.Controls.Add(Me.txt_symb4)
        Me.Controls.Add(Me.txt_symb3)
        Me.Controls.Add(Me.txt_symb2)
        Me.Controls.Add(Me.txt_symb1)
        Me.Controls.Add(Me.lbl_titre)
        Me.Name = "Form_Essais_Joueur_2"
        Me.Text = "Vos essais ici"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tmr_temps_restant As Timer
    Friend WithEvents lbl_titre As Label
    Friend WithEvents txt_symb1 As TextBox
    Friend WithEvents txt_symb2 As TextBox
    Friend WithEvents txt_symb3 As TextBox
    Friend WithEvents txt_symb4 As TextBox
    Friend WithEvents txt_symb5 As TextBox
    Friend WithEvents btn_guess As Button
    Friend WithEvents lbl_prec_essais As Label
    Friend WithEvents lbl_code_couleur As Label
    Friend WithEvents lbl_char_jouables_titre As Label
    Friend WithEvents lbl_char_jouables As Label
    Friend WithEvents lbl_code_abs As Label
    Friend WithEvents lbl_code_present As Label
    Friend WithEvents lbl_code_present_bien_place As Label
    Friend WithEvents lbl_coups_restants As Label
    Friend WithEvents lbl_temps_restant As Label
    Friend WithEvents lstbx_coups_prec As ListBox
    Friend WithEvents lbl_trouve As Label
End Class
