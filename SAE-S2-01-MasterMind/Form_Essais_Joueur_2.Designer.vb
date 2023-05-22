<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Essais_Joueur_2
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Essais_Joueur_2))
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
        Me.lbl_temps_ecoule = New System.Windows.Forms.Label()
        Me.lbl_trouve = New System.Windows.Forms.Label()
        Me.btn_partir = New System.Windows.Forms.Button()
        Me.rtb_essais_prec = New System.Windows.Forms.RichTextBox()
        Me.Btn_abandon = New System.Windows.Forms.Button()
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
        Me.txt_symb1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_symb1.MaxLength = 1
        Me.txt_symb1.Name = "txt_symb1"
        Me.txt_symb1.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb1.TabIndex = 1
        Me.txt_symb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb2
        '
        Me.txt_symb2.Location = New System.Drawing.Point(64, 57)
        Me.txt_symb2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_symb2.MaxLength = 1
        Me.txt_symb2.Name = "txt_symb2"
        Me.txt_symb2.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb2.TabIndex = 2
        Me.txt_symb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb3
        '
        Me.txt_symb3.Location = New System.Drawing.Point(115, 57)
        Me.txt_symb3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_symb3.MaxLength = 1
        Me.txt_symb3.Name = "txt_symb3"
        Me.txt_symb3.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb3.TabIndex = 3
        Me.txt_symb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb4
        '
        Me.txt_symb4.Location = New System.Drawing.Point(165, 57)
        Me.txt_symb4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_symb4.MaxLength = 1
        Me.txt_symb4.Name = "txt_symb4"
        Me.txt_symb4.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb4.TabIndex = 4
        Me.txt_symb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_symb5
        '
        Me.txt_symb5.Location = New System.Drawing.Point(217, 57)
        Me.txt_symb5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_symb5.MaxLength = 1
        Me.txt_symb5.Name = "txt_symb5"
        Me.txt_symb5.Size = New System.Drawing.Size(45, 22)
        Me.txt_symb5.TabIndex = 5
        Me.txt_symb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_guess
        '
        Me.btn_guess.Location = New System.Drawing.Point(268, 57)
        Me.btn_guess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.lbl_code_couleur.Location = New System.Drawing.Point(213, 102)
        Me.lbl_code_couleur.Name = "lbl_code_couleur"
        Me.lbl_code_couleur.Size = New System.Drawing.Size(101, 16)
        Me.lbl_code_couleur.TabIndex = 8
        Me.lbl_code_couleur.Text = "Code Couleur"
        '
        'lbl_char_jouables_titre
        '
        Me.lbl_char_jouables_titre.AutoSize = True
        Me.lbl_char_jouables_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_char_jouables_titre.Location = New System.Drawing.Point(217, 190)
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
        Me.lbl_code_present.ForeColor = System.Drawing.Color.Black
        Me.lbl_code_present.Location = New System.Drawing.Point(217, 138)
        Me.lbl_code_present.Name = "lbl_code_present"
        Me.lbl_code_present.Size = New System.Drawing.Size(53, 16)
        Me.lbl_code_present.TabIndex = 12
        Me.lbl_code_present.Text = "Présent"
        '
        'lbl_code_present_bien_place
        '
        Me.lbl_code_present_bien_place.AutoSize = True
        Me.lbl_code_present_bien_place.ForeColor = System.Drawing.Color.Black
        Me.lbl_code_present_bien_place.Location = New System.Drawing.Point(217, 154)
        Me.lbl_code_present_bien_place.Name = "lbl_code_present_bien_place"
        Me.lbl_code_present_bien_place.Size = New System.Drawing.Size(133, 16)
        Me.lbl_code_present_bien_place.TabIndex = 13
        Me.lbl_code_present_bien_place.Text = "Présent et bien placé"
        '
        'lbl_coups_restants
        '
        Me.lbl_coups_restants.AutoSize = True
        Me.lbl_coups_restants.Location = New System.Drawing.Point(217, 263)
        Me.lbl_coups_restants.Name = "lbl_coups_restants"
        Me.lbl_coups_restants.Size = New System.Drawing.Size(110, 16)
        Me.lbl_coups_restants.TabIndex = 14
        Me.lbl_coups_restants.Text = "coups restants ici"
        '
        'lbl_temps_ecoule
        '
        Me.lbl_temps_ecoule.AutoSize = True
        Me.lbl_temps_ecoule.Location = New System.Drawing.Point(217, 294)
        Me.lbl_temps_ecoule.Name = "lbl_temps_ecoule"
        Me.lbl_temps_ecoule.Size = New System.Drawing.Size(104, 16)
        Me.lbl_temps_ecoule.TabIndex = 15
        Me.lbl_temps_ecoule.Text = "temps ecoulé ici"
        '
        'lbl_trouve
        '
        Me.lbl_trouve.AutoSize = True
        Me.lbl_trouve.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_trouve.Location = New System.Drawing.Point(187, 341)
        Me.lbl_trouve.Name = "lbl_trouve"
        Me.lbl_trouve.Size = New System.Drawing.Size(102, 29)
        Me.lbl_trouve.TabIndex = 17
        Me.lbl_trouve.Text = "Trouvé!"
        Me.lbl_trouve.Visible = False
        '
        'btn_partir
        '
        Me.btn_partir.Location = New System.Drawing.Point(295, 382)
        Me.btn_partir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_partir.Name = "btn_partir"
        Me.btn_partir.Size = New System.Drawing.Size(75, 23)
        Me.btn_partir.TabIndex = 18
        Me.btn_partir.Text = "Partir"
        Me.btn_partir.UseVisualStyleBackColor = True
        Me.btn_partir.Visible = False
        '
        'rtb_essais_prec
        '
        Me.rtb_essais_prec.Font = New System.Drawing.Font("Cascadia Mono", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_essais_prec.Location = New System.Drawing.Point(16, 129)
        Me.rtb_essais_prec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rtb_essais_prec.Name = "rtb_essais_prec"
        Me.rtb_essais_prec.ReadOnly = True
        Me.rtb_essais_prec.ShortcutsEnabled = False
        Me.rtb_essais_prec.Size = New System.Drawing.Size(165, 262)
        Me.rtb_essais_prec.TabIndex = 19
        Me.rtb_essais_prec.TabStop = False
        Me.rtb_essais_prec.Text = ""
        Me.rtb_essais_prec.WordWrap = False
        '
        'Btn_abandon
        '
        Me.Btn_abandon.Location = New System.Drawing.Point(399, 478)
        Me.Btn_abandon.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_abandon.Name = "Btn_abandon"
        Me.Btn_abandon.Size = New System.Drawing.Size(149, 32)
        Me.Btn_abandon.TabIndex = 20
        Me.Btn_abandon.Text = "Abandonner"
        Me.Btn_abandon.UseVisualStyleBackColor = True
        '
        'Form_Essais_Joueur_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 426)
        Me.Controls.Add(Me.Btn_abandon)
        Me.Controls.Add(Me.rtb_essais_prec)
        Me.Controls.Add(Me.btn_partir)
        Me.Controls.Add(Me.lbl_trouve)
        Me.Controls.Add(Me.lbl_temps_ecoule)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
    Friend WithEvents lbl_temps_ecoule As Label
    Friend WithEvents lbl_trouve As Label
    Friend WithEvents btn_partir As Button
    Friend WithEvents rtb_essais_prec As RichTextBox
    Friend WithEvents Btn_abandon As Button
End Class
