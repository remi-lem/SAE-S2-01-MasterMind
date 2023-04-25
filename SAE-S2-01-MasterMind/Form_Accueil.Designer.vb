<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.lbl_Titre = New System.Windows.Forms.Label()
        Me.lbl_Joueur1 = New System.Windows.Forms.Label()
        Me.lbl_Joueur2 = New System.Windows.Forms.Label()
        Me.cbx_Joueur1 = New System.Windows.Forms.ComboBox()
        Me.cbx_Joueur2 = New System.Windows.Forms.ComboBox()
        Me.lbl_NomJ1 = New System.Windows.Forms.Label()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.btn_Quitter = New System.Windows.Forms.Button()
        Me.btn_Score = New System.Windows.Forms.Button()
        Me.lbl_NomJ2 = New System.Windows.Forms.Label()
        Me.pic_mastermind = New System.Windows.Forms.PictureBox()
        CType(Me.pic_mastermind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_Titre
        '
        Me.lbl_Titre.AutoSize = True
        Me.lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre.Location = New System.Drawing.Point(277, 9)
        Me.lbl_Titre.Name = "lbl_Titre"
        Me.lbl_Titre.Size = New System.Drawing.Size(162, 25)
        Me.lbl_Titre.TabIndex = 0
        Me.lbl_Titre.Text = "MASTER MIND"
        '
        'lbl_Joueur1
        '
        Me.lbl_Joueur1.AutoSize = True
        Me.lbl_Joueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur1.Location = New System.Drawing.Point(112, 86)
        Me.lbl_Joueur1.Name = "lbl_Joueur1"
        Me.lbl_Joueur1.Size = New System.Drawing.Size(66, 16)
        Me.lbl_Joueur1.TabIndex = 1
        Me.lbl_Joueur1.Text = "Joueur 1"
        '
        'lbl_Joueur2
        '
        Me.lbl_Joueur2.AutoSize = True
        Me.lbl_Joueur2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Joueur2.Location = New System.Drawing.Point(510, 86)
        Me.lbl_Joueur2.Name = "lbl_Joueur2"
        Me.lbl_Joueur2.Size = New System.Drawing.Size(66, 16)
        Me.lbl_Joueur2.TabIndex = 2
        Me.lbl_Joueur2.Text = "Joueur 2"
        '
        'cbx_Joueur1
        '
        Me.cbx_Joueur1.FormattingEnabled = True
        Me.cbx_Joueur1.Location = New System.Drawing.Point(96, 125)
        Me.cbx_Joueur1.Name = "cbx_Joueur1"
        Me.cbx_Joueur1.Size = New System.Drawing.Size(121, 24)
        Me.cbx_Joueur1.TabIndex = 3
        '
        'cbx_Joueur2
        '
        Me.cbx_Joueur2.FormattingEnabled = True
        Me.cbx_Joueur2.Location = New System.Drawing.Point(484, 125)
        Me.cbx_Joueur2.Name = "cbx_Joueur2"
        Me.cbx_Joueur2.Size = New System.Drawing.Size(121, 24)
        Me.cbx_Joueur2.TabIndex = 4
        '
        'lbl_NomJ1
        '
        Me.lbl_NomJ1.AutoSize = True
        Me.lbl_NomJ1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomJ1.Location = New System.Drawing.Point(21, 128)
        Me.lbl_NomJ1.Name = "lbl_NomJ1"
        Me.lbl_NomJ1.Size = New System.Drawing.Size(42, 16)
        Me.lbl_NomJ1.TabIndex = 5
        Me.lbl_NomJ1.Text = "Nom :"
        '
        'btn_Start
        '
        Me.btn_Start.Location = New System.Drawing.Point(298, 312)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(121, 45)
        Me.btn_Start.TabIndex = 7
        Me.btn_Start.Text = "JOUER"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'btn_Quitter
        '
        Me.btn_Quitter.Location = New System.Drawing.Point(96, 312)
        Me.btn_Quitter.Name = "btn_Quitter"
        Me.btn_Quitter.Size = New System.Drawing.Size(121, 45)
        Me.btn_Quitter.TabIndex = 6
        Me.btn_Quitter.Text = "QUITTER"
        Me.btn_Quitter.UseVisualStyleBackColor = True
        '
        'btn_Score
        '
        Me.btn_Score.Location = New System.Drawing.Point(484, 312)
        Me.btn_Score.Name = "btn_Score"
        Me.btn_Score.Size = New System.Drawing.Size(121, 45)
        Me.btn_Score.TabIndex = 8
        Me.btn_Score.Text = "Tableau des scores"
        Me.btn_Score.UseVisualStyleBackColor = True
        '
        'lbl_NomJ2
        '
        Me.lbl_NomJ2.AutoSize = True
        Me.lbl_NomJ2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NomJ2.Location = New System.Drawing.Point(418, 128)
        Me.lbl_NomJ2.Name = "lbl_NomJ2"
        Me.lbl_NomJ2.Size = New System.Drawing.Size(42, 16)
        Me.lbl_NomJ2.TabIndex = 9
        Me.lbl_NomJ2.Text = "Nom :"
        '
        'pic_mastermind
        '
        Me.pic_mastermind.Image = Global.SAE_S2_01_MasterMind.My.Resources.Resources.logo_mastermind
        Me.pic_mastermind.Location = New System.Drawing.Point(661, 13)
        Me.pic_mastermind.Name = "pic_mastermind"
        Me.pic_mastermind.Size = New System.Drawing.Size(127, 120)
        Me.pic_mastermind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_mastermind.TabIndex = 10
        Me.pic_mastermind.TabStop = False
        '
        'Form_Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pic_mastermind)
        Me.Controls.Add(Me.lbl_NomJ2)
        Me.Controls.Add(Me.btn_Score)
        Me.Controls.Add(Me.btn_Quitter)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.lbl_NomJ1)
        Me.Controls.Add(Me.cbx_Joueur2)
        Me.Controls.Add(Me.cbx_Joueur1)
        Me.Controls.Add(Me.lbl_Joueur2)
        Me.Controls.Add(Me.lbl_Joueur1)
        Me.Controls.Add(Me.lbl_Titre)
        Me.Name = "Form_Accueil"
        Me.Text = "Bienvenue !"
        CType(Me.pic_mastermind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titre As Label
    Friend WithEvents lbl_Joueur1 As Label
    Friend WithEvents lbl_Joueur2 As Label
    Friend WithEvents cbx_Joueur1 As ComboBox
    Friend WithEvents cbx_Joueur2 As ComboBox
    Friend WithEvents lbl_NomJ1 As Label
    Friend WithEvents btn_Start As Button
    Friend WithEvents btn_Quitter As Button
    Friend WithEvents btn_Score As Button
    Friend WithEvents lbl_NomJ2 As Label
    Friend WithEvents pic_mastermind As PictureBox
End Class
