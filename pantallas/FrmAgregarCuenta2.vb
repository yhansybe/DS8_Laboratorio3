Public Class FrmAgregarCuenta2



    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click

    End Sub

    Private Sub FrmAgregarCuenta2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTipoCuenta.Items.Add("Cuenta Corriente")
        cbTipoCuenta.Items.Add("Cuenta de Ahorros")
        cbTipoCuenta.SelectedIndex = 0
    End Sub
End Class