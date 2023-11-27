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
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.lblClienteId = New System.Windows.Forms.Label()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtTCuenta = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(141, 136)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(100, 23)
        Me.btnAgregarCuenta.TabIndex = 5
        Me.btnAgregarCuenta.Text = "Agregar Cuenta"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = True
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(141, 94)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(121, 20)
        Me.txtSaldoInicial.TabIndex = 6
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.Location = New System.Drawing.Point(12, 56)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoCuenta.TabIndex = 8
        Me.lblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(12, 97)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(64, 13)
        Me.lblSaldoInicial.TabIndex = 9
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(12, 18)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(39, 13)
        Me.lblClienteId.TabIndex = 10
        Me.lblClienteId.Text = "Cliente"
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(141, 15)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(121, 21)
        Me.cbCliente.TabIndex = 11
        '
        'txtTCuenta
        '
        Me.txtTCuenta.Location = New System.Drawing.Point(141, 53)
        Me.txtTCuenta.Name = "txtTCuenta"
        Me.txtTCuenta.Size = New System.Drawing.Size(121, 20)
        Me.txtTCuenta.TabIndex = 12
        '
        'FrmAgregarCuenta2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 178)
        Me.Controls.Add(Me.txtTCuenta)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.lblClienteId)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblTipoCuenta)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Name = "FrmAgregarCuenta2"
        Me.Text = "Agregar Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAgregarCuenta As Button
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents lblTipoCuenta As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents lblClienteId As Label
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtTCuenta As TextBox
End Class
