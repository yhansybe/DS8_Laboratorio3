Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AgregarCuenta
    Public Property IdCliente As Integer

    Public Sub New(clienteId As Integer)
        IdCliente = clienteId
    End Sub

    Public Sub AgregarCuentaEnBaseDeDatos(tipoCuenta As String, saldoInicial As Double)
        Conexion.obtenerConexion()
        Try
            Dim command As New MySqlCommand("proc_insert_cuenta", Conexion.conexion)
            command.CommandType = CommandType.StoredProcedure

            command.Parameters.AddWithValue("@p_tipo", tipoCuenta)
            command.Parameters.AddWithValue("@p_saldo", saldoInicial)
            command.Parameters.AddWithValue("@p_id_cliente", IdCliente)
            command.Parameters.Add("@resul", MySqlDbType.Bit)
            command.Parameters("@resul").Direction = ParameterDirection.Output

            command.ExecuteNonQuery()

            Dim resultado As Boolean = Convert.ToBoolean(command.Parameters("@resul").Value)

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
