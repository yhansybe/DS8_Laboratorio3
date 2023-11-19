Imports System.Net
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class ClassAgregarCliente
    Dim nombre As TextBox
    Dim apellido As TextBox
    Dim direccion As TextBox
    Dim telefono As TextBox
    Dim resul As Boolean
    Dim sqlCommand As New MySqlCommand

    Public Sub New(ByRef txtNombre As TextBox, ByRef txtApellido As TextBox, ByRef txtDireccion As TextBox, ByRef txtTelefono As TextBox)
        nombre = txtNombre
        apellido = txtApellido
        direccion = txtDireccion
        telefono = txtTelefono
    End Sub
    Public Function agregarCliente() As String
        Try
            If Not String.IsNullOrEmpty(nombre.Text) AndAlso Not String.IsNullOrEmpty(apellido.Text) AndAlso Not String.IsNullOrEmpty(direccion.Text) AndAlso Not String.IsNullOrEmpty(telefono.Text) Then
                sqlCommand.Connection = Conexion.conexion
                sqlCommand.CommandText = "proc_insert_cliente"
                sqlCommand.Parameters.AddWithValue("@nombre", nombre)
                sqlCommand.Parameters.AddWithValue("@apellido", apellido)
                sqlCommand.Parameters.AddWithValue("@direccion", direccion)
                sqlCommand.Parameters.AddWithValue("@telefono_movil", telefono)
                sqlCommand.Parameters.Add("@resul", MySqlDbType.Bit)
                sqlCommand.Parameters("@resul").Direction = ParameterDirection.Output
                sqlCommand.CommandTimeout = 0
                sqlCommand.CommandType = CommandType.StoredProcedure

                resul = sqlCommand.ExecuteNonQuery()

                If resul Then
                    nombre.Text = ""
                    apellido.Text = ""
                    direccion.Text = ""
                    telefono.Text = ""
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
End Class
