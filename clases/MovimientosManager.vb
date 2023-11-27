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

    Public Sub insertMovimiento(ByVal idCuenta As Integer, ByVal saldo As Double, ByVal tbTransaccion As String)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("agregarMovimiento", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            ' Agregar parámetros al procedimiento almacenado
            command.Parameters.AddWithValue("@idCuenta", idCuenta)
            command.Parameters.AddWithValue("@monto", saldo)
            command.Parameters.AddWithValue("@tipoOperacion", tbTransaccion)

            ' Ejecutar el procedimiento almacenado
            command.ExecuteNonQuery()

            MsgBox("transacción realizada")

            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
