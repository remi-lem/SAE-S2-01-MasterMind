Module Demarrage
    Public DEBUG_MODE = True ' METTRE FALSE AVANT DE RENDRE !!!!

    Sub Main()
        Dim nombre As Integer = 20
        LesJoueurs.ReDimJoueurs(nombre)

        Symboles.InitSymbolesDeBase()

        Application.Run(Form_Accueil)
    End Sub
End Module
