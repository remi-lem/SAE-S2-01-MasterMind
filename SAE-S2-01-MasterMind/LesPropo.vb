Module LesPropo
    Private Nb_Proposition_Max As Integer = 15

    Public Function Get_Nb_Prop() As Integer
        Return Nb_Proposition_Max
    End Function

    Public Sub Set_Nb_Prop(Nb_Prop As Integer)
        If Nb_Prop > 0 Then
            Nb_Proposition_Max = Nb_Prop
        End If
    End Sub
End Module
