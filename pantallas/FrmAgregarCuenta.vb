Public Class FrmAgregarCuenta
    Private clienteId As Integer

    Public Sub New(clienteId As Integer)
        InitializeComponent()
        Me.clienteId = clienteId
    End Sub

    Private Sub btnAgregarCuenta_Click(sender As Object, e As EventArgs) Handles btnAgregarCuenta.Click
        Dim tipoCuenta As String = cbTipoCuenta.SelectedItem.ToString()
        Dim saldoInicial As Double

        If Double.TryParse(tbSaldoInicial.Text, saldoInicial) Then
            Dim agregarCuenta As New AgregarCuenta(clienteId)
            agregarCuenta.AgregarCuentaEnBaseDeDatos(tipoCuenta, saldoInicial)
        Else
            MessageBox.Show("Ingrese un saldo válido.")
        End If
    End Sub

    Private Sub FrmAgregarCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configuración inicial del formulario
        cbTipoCuenta.Items.Add("Cuenta Corriente")
        cbTipoCuenta.Items.Add("Cuenta de Ahorros")
        cbTipoCuenta.SelectedIndex = 0
    End Sub
End Class
