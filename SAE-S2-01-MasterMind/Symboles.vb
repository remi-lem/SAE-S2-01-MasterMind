Module Symboles
    Dim symbParDefaut1 As String
    Dim symbParDefaut2 As String
    Dim symbParDefaut3 As String
    Dim symbParDefaut4 As String
    Dim symbParDefaut5 As String

    Public Function GetSymbDef1()
        Return symbParDefaut1
    End Function

    Public Function GetSymbDef2()
        Return symbParDefaut2
    End Function
    Public Function GetSymbDef3()
        Return symbParDefaut3
    End Function
    Public Function GetSymbDef4()
        Return symbParDefaut4
    End Function
    Public Function GetSymbDef5()
        Return symbParDefaut5
    End Function

    Public Sub SetSymbDef1(symbDef1)
        symbParDefaut1 = symbDef1
    End Sub
    Public Sub SetSymbDef2(symbDef2)
        symbParDefaut2 = symbDef2
    End Sub
    Public Sub SetSymbDef3(symbDef3)
        symbParDefaut3 = symbDef3
    End Sub
    Public Sub SetSymbDef4(symbDef4)
        symbParDefaut4 = symbDef4
    End Sub
    Public Sub SetSymbDef5(symbDef5)
        symbParDefaut5 = symbDef5
    End Sub

    Public Sub InitSymbolesDeBase()
        SetSymbDef1("#")
        SetSymbDef2("$")
        SetSymbDef3("£")
        SetSymbDef4("%")
        SetSymbDef5("@")
    End Sub

End Module
