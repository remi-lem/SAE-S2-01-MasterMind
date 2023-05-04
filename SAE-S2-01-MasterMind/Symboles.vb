Module Symboles
    Dim symboles As New List(Of String)({"#", "$", "£", "%", "@"})

    Public Function GetSymbole(index As Integer) As String
        Debug.Assert(index < Symboles.Count And index >= 0)
        Return symboles(index)
    End Function

    Public Sub SetSymbole(index As Integer, value As String)
        Debug.Assert(index < symboles.Count And index >= 0)
        symboles(index) = value
    End Sub

    Public Function AlreadyUsed(SymbNo As Integer, Symb As String) As Boolean
        For Index As Integer = 0 To symboles.Count - 1
            If SymbNo = Index Then Continue For
            If symboles(Index).Equals(Symb) Then Return True
        Next
        Return False
    End Function

End Module
