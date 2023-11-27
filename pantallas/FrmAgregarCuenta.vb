
Public Class FrmAgregarCuenta

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click

        Dim id_cliente As Integer = ExtractId.extractId(cbCliente.Text)

        Dim saldo As Double = Val(txtSaldoInicial.Text)
        Dim tipocuenta As String = txtTCuenta.Text

        Dim cuentamanager As New CuentasManager()
        cuentamanager.agregarCuenta(saldo, tipocuenta, id_cliente)
    End Sub

    Private Sub FrmAgregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clientemanager As New ClienteManager()
        clientemanager.fillComboBoxClientes(cbCliente)
    End Sub
End Class