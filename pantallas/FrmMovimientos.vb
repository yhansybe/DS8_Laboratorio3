﻿Public Class FrmMovimientos

    Private Sub FrmMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim clienteManager As New ClienteManager()
        clienteManager.fillComboBoxClientes(cbClientes)
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbClientes.SelectedIndexChanged
        Dim nombreClienteRaw As String = cbClientes.Text
        Dim nombreClienteParts As String() = nombreClienteRaw.Split(" ")
        Dim id_cliente As Integer = Val(nombreClienteParts(nombreClienteParts.Length - 1))

    End Sub

End Class