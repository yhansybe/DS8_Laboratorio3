Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmRetiroDeposito.MdiParent = Me
        FrmRetiroDeposito.WindowState = FormWindowState.Maximized
        FrmRetiroDeposito.ControlBox = False
        FrmRetiroDeposito.Show()
    End Sub

    Private Sub RetirosYDepositosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RetirosYDepositosToolStripMenuItem.Click
        FrmRetiroDeposito.Close()
        FrmMovimientos.Close()
        FrmAgregarCuenta2.Close()

        FrmRetiroDeposito.MdiParent = Me
        FrmRetiroDeposito.WindowState = FormWindowState.Maximized
        FrmRetiroDeposito.ControlBox = False
        FrmRetiroDeposito.Show()
    End Sub

    Private Sub MovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MovimientosToolStripMenuItem.Click
        FrmRetiroDeposito.Close()
        FrmMovimientos.Close()
        FrmAgregarCuenta2.Close()

        FrmMovimientos.MdiParent = Me
        FrmMovimientos.WindowState = FormWindowState.Maximized
        FrmMovimientos.ControlBox = False
        FrmMovimientos.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FrmRetiroDeposito.Close()
        FrmMovimientos.Close()
        FrmAgregarCuenta2.Close()

        FrmAgregarCuenta2.MdiParent = Me
        FrmAgregarCuenta2.WindowState = FormWindowState.Maximized
        FrmAgregarCuenta2.ControlBox = False
        FrmAgregarCuenta2.Show()
    End Sub

    Private Sub CreacionDeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreacionDeClienteToolStripMenuItem.Click
        FrmRetiroDeposito.Close()
        FrmMovimientos.Close()
        FrmAgregarCuenta2.Close()
        FrmCrearCliente.Close()

        FrmCrearCliente.MdiParent = Me
        FrmCrearCliente.WindowState = FormWindowState.Maximized
        FrmCrearCliente.ControlBox = False
        FrmCrearCliente.Show()
    End Sub

End Class
