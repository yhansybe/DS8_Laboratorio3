Imports MySql.Data.MySqlClient
Public Class FrmCrearCliente
    Private conn As MySqlConnection


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim objAgregarCliente As New ClassAgregarCliente()
        objAgregarCliente.InsertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, True)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim num_cuenta As Integer
        Dim nombre_cuenta, separador() As String
        Dim objAgregarCliente As New ClassAgregarCliente()
        num_cuenta = InputBox("Ingrese el numero de cuenta", "Actualizar Cuenta")
        nombre_cuenta = InputBox("Ingrese el nombre y apellido nuevo de la cuenta", "Actualizar")
        separador = nombre_cuenta.Split(" ")
        objAgregarCliente.actualizarCliente(num_cuenta, separador)
    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class