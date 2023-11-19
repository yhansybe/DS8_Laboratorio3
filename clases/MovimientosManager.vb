Imports MySql.Data.MySqlClient

Public Class MovimientosManager

    Public Sub fillMovimientosGrid(ByRef table As DataGridView)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("selectClientes", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()

            End While

            reader.Close()
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
