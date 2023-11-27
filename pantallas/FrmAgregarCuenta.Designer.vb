<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarCuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.lblClienteId = New System.Windows.Forms.Label()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.txtTCuenta = New System.Windows.Forms.TextBox()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.txtSaldoInicial = New System.Windows.Forms.TextBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbCliente
        '
        Me.cbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(177, 62)
        Me.cbCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(160, 24)
        Me.cbCliente.TabIndex = 12
        '
        'lblClienteId
        '
        Me.lblClienteId.AutoSize = True
        Me.lblClienteId.Location = New System.Drawing.Point(41, 65)
        Me.lblClienteId.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClienteId.Name = "lblClienteId"
        Me.lblClienteId.Size = New System.Drawing.Size(48, 16)
        Me.lblClienteId.TabIndex = 13
        Me.lblClienteId.Text = "Cliente"
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.Location = New System.Drawing.Point(41, 135)
        Me.lblTipoCuenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(99, 16)
        Me.lblTipoCuenta.TabIndex = 14
        Me.lblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'txtTCuenta
        '
        Me.txtTCuenta.Location = New System.Drawing.Point(177, 135)
        Me.txtTCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTCuenta.Name = "txtTCuenta"
        Me.txtTCuenta.Size = New System.Drawing.Size(160, 22)
        Me.txtTCuenta.TabIndex = 15
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(41, 211)
        Me.lblSaldoInicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(80, 16)
        Me.lblSaldoInicial.TabIndex = 16
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'txtSaldoInicial
        '
        Me.txtSaldoInicial.Location = New System.Drawing.Point(177, 211)
        Me.txtSaldoInicial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSaldoInicial.Name = "txtSaldoInicial"
        Me.txtSaldoInicial.Size = New System.Drawing.Size(160, 22)
        Me.txtSaldoInicial.TabIndex = 17
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(111, 283)
        Me.btnAgregarCuenta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(133, 28)
        Me.btnAgregarCuenta.TabIndex = 18
        Me.btnAgregarCuenta.Text = "Agregar Cuenta"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = True
        '
        'FrmAgregarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(664, 554)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Controls.Add(Me.txtSaldoInicial)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.txtTCuenta)
        Me.Controls.Add(Me.lblTipoCuenta)
        Me.Controls.Add(Me.lblClienteId)
        Me.Controls.Add(Me.cbCliente)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmAgregarCuenta"
        Me.Text = "FrmAgregarCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents lblClienteId As Label
    Friend WithEvents lblTipoCuenta As Label
    Friend WithEvents txtTCuenta As TextBox
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents txtSaldoInicial As TextBox
    Friend WithEvents btnAgregarCuenta As Button
End Class
