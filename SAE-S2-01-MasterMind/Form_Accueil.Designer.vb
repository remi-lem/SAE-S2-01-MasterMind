﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Accueil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Accueil))
        Me.lbl_Joueur1 = New System.Windows.Forms.Label()
        Me.lbl_Joueur2 = New System.Windows.Forms.Label()
        Me.cbx_Joueur1 = New System.Windows.Forms.ComboBox()
        Me.cbx_Joueur2 = New System.Windows.Forms.ComboBox()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.btn_Score = New System.Windows.Forms.Button()
        Me.pic_mastermind = New System.Windows.Forms.PictureBox()
        Me.btn_modif_options = New System.Windows.Forms.Button()
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.lbl_contre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pic_mastermind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Joueur1
        '
        Me.lbl_Joueur1.AutoSize = True
        Me.lbl_Joueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur1.Location = New System.Drawing.Point(159, 49)
        Me.lbl_Joueur1.Name = "lbl_Joueur1"
        Me.lbl_Joueur1.Size = New System.Drawing.Size(66, 16)
        Me.lbl_Joueur1.TabIndex = 1
        Me.lbl_Joueur1.Text = "Joueur 1"
        '
        'lbl_Joueur2
        '
        Me.lbl_Joueur2.AutoSize = True
        Me.lbl_Joueur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur2.Location = New System.Drawing.Point(292, 49)
        Me.lbl_Joueur2.Name = "lbl_Joueur2"
        Me.lbl_Joueur2.Size = New System.Drawing.Size(66, 16)
        Me.lbl_Joueur2.TabIndex = 2
        Me.lbl_Joueur2.Text = "Joueur 2"
        '
        'cbx_Joueur1
        '
        Me.cbx_Joueur1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_Joueur1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_Joueur1.FormattingEnabled = True
        Me.cbx_Joueur1.Location = New System.Drawing.Point(111, 68)
        Me.cbx_Joueur1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Joueur1.Name = "cbx_Joueur1"
        Me.cbx_Joueur1.Size = New System.Drawing.Size(121, 24)
        Me.cbx_Joueur1.TabIndex = 1
        '
        'cbx_Joueur2
        '
        Me.cbx_Joueur2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_Joueur2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_Joueur2.FormattingEnabled = True
        Me.cbx_Joueur2.Location = New System.Drawing.Point(296, 68)
        Me.cbx_Joueur2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_Joueur2.Name = "cbx_Joueur2"
        Me.cbx_Joueur2.Size = New System.Drawing.Size(121, 24)
        Me.cbx_Joueur2.TabIndex = 2
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(15, 112)
        Me.btn_Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(121, 46)
        Me.btn_Start.TabIndex = 3
        Me.btn_Start.Text = "JOUER"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(395, 112)
        Me.btn_Quitter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(121, 46)
        Me.btn_Quitter.TabIndex = 6
        Me.btn_Quitter.Text = "QUITTER"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'btn_Score
        '
        Me.btn_Score.Location = New System.Drawing.Point(141, 112)
        Me.btn_Score.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Score.Name = "btn_Score"
        Me.btn_Score.Size = New System.Drawing.Size(121, 46)
        Me.btn_Score.TabIndex = 4
        Me.btn_Score.Text = "Tableau des scores"
        Me.btn_Score.UseVisualStyleBackColor = True
        '
        'pic_mastermind
        '
        Me.pic_mastermind.Image = Global.SAE_S2_01_MasterMind.My.Resources.Resources.logo_mastermind
        Me.pic_mastermind.Location = New System.Drawing.Point(15, 260)
        Me.pic_mastermind.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pic_mastermind.Name = "pic_mastermind"
        Me.pic_mastermind.Size = New System.Drawing.Size(136, 127)
        Me.pic_mastermind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_mastermind.TabIndex = 10
        Me.pic_mastermind.TabStop = False
        '
        'btn_modif_options
        '
        Me.btn_modif_options.Location = New System.Drawing.Point(268, 112)
        Me.btn_modif_options.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_modif_options.Name = "btn_modif_options"
        Me.btn_modif_options.Size = New System.Drawing.Size(121, 46)
        Me.btn_modif_options.TabIndex = 5
        Me.btn_modif_options.Text = "Modification des options"
        Me.btn_modif_options.UseVisualStyleBackColor = True
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titre.Location = New System.Drawing.Point(179, 11)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(162, 25)
        Me.lbl_titre.TabIndex = 0
        Me.lbl_titre.Text = "MASTER MIND"
        '
        'lbl_contre
        '
        Me.lbl_contre.AutoSize = True
        Me.lbl_contre.Location = New System.Drawing.Point(240, 71)
        Me.lbl_contre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_contre.Name = "lbl_contre"
        Me.lbl_contre.Size = New System.Drawing.Size(44, 16)
        Me.lbl_contre.TabIndex = 12
        Me.lbl_contre.Text = "contre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 393)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Bravo ! Vous avez trouver l'easter egg du jour !"
        '
        'Form_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 170)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_contre)
        Me.Controls.Add(Me.btn_modif_options)
        Me.Controls.Add(Me.pic_mastermind)
        Me.Controls.Add(Me.btn_Score)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.cbx_Joueur2)
        Me.Controls.Add(Me.cbx_Joueur1)
        Me.Controls.Add(Me.lbl_Joueur2)
        Me.Controls.Add(Me.lbl_Joueur1)
        Me.Controls.Add(Me.lbl_titre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Accueil"
        Me.Text = "Bienvenue !"
        CType(Me.pic_mastermind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Joueur1 As Label
    Friend WithEvents lbl_Joueur2 As Label
    Friend WithEvents cbx_Joueur1 As ComboBox
    Friend WithEvents cbx_Joueur2 As ComboBox
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Quitter As Button
    Friend WithEvents btn_Score As Button
    Friend WithEvents pic_mastermind As PictureBox
    Friend WithEvents btn_modif_options As Button
    Friend WithEvents lbl_titre As Label
    Friend WithEvents lbl_contre As Label
    Friend WithEvents Label1 As Label
End Class
