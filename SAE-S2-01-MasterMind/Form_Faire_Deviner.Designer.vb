<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Faire_Deviner
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_Faire_Deviner))
        Me.txt_Symb5 = New System.Windows.Forms.TextBox()
        Me.txt_Symb4 = New System.Windows.Forms.TextBox()
        Me.txt_Symb3 = New System.Windows.Forms.TextBox()
        Me.txt_Symb2 = New System.Windows.Forms.TextBox()
        Me.txt_Symb1 = New System.Windows.Forms.TextBox()
        Me.btn_Ok = New System.Windows.Forms.Button()
        Me.lbl_Titre = New System.Windows.Forms.Label()
        Me.lbl_CarJouables = New System.Windows.Forms.Label()
        Me.lbl_CarJouables2 = New System.Windows.Forms.Label()
        Me.lbl_only_j1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txt_Symb5
        '
        Me.txt_Symb5.Location = New System.Drawing.Point(234, 68)
        Me.txt_Symb5.MaxLength = 1
        Me.txt_Symb5.Name = "txt_Symb5"
        Me.txt_Symb5.Size = New System.Drawing.Size(48, 22)
        Me.txt_Symb5.TabIndex = 5
        Me.txt_Symb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Symb4
        '
        Me.txt_Symb4.Location = New System.Drawing.Point(178, 68)
        Me.txt_Symb4.MaxLength = 1
        Me.txt_Symb4.Name = "txt_Symb4"
        Me.txt_Symb4.Size = New System.Drawing.Size(48, 22)
        Me.txt_Symb4.TabIndex = 4
        Me.txt_Symb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Symb3
        '
        Me.txt_Symb3.Location = New System.Drawing.Point(122, 68)
        Me.txt_Symb3.MaxLength = 1
        Me.txt_Symb3.Name = "txt_Symb3"
        Me.txt_Symb3.Size = New System.Drawing.Size(48, 22)
        Me.txt_Symb3.TabIndex = 3
        Me.txt_Symb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Symb2
        '
        Me.txt_Symb2.Location = New System.Drawing.Point(66, 68)
        Me.txt_Symb2.MaxLength = 1
        Me.txt_Symb2.Name = "txt_Symb2"
        Me.txt_Symb2.Size = New System.Drawing.Size(48, 22)
        Me.txt_Symb2.TabIndex = 2
        Me.txt_Symb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Symb1
        '
        Me.txt_Symb1.Location = New System.Drawing.Point(10, 68)
        Me.txt_Symb1.MaxLength = 1
        Me.txt_Symb1.Name = "txt_Symb1"
        Me.txt_Symb1.Size = New System.Drawing.Size(48, 22)
        Me.txt_Symb1.TabIndex = 1
        Me.txt_Symb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_Ok
        '
        Me.btn_Ok.Location = New System.Drawing.Point(290, 67)
        Me.btn_Ok.Name = "btn_Ok"
        Me.btn_Ok.Size = New System.Drawing.Size(73, 23)
        Me.btn_Ok.TabIndex = 6
        Me.btn_Ok.Text = "OK"
        Me.btn_Ok.UseVisualStyleBackColor = True
        '
        'lbl_Titre
        '
        Me.lbl_Titre.AutoSize = True
        Me.lbl_Titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titre.Location = New System.Drawing.Point(119, 9)
        Me.lbl_Titre.Name = "lbl_Titre"
        Me.lbl_Titre.Size = New System.Drawing.Size(91, 16)
        Me.lbl_Titre.TabIndex = 0
        Me.lbl_Titre.Text = "Master Mind"
        '
        'lbl_CarJouables
        '
        Me.lbl_CarJouables.AutoSize = True
        Me.lbl_CarJouables.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CarJouables.Location = New System.Drawing.Point(175, 118)
        Me.lbl_CarJouables.Name = "lbl_CarJouables"
        Me.lbl_CarJouables.Size = New System.Drawing.Size(155, 16)
        Me.lbl_CarJouables.TabIndex = 7
        Me.lbl_CarJouables.Text = "Caractères possibles"
        '
        'lbl_CarJouables2
        '
        Me.lbl_CarJouables2.AutoSize = True
        Me.lbl_CarJouables2.Location = New System.Drawing.Point(175, 150)
        Me.lbl_CarJouables2.Name = "lbl_CarJouables2"
        Me.lbl_CarJouables2.Size = New System.Drawing.Size(108, 16)
        Me.lbl_CarJouables2.TabIndex = 8
        Me.lbl_CarJouables2.Text = "ici les caracteres"
        '
        'lbl_only_j1
        '
        Me.lbl_only_j1.AutoSize = True
        Me.lbl_only_j1.Location = New System.Drawing.Point(25, 36)
        Me.lbl_only_j1.Name = "lbl_only_j1"
        Me.lbl_only_j1.Size = New System.Drawing.Size(297, 16)
        Me.lbl_only_j1.TabIndex = 9
        Me.lbl_only_j1.Text = "ATTENTION : seul le joueur 1 doit voir cet écran !"
        '
        'Form_Faire_Deviner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 197)
        Me.Controls.Add(Me.lbl_only_j1)
        Me.Controls.Add(Me.lbl_CarJouables2)
        Me.Controls.Add(Me.lbl_CarJouables)
        Me.Controls.Add(Me.lbl_Titre)
        Me.Controls.Add(Me.btn_Ok)
        Me.Controls.Add(Me.txt_Symb1)
        Me.Controls.Add(Me.txt_Symb2)
        Me.Controls.Add(Me.txt_Symb3)
        Me.Controls.Add(Me.txt_Symb4)
        Me.Controls.Add(Me.txt_Symb5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form_Faire_Deviner"
        Me.Text = "Pattern à deviner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_Symb5 As TextBox
    Friend WithEvents txt_Symb4 As TextBox
    Friend WithEvents txt_Symb3 As TextBox
    Friend WithEvents txt_Symb2 As TextBox
    Friend WithEvents txt_Symb1 As TextBox
    Friend WithEvents btn_Ok As Button
    Friend WithEvents lbl_Titre As Label
    Friend WithEvents lbl_CarJouables As Label
    Friend WithEvents lbl_CarJouables2 As Label
    Friend WithEvents lbl_only_j1 As Label
End Class
