Imports MySql.Data.MySqlClient

Public Class ClassAgregarCliente
    Public nombre As TextBox
    Public apellido As TextBox
    Public direccion As TextBox
    Public telefono As TextBox
    Public sqlCommand As New MySqlCommand

    Public Sub New(ByRef txtNombre As TextBox, ByRef txtApellido As TextBox, ByRef txtDireccion As TextBox, ByRef txtTelefono As TextBox)
        nombre = txtNombre
        apellido = txtApellido
        direccion = txtDireccion
        telefono = txtTelefono
    End Sub

    Public Sub New()

    End Sub

    Public Sub InsertarCliente(ByVal nombre As String, ByVal apellido As String, ByVal direccion As String, ByVal telefonoMovil As String, ByRef resultado As Boolean)
        Conexion.obtenerConexion()

        Try
            Dim command As New MySqlCommand("proc_insert_cliente", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            ' Parámetros de entrada
            command.Parameters.AddWithValue("@p_nombre", nombre)
            command.Parameters.AddWithValue("@p_apellido", apellido)
            command.Parameters.AddWithValue("@p_direccion", direccion)
            command.Parameters.AddWithValue("@p_telefono_movil", telefonoMovil)

            ' Parámetro de salida
            command.Parameters.Add("@resul", MySqlDbType.Bit)
            command.Parameters("@resul").Direction = ParameterDirection.Output

            ' Ejecutar el procedimiento almacenado
            command.ExecuteNonQuery()

            ' Obtener el valor de retorno
            resultado = Convert.ToBoolean(command.Parameters("@resul").Value)

            MsgBox("Cliente agregado")

            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Function actualizarCliente(ByVal num_cuenta As Integer, ByVal separador As Object) As String
        Dim nombre_cliente As String = ""
        Dim apellido_cliente As String = ""
        Dim resul As Boolean

        For cont = 0 To separador.Length - 1
            If cont = 0 Then
                nombre_cliente = separador(cont)
            Else
                apellido_cliente = separador(cont)
            End If
        Next
        Conexion.obtenerConexion()
        sqlCommand.Connection = Conexion.conexion
        sqlCommand.CommandText = "proc_update_cliente"
        sqlCommand.Parameters.AddWithValue("@p_nombre", nombre_cliente)
        sqlCommand.Parameters.AddWithValue("@p_apellido", apellido_cliente)
        sqlCommand.Parameters.AddWithValue("@p_id_cuenta", num_cuenta)
        sqlCommand.Parameters.Add("@resul", MySqlDbType.Bit)
        sqlCommand.Parameters("@resul").Direction = ParameterDirection.Output
        sqlCommand.CommandTimeout = 0
        sqlCommand.CommandType = CommandType.StoredProcedure

        resul = sqlCommand.ExecuteNonQuery()
        If resul Then
            Return MsgBox("Cliente Actualizado con exito")
        Else
            Return MsgBox("Error al actualizar cliente")
        End If
        Conexion.CerrarConexion()
    End Function
    Private Sub limpiar()
        nombre.Text = ""
        apellido.Text = ""
        direccion.Text = ""
        telefono.Text = ""
    End Sub

End Class
