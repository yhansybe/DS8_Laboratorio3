Imports System.Net
Imports MySql.Data.MySqlClient

Public Class ClassAgregarCliente
    Dim hostName As String
    Dim ipLocal As IPHostEntry
    Dim nombre As String
    Dim apellido As String
    Dim direccion As String
    Dim telefono As String
    Dim resul As Boolean
    Dim connBD As New MySqlConnection("TuCadenaDeConexion")
    Dim sqlCommand As New MySqlCommand

    Public Sub New(conn As MySqlConnection, hostName As String, ipLocal As IPHostEntry, txtNombre As TextBox, txtApellido As TextBox, txtDireccion As TextBox, txtTelefono As TextBox)
        Me.hostName = hostName
        Me.ipLocal = ipLocal
        Me.nombre = txtNombre.Text
        Me.apellido = txtApellido.Text
        Me.direccion = txtDireccion.Text
        Me.telefono = txtTelefono.Text
        Me.connBD = conn
    End Sub
    Public Function agregarCliente() As String
        Try

            Me.sqlCommand.Connection = Me.connBD
            Me.connBD.Open()
            Me.sqlCommand.CommandText = "proc_insert_cliente"
            Me.sqlCommand.Parameters.AddWithValue("@nombre", Me.nombre)
            Me.sqlCommand.Parameters.AddWithValue("@apellido", Me.apellido)
            Me.sqlCommand.Parameters.AddWithValue("@direccion", Me.direccion)
            Me.sqlCommand.Parameters.AddWithValue("@telefono_movil", Me.telefono)
            Me.sqlCommand.Parameters.Add("@resul", MySqlDbType.Bit)
            Me.sqlCommand.Parameters("@resul").Direction = ParameterDirection.Output

            Me.sqlCommand.CommandTimeout = 0
            Me.sqlCommand.CommandType = CommandType.StoredProcedure

            Me.resul = sqlCommand.ExecuteNonQuery()
            resul = Convert.ToBoolean(Me.sqlCommand.Parameters("@resul").Value)

            If Me.resul Then
                Return MsgBox("Inserción Exitosa")
            Else
                Return MsgBox("Error en la inserción")
            End If
        Catch ex As Exception
            Return MsgBox(ex.Message)
        Finally
            If Me.connBD.State <> ConnectionState.Closed Then Me.connBD.Close()
        End Try
    End Function
End Class
