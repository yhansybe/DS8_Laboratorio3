Imports System.Net
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient

Public Class ClassAgregarCliente
    Dim nombre As String
    Dim apellido As String
    Dim direccion As String
    Dim telefono As String
    Dim resul As Boolean
    Dim sqlCommand As New MySqlCommand

    Public Sub New(txtNombre As TextBox, txtApellido As TextBox, txtDireccion As TextBox, txtTelefono As TextBox)
        nombre = txtNombre.Text
        apellido = txtApellido.Text
        direccion = txtDireccion.Text
        telefono = txtTelefono.Text
    End Sub
    Public Function agregarCliente() As String
        Try
            If nombre And apellido And direccion And telefono <> "" Then
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
                    Return MsgBox("Inserción Exitosa")
                Else
                    Return MsgBox("Error en la inserción")
                End If
            Else
                Return MsgBox("No deje datos en blsnco")
            End If

        Catch ex As Exception
            Return MsgBox(ex.Message)
        Finally
            CerrarConexion()
        End Try
    End Function
End Class
