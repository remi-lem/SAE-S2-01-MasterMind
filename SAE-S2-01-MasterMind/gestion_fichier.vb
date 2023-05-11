Module Gestion_fichier
    Private ReadOnly ID_NOM As Integer = 0   'Aussi utilisé pour avoir le premier indice du tableau après le split
    Private ReadOnly ID_SCORE As Integer = 1 'Aussi utilisé pour avoir le deuxième indice du tableau après le split
    Private ReadOnly ID_BESTTIME As Integer = 2  'Aussi utilisé pour avoir le troisième indice du tableau après le split
    Private ReadOnly ID_NBFIRST As Integer = 3
    Private ReadOnly ID_NBSECOND As Integer = 4
    Private ReadOnly ID_CUMUL As Integer = 5


    Public Sub LectureDuFichier()
        Dim ligne As String
        Dim num As Integer = FreeFile()
        Dim chemin As String = "./registre_de_joueurs.txt"
        FileOpen(num, chemin, OpenMode.Input)
        Do Until EOF(num)
            ligne = LineInput(num)
            Dim ligne_split() As String = Split(ligne, ";")


            Dim nom_split() As String = Split(ligne_split(ID_NOM), ",")
            Dim nom As String = nom_split(ID_SCORE)

            Dim bestTime() As String = Split(ligne_split(ID_BESTTIME), ":")
            Dim Best As TimeSpan = New TimeSpan(bestTime(ID_NOM), bestTime(ID_SCORE), bestTime(ID_BESTTIME))


            Dim Cumul_split() As String = Split(ligne_split(ID_CUMUL), ":")
            Dim cumul_secondes_split() As String = Split(Cumul_split(ID_BESTTIME), ",")
            Dim cumul_secondes As String = cumul_secondes_split(ID_NOM)
            Dim Cumul As TimeSpan = New TimeSpan(Cumul_split(ID_NOM), Cumul_split(ID_SCORE), cumul_secondes)

            AjoutJoueurComplet(nom, ligne_split(ID_SCORE), Best, ligne_split(ID_NBFIRST), ligne_split(ID_NBSECOND), Cumul)
        Loop
        FileClose(num)

    End Sub



    Public Sub EcritureDuFichier()
        Dim num As Integer = FreeFile()
        Dim chemin As String = "./registre_de_joueurs.txt"
        FileOpen(num, chemin, OpenMode.Output)
        For i As Integer = 0 To GetNb() - 1
            Dim nom As String = GetNomPlayer(i)
            WriteLine(num, "," & nom & ";" & GetScorePlayer(nom) & ";" & GetBestTimePlayer(nom).ToString & ";" & GetNbJ1Player(i) & ";" & GetNbJ2Player(i) & ";" & GetTimeCumulePlayer(i).ToString & ",")
        Next
        FileClose(num)

    End Sub


End Module
