<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tableau_Score
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
        Me.lst_Nom = New System.Windows.Forms.ListBox()
        Me.lst_Score = New System.Windows.Forms.ListBox()
        Me.lst_BestTime = New System.Windows.Forms.ListBox()
        Me.lst_TempsCumulé = New System.Windows.Forms.ListBox()
        Me.btn_Accueil = New System.Windows.Forms.Button()
        Me.lbl_Score = New System.Windows.Forms.Label()
        Me.lbl_BestTime = New System.Windows.Forms.Label()
        Me.lbl_TempsCumulé = New System.Windows.Forms.Label()
        Me.lbl_Nom = New System.Windows.Forms.Label()
        Me.cbx_NomSelec = New System.Windows.Forms.ComboBox()
        Me.lst_SecondPlayer = New System.Windows.Forms.ListBox()
        Me.lst_FirstPLayer = New System.Windows.Forms.ListBox()
        Me.lbl_NbFoisJ1 = New System.Windows.Forms.Label()
        Me.lbl_NbFoisJ2 = New System.Windows.Forms.Label()
        Me.lbl_Récap = New System.Windows.Forms.Label()
        Me.cbx_tris = New System.Windows.Forms.ComboBox()
        Me.lbl_tris = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_Titre
        '
        Me.lbl_Titre.AutoSize = True
        Me.lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre.Location = New System.Drawing.Point(413, 30)
        Me.lbl_Titre.Name = "lbl_Titre"
        Me.lbl_Titre.Size = New System.Drawing.Size(298, 20)
        Me.lbl_Titre.TabIndex = 0
        Me.lbl_Titre.Text = "Master Mind : Tableau des Scores"
        '
        'lst_Nom
        '
        Me.lst_Nom.FormattingEnabled = True
        Me.lst_Nom.ItemHeight = 16
        Me.lst_Nom.Location = New System.Drawing.Point(112, 146)
        Me.lst_Nom.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Nom.Name = "lst_Nom"
        Me.lst_Nom.Size = New System.Drawing.Size(120, 84)
        Me.lst_Nom.TabIndex = 1
        '
        'lst_Score
        '
        Me.lst_Score.FormattingEnabled = True
        Me.lst_Score.ItemHeight = 16
        Me.lst_Score.Location = New System.Drawing.Point(355, 146)
        Me.lst_Score.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_Score.Name = "lst_Score"
        Me.lst_Score.Size = New System.Drawing.Size(120, 84)
        Me.lst_Score.TabIndex = 2
        '
        'lst_BestTime
        '
        Me.lst_BestTime.FormattingEnabled = True
        Me.lst_BestTime.ItemHeight = 16
        Me.lst_BestTime.Location = New System.Drawing.Point(592, 146)
        Me.lst_BestTime.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_BestTime.Name = "lst_BestTime"
        Me.lst_BestTime.Size = New System.Drawing.Size(120, 84)
        Me.lst_BestTime.TabIndex = 3
        '
        'lst_TempsCumulé
        '
        Me.lst_TempsCumulé.FormattingEnabled = True
        Me.lst_TempsCumulé.ItemHeight = 16
        Me.lst_TempsCumulé.Location = New System.Drawing.Point(837, 146)
        Me.lst_TempsCumulé.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_TempsCumulé.Name = "lst_TempsCumulé"
        Me.lst_TempsCumulé.Size = New System.Drawing.Size(120, 84)
        Me.lst_TempsCumulé.TabIndex = 4
        '
        'btn_Accueil
        '
        Me.btn_Accueil.Location = New System.Drawing.Point(989, 389)
        Me.btn_Accueil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Accueil.Name = "btn_Accueil"
        Me.btn_Accueil.Size = New System.Drawing.Size(124, 50)
        Me.btn_Accueil.TabIndex = 8
        Me.btn_Accueil.Text = "Accueil"
        Me.btn_Accueil.UseVisualStyleBackColor = True
        '
        'lbl_Score
        '
        Me.lbl_Score.AutoSize = True
        Me.lbl_Score.Location = New System.Drawing.Point(388, 108)
        Me.lbl_Score.Name = "lbl_Score"
        Me.lbl_Score.Size = New System.Drawing.Size(43, 16)
        Me.lbl_Score.TabIndex = 6
        Me.lbl_Score.Text = "Score"
        '
        'lbl_BestTime
        '
        Me.lbl_BestTime.AutoSize = True
        Me.lbl_BestTime.Location = New System.Drawing.Point(597, 108)
        Me.lbl_BestTime.Name = "lbl_BestTime"
        Me.lbl_BestTime.Size = New System.Drawing.Size(100, 16)
        Me.lbl_BestTime.TabIndex = 7
        Me.lbl_BestTime.Text = "Meilleur Temps"
        '
        'lbl_TempsCumulé
        '
        Me.lbl_TempsCumulé.AutoSize = True
        Me.lbl_TempsCumulé.Location = New System.Drawing.Point(845, 108)
        Me.lbl_TempsCumulé.Name = "lbl_TempsCumulé"
        Me.lbl_TempsCumulé.Size = New System.Drawing.Size(98, 16)
        Me.lbl_TempsCumulé.TabIndex = 8
        Me.lbl_TempsCumulé.Text = "Temps Cumulé"
        '
        'lbl_Nom
        '
        Me.lbl_Nom.AutoSize = True
        Me.lbl_Nom.Location = New System.Drawing.Point(140, 108)
        Me.lbl_Nom.Name = "lbl_Nom"
        Me.lbl_Nom.Size = New System.Drawing.Size(36, 16)
        Me.lbl_Nom.TabIndex = 9
        Me.lbl_Nom.Text = "Nom"
        '
        'cbx_NomSelec
        '
        Me.cbx_NomSelec.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbx_NomSelec.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_NomSelec.FormattingEnabled = True
        Me.cbx_NomSelec.Location = New System.Drawing.Point(764, 389)
        Me.cbx_NomSelec.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbx_NomSelec.Name = "cbx_NomSelec"
        Me.cbx_NomSelec.Size = New System.Drawing.Size(121, 24)
        Me.cbx_NomSelec.TabIndex = 7
        '
        'lst_SecondPlayer
        '
        Me.lst_SecondPlayer.FormattingEnabled = True
        Me.lst_SecondPlayer.ItemHeight = 16
        Me.lst_SecondPlayer.Location = New System.Drawing.Point(477, 329)
        Me.lst_SecondPlayer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_SecondPlayer.Name = "lst_SecondPlayer"
        Me.lst_SecondPlayer.Size = New System.Drawing.Size(120, 84)
        Me.lst_SecondPlayer.TabIndex = 6
        '
        'lst_FirstPLayer
        '
        Me.lst_FirstPLayer.FormattingEnabled = True
        Me.lst_FirstPLayer.ItemHeight = 16
        Me.lst_FirstPLayer.Location = New System.Drawing.Point(112, 329)
        Me.lst_FirstPLayer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lst_FirstPLayer.Name = "lst_FirstPLayer"
        Me.lst_FirstPLayer.Size = New System.Drawing.Size(120, 84)
        Me.lst_FirstPLayer.TabIndex = 5
        '
        'lbl_NbFoisJ1
        '
        Me.lbl_NbFoisJ1.AutoSize = True
        Me.lbl_NbFoisJ1.Location = New System.Drawing.Point(108, 298)
        Me.lbl_NbFoisJ1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NbFoisJ1.Name = "lbl_NbFoisJ1"
        Me.lbl_NbFoisJ1.Size = New System.Drawing.Size(217, 16)
        Me.lbl_NbFoisJ1.TabIndex = 10
        Me.lbl_NbFoisJ1.Text = "Nombre de fois en tant que joueur 1"
        '
        'lbl_NbFoisJ2
        '
        Me.lbl_NbFoisJ2.AutoSize = True
        Me.lbl_NbFoisJ2.Location = New System.Drawing.Point(473, 298)
        Me.lbl_NbFoisJ2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NbFoisJ2.Name = "lbl_NbFoisJ2"
        Me.lbl_NbFoisJ2.Size = New System.Drawing.Size(217, 16)
        Me.lbl_NbFoisJ2.TabIndex = 11
        Me.lbl_NbFoisJ2.Text = "Nombre de fois en tant que joueur 2"
        '
        'lbl_Récap
        '
        Me.lbl_Récap.AutoSize = True
        Me.lbl_Récap.Location = New System.Drawing.Point(760, 358)
        Me.lbl_Récap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Récap.Name = "lbl_Récap"
        Me.lbl_Récap.Size = New System.Drawing.Size(81, 16)
        Me.lbl_Récap.TabIndex = 12
        Me.lbl_Récap.Text = "Récapitulatif"
        '
        'cbx_tris
        '
        Me.cbx_tris.FormattingEnabled = True
        Me.cbx_tris.Location = New System.Drawing.Point(989, 298)
        Me.cbx_tris.Name = "cbx_tris"
        Me.cbx_tris.Size = New System.Drawing.Size(121, 24)
        Me.cbx_tris.TabIndex = 13
        '
        'lbl_tris
        '
        Me.lbl_tris.AutoSize = True
        Me.lbl_tris.Location = New System.Drawing.Point(1017, 258)
        Me.lbl_tris.Name = "lbl_tris"
        Me.lbl_tris.Size = New System.Drawing.Size(52, 16)
        Me.lbl_tris.TabIndex = 14
        Me.lbl_tris.Text = "Tri par :"
        '
        'Form_Tableau_Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 471)
        Me.Controls.Add(Me.lbl_tris)
        Me.Controls.Add(Me.cbx_tris)
        Me.Controls.Add(Me.lbl_Récap)
        Me.Controls.Add(Me.lbl_NbFoisJ2)
        Me.Controls.Add(Me.lbl_NbFoisJ1)
        Me.Controls.Add(Me.lst_FirstPLayer)
        Me.Controls.Add(Me.lst_SecondPlayer)
        Me.Controls.Add(Me.cbx_NomSelec)
        Me.Controls.Add(Me.lbl_Nom)
        Me.Controls.Add(Me.lbl_TempsCumulé)
        Me.Controls.Add(Me.lbl_BestTime)
        Me.Controls.Add(Me.lbl_Score)
        Me.Controls.Add(Me.btn_Accueil)
        Me.Controls.Add(Me.lst_TempsCumulé)
        Me.Controls.Add(Me.lst_BestTime)
        Me.Controls.Add(Me.lst_Score)
        Me.Controls.Add(Me.lst_Nom)
        Me.Controls.Add(Me.lbl_Titre)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_Tableau_Score"
        Me.Text = "Tableau des scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_Titre As Label
    Friend WithEvents lst_Nom As ListBox
    Friend WithEvents lst_Score As ListBox
    Friend WithEvents lst_BestTime As ListBox
    Friend WithEvents lst_TempsCumulé As ListBox
    Friend WithEvents btn_Accueil As Button
    Friend WithEvents lbl_Score As Label
    Friend WithEvents lbl_BestTime As Label
    Friend WithEvents lbl_TempsCumulé As Label
    Friend WithEvents lbl_Nom As Label
    Friend WithEvents cbx_NomSelec As ComboBox
    Friend WithEvents lst_SecondPlayer As ListBox
    Friend WithEvents lst_FirstPLayer As ListBox
    Friend WithEvents lbl_NbFoisJ1 As Label
    Friend WithEvents lbl_NbFoisJ2 As Label
    Friend WithEvents lbl_Récap As Label
    Friend WithEvents cbx_tris As ComboBox
    Friend WithEvents lbl_tris As Label
End Class
