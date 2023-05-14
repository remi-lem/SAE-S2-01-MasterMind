Module LeFichier
    Private chemin As String = "../../registre_de_joueurs.txt"

    Public Sub SetChemin(cheminArg As String)
        chemin = cheminArg
    End Sub

    Public Function GetChemin()
        Return chemin
    End Function
End Module
