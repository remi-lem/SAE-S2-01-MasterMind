Module Symboles
    Dim symbParDefaut1 As String
    Dim symbParDefaut2 As String
    Dim symbParDefaut3 As String
    Dim symbParDefaut4 As String
    Dim symbParDefaut5 As String

    Public Function getSymbDef1()
        Return symbParDefaut1
    End Function

    Public Function getSymbDef2()
        Return symbParDefaut2
    End Function
    Public Function getSymbDef3()
        Return symbParDefaut3
    End Function
    Public Function getSymbDef4()
        Return symbParDefaut4
    End Function
    Public Function getSymbDef5()
        Return symbParDefaut5
    End Function

    Public Sub setSymbDef1(symbDef1)
        symbParDefaut1 = symbDef1
    End Sub
    Public Sub setSymbDef2(symbDef2)
        symbParDefaut2 = symbDef2
    End Sub
    Public Sub setSymbDef3(symbDef3)
        symbParDefaut3 = symbDef3
    End Sub
    Public Sub setSymbDef4(symbDef4)
        symbParDefaut4 = symbDef4
    End Sub
    Public Sub setSymbDef5(symbDef5)
        symbParDefaut5 = symbDef5
    End Sub

    Public Sub initSymbolesDeBase()
        symbParDefaut1 = "#"
        symbParDefaut2 = "$"
        symbParDefaut3 = "£"
        symbParDefaut4 = "%"
        symbParDefaut5 = "@"
    End Sub

End Module
