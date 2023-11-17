Public Class FrmLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmPrincipal.Show()
        FrmAuth.Hide()

        Me.Close()
    End Sub
End Class