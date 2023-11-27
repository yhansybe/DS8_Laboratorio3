Imports MySql.Data.MySqlClient

Public Class MovimientosManager

    Public Sub fillMovimientosGrid(ByRef table As DataGridView, cliente_id As Integer)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("selectMovimientosPorCliente", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@cliente_id", cliente_id)

            Dim reader As MySqlDataReader = command.ExecuteReader()
            Dim dataTable As New DataTable()
            dataTable.Load(reader)

            ' Asignar el DataTable al DataGridView
            table.DataSource = dataTable

            reader.Close()
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
