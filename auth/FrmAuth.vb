Public Class FrmAuth

    Private Sub FrmAuth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FrmLogin.MdiParent = Me
        FrmLogin.WindowState = FormWindowState.Maximized
        FrmLogin.ControlBox = False
        FrmLogin.Show()
    End Sub

    Private Sub IngresarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresarToolStripMenuItem.Click
        FrmLogin.Close()
        FrmRegister.Close()

        FrmLogin.MdiParent = Me
        FrmLogin.WindowState = FormWindowState.Maximized
        FrmLogin.ControlBox = False
        FrmLogin.Show()
    End Sub

    Private Sub CrearCuentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearCuentaToolStripMenuItem.Click
        FrmLogin.Close()
        FrmRegister.Close()

        FrmRegister.MdiParent = Me
        FrmRegister.WindowState = FormWindowState.Maximized
        FrmRegister.ControlBox = False
        FrmRegister.Show()
    End Sub
End Class