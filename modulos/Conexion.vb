Imports MySql.Data.MySqlClient

Module Conexion
    Public conexion As MySqlConnection

    Public Sub obtenerConexion()
        If conexion Is Nothing Then
            Try
                Dim cadena As String = "server=localhost;database=ds8_lab3;userid=root"
                conexion = New MySqlConnection(cadena)
                conexion.Open()
                Console.WriteLine("^) Conexión realizada.")
            Catch ex As Exception
                Console.WriteLine("X) Error al conectar: " & ex.Message)
            End Try
        End If
    End Sub

    Public Sub CerrarConexion()
        If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
            Try
                conexion.Close()
                conexion.Dispose()
                conexion = Nothing
                Console.WriteLine("^) Conexión cerrada.")
            Catch ex As Exception
                Console.WriteLine("X) Error al cerrar la conexión: " & ex.Message)
            End Try
        End If
    End Sub

End Module
