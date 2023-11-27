<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCuenta2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.tbSaldoInicial = New System.Windows.Forms.TextBox()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(141, 113)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(100, 23)
        Me.btnAgregarCuenta.TabIndex = 5
        Me.btnAgregarCuenta.Text = "Agregar Cuenta"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = True
        '
        'tbSaldoInicial
        '
        Me.tbSaldoInicial.Location = New System.Drawing.Point(141, 71)
        Me.tbSaldoInicial.Name = "tbSaldoInicial"
        Me.tbSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.tbSaldoInicial.TabIndex = 6
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.FormattingEnabled = True
        Me.cbTipoCuenta.Location = New System.Drawing.Point(141, 30)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoCuenta.TabIndex = 7
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.Location = New System.Drawing.Point(12, 33)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoCuenta.TabIndex = 8
        Me.lblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(12, 74)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(64, 13)
        Me.lblSaldoInicial.TabIndex = 9
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'FrmAgregarCuenta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblTipoCuenta)
        Me.Controls.Add(Me.cbTipoCuenta)
        Me.Controls.Add(Me.tbSaldoInicial)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Name = "FrmAgregarCuenta2"
        Me.Text = "Agregar Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarCuenta As Button
    Friend WithEvents tbSaldoInicial As TextBox
    Friend WithEvents cbTipoCuenta As ComboBox
    Friend WithEvents lblTipoCuenta As Label
    Friend WithEvents lblSaldoInicial As Label
End Class
