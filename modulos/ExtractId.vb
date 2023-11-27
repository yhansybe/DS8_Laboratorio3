Module ExtractId

    Public Function extractId(nombreClienteRaw As String) As Integer
        Dim nombreClienteParts As String() = nombreClienteRaw.Split(" ")
        Dim id_cliente As Integer = Val(nombreClienteParts(nombreClienteParts.Length - 1))
        Return id_cliente
    End Function

End Module
