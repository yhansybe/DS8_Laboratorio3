Imports MySql.Data.MySqlClient

Public Class CuentaManager

    Public Sub agregarCuenta(saldo As Double, tipo As String, idcliente As Integer)
        Conexion.obtenerConexion()

        Try
            ' Llamada al procedimiento almacenado sp_insertar_cuenta
            Dim command As New MySqlCommand("sp_insertar_cuenta", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            ' Parámetros del procedimiento almacenado
            command.Parameters.AddWithValue("@p_saldo", saldo)
            command.Parameters.AddWithValue("@p_tipo", tipo)
            command.Parameters.AddWithValue("@p_id_cliente", idcliente)
            command.Parameters.Add("@p_resultado", MySqlDbType.Bit)
            command.Parameters("@p_resultado").Direction = ParameterDirection.Output

            ' Ejecutar el procedimiento almacenado
            command.ExecuteNonQuery()

            ' Obtener el resultado del procedimiento almacenado
            Dim resultado As Boolean = Convert.ToBoolean(command.Parameters("@p_resultado").Value)

            If resultado Then
                MessageBox.Show("Cuenta agregada con éxito.")
            Else
                MessageBox.Show("Error al agregar cuenta.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Conexion.CerrarConexion()
        End Try
    End Sub
End Class
