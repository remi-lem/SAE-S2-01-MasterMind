<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Modif_Options
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
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.btn_modif_symb_1 = New System.Windows.Forms.Button()
        Me.btn_modif_symb_2 = New System.Windows.Forms.Button()
        Me.btn_modif_symb_3 = New System.Windows.Forms.Button()
        Me.btn_modif_symb_4 = New System.Windows.Forms.Button()
        Me.btn_modif_symb_5 = New System.Windows.Forms.Button()
        Me.lbl_modif_symb_def = New System.Windows.Forms.Label()
        Me.Btn_modif_temps = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_quitter
        '
        Me.btn_quitter.Location = New System.Drawing.Point(388, 15)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(103, 75)
        Me.btn_quitter.TabIndex = 0
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'btn_modif_symb_1
        '
        Me.btn_modif_symb_1.Location = New System.Drawing.Point(12, 37)
        Me.btn_modif_symb_1.Name = "btn_modif_symb_1"
        Me.btn_modif_symb_1.Size = New System.Drawing.Size(99, 23)
        Me.btn_modif_symb_1.TabIndex = 1
        Me.btn_modif_symb_1.Text = "Symbole 1"
        Me.btn_modif_symb_1.UseVisualStyleBackColor = True
        '
        'btn_modif_symb_2
        '
        Me.btn_modif_symb_2.Location = New System.Drawing.Point(12, 67)
        Me.btn_modif_symb_2.Name = "btn_modif_symb_2"
        Me.btn_modif_symb_2.Size = New System.Drawing.Size(99, 23)
        Me.btn_modif_symb_2.TabIndex = 2
        Me.btn_modif_symb_2.Text = "Symbole 2"
        Me.btn_modif_symb_2.UseVisualStyleBackColor = True
        '
        'btn_modif_symb_3
        '
        Me.btn_modif_symb_3.Location = New System.Drawing.Point(12, 97)
        Me.btn_modif_symb_3.Name = "btn_modif_symb_3"
        Me.btn_modif_symb_3.Size = New System.Drawing.Size(99, 23)
        Me.btn_modif_symb_3.TabIndex = 3
        Me.btn_modif_symb_3.Text = "Symbole 3"
        Me.btn_modif_symb_3.UseVisualStyleBackColor = True
        '
        'btn_modif_symb_4
        '
        Me.btn_modif_symb_4.Location = New System.Drawing.Point(12, 127)
        Me.btn_modif_symb_4.Name = "btn_modif_symb_4"
        Me.btn_modif_symb_4.Size = New System.Drawing.Size(99, 23)
        Me.btn_modif_symb_4.TabIndex = 4
        Me.btn_modif_symb_4.Text = "Symbole 4"
        Me.btn_modif_symb_4.UseVisualStyleBackColor = True
        '
        'btn_modif_symb_5
        '
        Me.btn_modif_symb_5.Location = New System.Drawing.Point(12, 157)
        Me.btn_modif_symb_5.Name = "btn_modif_symb_5"
        Me.btn_modif_symb_5.Size = New System.Drawing.Size(99, 23)
        Me.btn_modif_symb_5.TabIndex = 5
        Me.btn_modif_symb_5.Text = "Symbole 5"
        Me.btn_modif_symb_5.UseVisualStyleBackColor = True
        '
        'lbl_modif_symb_def
        '
        Me.lbl_modif_symb_def.AutoSize = True
        Me.lbl_modif_symb_def.Location = New System.Drawing.Point(12, 15)
        Me.lbl_modif_symb_def.Name = "lbl_modif_symb_def"
        Me.lbl_modif_symb_def.Size = New System.Drawing.Size(230, 16)
        Me.lbl_modif_symb_def.TabIndex = 6
        Me.lbl_modif_symb_def.Text = "Modification des symboles par défaut"
        '
        'Btn_modif_temps
        '
        Me.Btn_modif_temps.Location = New System.Drawing.Point(12, 206)
        Me.Btn_modif_temps.Name = "Btn_modif_temps"
        Me.Btn_modif_temps.Size = New System.Drawing.Size(75, 23)
        Me.Btn_modif_temps.TabIndex = 7
        Me.Btn_modif_temps.Text = "Modifier"
        Me.Btn_modif_temps.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Modification du temps pour trouver la combinaison"
        '
        'Form_Modif_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 438)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_modif_temps)
        Me.Controls.Add(Me.lbl_modif_symb_def)
        Me.Controls.Add(Me.btn_modif_symb_5)
        Me.Controls.Add(Me.btn_modif_symb_4)
        Me.Controls.Add(Me.btn_modif_symb_3)
        Me.Controls.Add(Me.btn_modif_symb_2)
        Me.Controls.Add(Me.btn_modif_symb_1)
        Me.Controls.Add(Me.btn_quitter)
        Me.Name = "Form_Modif_Options"
        Me.Text = "ModifOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_quitter As Button
    Friend WithEvents btn_modif_symb_1 As Button
    Friend WithEvents btn_modif_symb_2 As Button
    Friend WithEvents btn_modif_symb_3 As Button
    Friend WithEvents btn_modif_symb_4 As Button
    Friend WithEvents btn_modif_symb_5 As Button
    Friend WithEvents lbl_modif_symb_def As Label
    Friend WithEvents Btn_modif_temps As Button
    Friend WithEvents Label1 As Label
End Class
