Public Class FrmMovimientos


    Private Sub FrmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clienteManager As New ClienteManager()
        clienteManager.fillComboBoxClientes(cbClientes)
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        Dim id_cliente As Integer = ExtractId.extractId(cbClientes.Text)

        Dim movimientosManager As New MovimientosManager()
        movimientosManager.fillMovimientosGrid(dgvMovimientos, id_cliente)
    End Sub

End Class