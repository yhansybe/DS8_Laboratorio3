Imports Microsoft.VisualBasic.ApplicationServices

Public Class FrmRetiroDeposito
    Dim clientes As New ClienteManager
    Dim cuentas As New CuentasManager
    Dim Movimientos As New MovimientoInsert
    Dim listUser As String
    Dim listAccount As String

    Public Sub New()
        InitializeComponent()
        clientes.fillComboBoxClientes(cbNombre, listUser)
    End Sub

    Private Sub btnRetiro_Click_1(sender As Object, e As EventArgs)
        tbTransaccion.Text = "Retiro"


    End Sub

    Private Sub btnDeposito_Click_1(sender As Object, e As EventArgs)
        tbTransaccion.Text = "Deposito"
    End Sub

    Private Sub tbNombre_TextChanged(sender As Object, e As EventArgs)
        If Not String.IsNullOrEmpty(Me.Text) Then
            txtCuenta.Visible = True
            cbCuenta.Visible = True
        End If
    End Sub
    Private Sub tbTransaccion_TextChanged_1(sender As Object, e As EventArgs) Handles tbTransaccion.TextChanged
        txtSaldo.Visible = True
        tbSaldo.Visible = True
    End Sub

    Private Sub tbSaldo_TextChanged_1(sender As Object, e As EventArgs) Handles tbSaldo.TextChanged
        If Not String.IsNullOrEmpty(Me.Text) Then
            btnEnviar.Visible = True
            btnSalir.Visible = True
        End If
    End Sub

    Private Sub btnRetiro_Click(sender As Object, e As EventArgs) Handles btnRetiro.Click
        tbTransaccion.Text = "Retiro"
    End Sub

    Private Sub btnDeposito_Click(sender As Object, e As EventArgs) Handles btnDeposito.Click
        tbTransaccion.Text = "Deposito"
    End Sub

    Private Sub cbNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbNombre.SelectedIndexChanged
        cbCuenta.Items.Clear()

        Dim idUsers() = listUser.Split(" ")
        Dim idUsuario = Val(idUsers(cbNombre.SelectedIndex))

        cuentas.fillComboBoxCuentas(cbCuenta, idUsuario, listAccount)



        If Not String.IsNullOrEmpty(Me.Text) Then
            txtCuenta.Visible = True
            cbCuenta.Visible = True
        End If
    End Sub

    Private Sub cbCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCuenta.SelectedIndexChanged
        If Not String.IsNullOrEmpty(Me.Text) Then
            btnDeposito.Visible = True
            btnRetiro.Visible = True
            txtTransaccion.Visible = True
            tbTransaccion.Visible = True
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        tbSaldo.Text += btn1.Text
    End Sub
    Private Sub btn2_Click_1(sender As Object, e As EventArgs) Handles btn2.Click
        tbSaldo.Text += btn2.Text
    End Sub
    Private Sub btn3_Click_1(sender As Object, e As EventArgs) Handles btn3.Click
        tbSaldo.Text += btn3.Text
    End Sub
    Private Sub btn4_Click_1(sender As Object, e As EventArgs) Handles btn4.Click
        tbSaldo.Text += btn4.Text
    End Sub
    Private Sub btn5_Click_1(sender As Object, e As EventArgs) Handles btn5.Click
        tbSaldo.Text += btn5.Text
    End Sub
    Private Sub btn6_Click_1(sender As Object, e As EventArgs) Handles btn6.Click
        tbSaldo.Text += btn6.Text
    End Sub
    Private Sub btn7_Click_1(sender As Object, e As EventArgs) Handles btn7.Click
        tbSaldo.Text += btn7.Text
    End Sub
    Private Sub btn8_Click_1(sender As Object, e As EventArgs) Handles btn8.Click
        tbSaldo.Text += btn8.Text
    End Sub
    Private Sub btn9_Click_1(sender As Object, e As EventArgs) Handles btn9.Click
        tbSaldo.Text += btn9.Text
    End Sub
    Private Sub btn0_Click_1(sender As Object, e As EventArgs) Handles btn0.Click
        tbSaldo.Text += btn0.Text
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim numero = tbSaldo.Text
        numero = numero.Remove(numero.Length - 1, 1)
        tbSaldo.Text = numero
    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim idAccounts() = listAccount.Split(" ")
        Dim idAccount = Val(idAccounts(cbCuenta.SelectedIndex))
        Movimientos.insertMovimiento(idAccount, Double.Parse(tbSaldo.Text), tbTransaccion)

        cbCuenta.Visible = False

        btnEnviar.Visible = False
        btnRetiro.Visible = False
        btnDeposito.Visible = False

        lbMensaje.Visible = True
        plMensaje.Visible = True



    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        tbTransaccion.Text = ""
        tbSaldo.Text = ""

        cbCuenta.Text = ""
        cbNombre.Text = ""

        txtCuenta.Visible = False
        btnSalir.Visible = False
        btnEnviar.Visible = False
        cbCuenta.Visible = False

        txtSaldo.Visible = False
        tbSaldo.Visible = False

        btnDeposito.Visible = False
        btnRetiro.Visible = False
        txtTransaccion.Visible = False
        tbTransaccion.Visible = False


        lbMensaje.Visible = False
        plMensaje.Visible = False
    End Sub
End Class