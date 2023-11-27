Imports MySql.Data.MySqlClient

Public Class CuentasManager

    Public Sub fillComboBoxCuentas(ByRef comboBox As ComboBox, idUser As Integer)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("selectCuentas", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@idCliente", idUser)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                comboBox.Items.Add(reader("tipo").ToString() & " - " & reader("id_cuenta").ToString())
            End While

            reader.Close()
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

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





