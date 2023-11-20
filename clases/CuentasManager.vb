Imports MySql.Data.MySqlClient


Public Class CuentasManager

    Public Sub fillComboBoxCuentas(ByRef comboBox As ComboBox, ByRef idUser As Integer, ByRef listAccount As String)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("selectCuentas", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@idCliente", idUser)
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                comboBox.Items.Add(reader("tipo").ToString())
                listAccount += (reader("id_cuenta").ToString() & " ")

            End While

            reader.Close()
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class





