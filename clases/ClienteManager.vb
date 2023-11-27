Imports MySql.Data.MySqlClient

Public Class ClienteManager

    Public Sub fillComboBoxClientes(ByRef comboBox As ComboBox)
        Conexion.obtenerConexion()
        Try
            Dim command As New MySqlCommand("selectClientes", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure
            Dim reader As MySqlDataReader = command.ExecuteReader()


            While reader.Read()
                comboBox.Items.Add(reader("nombre_completo").ToString() & " - " & reader("id_cliente").ToString())
            End While
            reader.Close()
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
