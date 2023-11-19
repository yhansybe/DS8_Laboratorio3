Imports System.Net
Imports MySql.Data.MySqlClient
Public Class FrmCrearCliente
    Private conn As MySqlConnection

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim hostName = Dns.GetHostName
        Dim ipLocal As IPHostEntry = Dns.GetHostEntry(hostName)

        Dim objAgregarCliente As New ClassAgregarCliente(txtNombre, txtApellido, txtDireccion, txtTelefono)
        objAgregarCliente.agregarCliente()
    End Sub
End Class