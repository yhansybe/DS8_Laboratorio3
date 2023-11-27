Imports System.Reflection

Public Class FrmRetiroDeposito
    Private Sub FrmRetiroDeposito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clienteManager As New ClienteManager()
        clienteManager.fillComboBoxClientes(cbCliente)
    End Sub

    Private Sub cbCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCliente.SelectedIndexChanged
        Dim cuentasManager As New CuentasManager()
        Dim idcliente As Integer = ExtractId.extractId(cbCliente.Text)
        Console.WriteLine(idcliente)
        cuentasManager.fillComboBoxCuentas(cbCuenta, idcliente)
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        If String.IsNullOrEmpty(cbTipo.Text) Then
            MsgBox("Selecciona antes que tipo de transacción hacer")
            Return
        End If

        Dim movimientoManager As New MovimientosManager()

        Dim idcuenta As Integer = ExtractId.extractId(cbCuenta.Text)
        Dim monto As Double = Val(tbSaldo.Text)
        Dim tipo As String = cbTipo.Text
        movimientoManager.insertMovimiento(idcuenta, monto, tipo)
    End Sub
End Class