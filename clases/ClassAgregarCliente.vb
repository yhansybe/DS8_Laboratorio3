Imports System.Net
Imports Google.Protobuf.WellKnownTypes
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

    Public Function agregarCliente() As String
        Dim resul As Boolean
        Try
            If Not String.IsNullOrEmpty(nombre.Text) AndAlso Not String.IsNullOrEmpty(apellido.Text) AndAlso Not String.IsNullOrEmpty(direccion.Text) AndAlso Not String.IsNullOrEmpty(telefono.Text) Then
                sqlCommand.Connection = Conexion.conexion
                sqlCommand.CommandText = "proc_insert_cliente"
                sqlCommand.Parameters.AddWithValue("@nombre", nombre.Text.ToString)
                sqlCommand.Parameters.AddWithValue("@apellido", apellido.Text.ToString)
                sqlCommand.Parameters.AddWithValue("@direccion", direccion.Text.ToString)
                sqlCommand.Parameters.AddWithValue("@telefono_movil", telefono.Text.ToString)
                sqlCommand.Parameters.Add("@resul", MySqlDbType.Bit)
                sqlCommand.Parameters("@resul").Direction = ParameterDirection.Output
                sqlCommand.CommandTimeout = 0
                sqlCommand.CommandType = CommandType.StoredProcedure

                resul = sqlCommand.ExecuteNonQuery()

                If resul Then
                    limpiar()
                    Return MsgBox("Cliente Agregado con exito")
                Else
                    Return MsgBox("Error al agregar cliente")
                End If
            Else
                Return MsgBox("No deje datos en blanco")
            End If

        Catch ex As Exception
            Return MsgBox(ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Function

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
    End Function
    Private Sub limpiar()
        nombre.Text = ""
        apellido.Text = ""
        direccion.Text = ""
        telefono.Text = ""
    End Sub

End Class
