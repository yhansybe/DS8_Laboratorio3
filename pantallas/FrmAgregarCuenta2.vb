Public Class FrmAgregarCuenta2

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        Dim nombreClienteRaw As String = cbCliente.Text
        Dim nombreClienteParts As String() = nombreClienteRaw.Split(" ")
        Dim id_cliente As Integer = Val(nombreClienteParts(nombreClienteParts.Length - 1))

        Dim saldo As Double = Val(txtSaldoInicial.Text)
        Dim tipocuenta As String = txtTCuenta.Text

        Dim cuentamanager As New CuentaManager()
        cuentamanager.agregarCuenta(saldo, tipocuenta, id_cliente)
    End Sub

    Private Sub FrmAgregarCuenta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientemanager As New ClienteManager()
        clientemanager.fillComboBoxClientes(cbCliente)
    End Sub
End Class