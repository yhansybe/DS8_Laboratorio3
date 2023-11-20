Imports MySql.Data.MySqlClient

Public Class MovimientoInsert
    Public Sub insertMovimiento(ByVal idCuenta As Integer, ByVal saldo As Double, ByVal tbTransaccion As TextBox)
        Conexion.obtenerConexion()

        Try
            Dim sqlInsert As String = "INSERT INTO tbl_movimientos (id_cuenta "
            If tbTransaccion.Text = "Deposito" Then
                sqlInsert += ", deposito"
            Else
                sqlInsert += ", Retiro"
            End If
            sqlInsert += ")VALUES (@idCuenta,@saldo)"


            Dim command As New MySqlCommand(sqlInsert, Conexion.conexion)

            command.Parameters.AddWithValue("@idCuenta", idCuenta)
            command.Parameters.AddWithValue("@saldo", saldo)

            command.ExecuteNonQuery()

            Console.WriteLine("Inserción Completada")
            Conexion.CerrarConexion()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class
