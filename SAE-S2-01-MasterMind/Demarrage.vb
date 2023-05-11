Module Demarrage
    Public DEBUG_MODE = False ' mettre True pour des tests plus rapides

    Sub Main()
        Dim nombre As Integer = 20
        LesJoueurs.ReDimJoueurs(nombre)

        LeTemps.InitTempsDeBase()


        LectureDuFichier()


        Application.Run(Form_Accueil)
    End Sub
End Module
