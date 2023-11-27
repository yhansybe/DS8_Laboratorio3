<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgregarCuenta
    Inherits System.Windows.Forms.Form

    ' Diseñador se descarta para no realizar cambios en el código.
    Private components As System.ComponentModel.IContainer

    ' Nota: el siguiente procedimiento es requerido por el diseñador de Windows Forms
    ' Puede modificarse con el diseñador de formularios de Windows Forms.  
    ' No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.lblTipoCuenta = New System.Windows.Forms.Label()
        Me.lblSaldoInicial = New System.Windows.Forms.Label()
        Me.tbSaldoInicial = New System.Windows.Forms.TextBox()
        Me.btnAgregarCuenta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.FormattingEnabled = True
        Me.cbTipoCuenta.Location = New System.Drawing.Point(133, 25)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoCuenta.TabIndex = 0
        '
        'lblTipoCuenta
        '
        Me.lblTipoCuenta.AutoSize = True
        Me.lblTipoCuenta.Location = New System.Drawing.Point(13, 28)
        Me.lblTipoCuenta.Name = "lblTipoCuenta"
        Me.lblTipoCuenta.Size = New System.Drawing.Size(80, 13)
        Me.lblTipoCuenta.TabIndex = 1
        Me.lblTipoCuenta.Text = "Tipo de Cuenta"
        '
        'lblSaldoInicial
        '
        Me.lblSaldoInicial.AutoSize = True
        Me.lblSaldoInicial.Location = New System.Drawing.Point(13, 66)
        Me.lblSaldoInicial.Name = "lblSaldoInicial"
        Me.lblSaldoInicial.Size = New System.Drawing.Size(68, 13)
        Me.lblSaldoInicial.TabIndex = 2
        Me.lblSaldoInicial.Text = "Saldo Inicial"
        '
        'tbSaldoInicial
        '
        Me.tbSaldoInicial.Location = New System.Drawing.Point(133, 63)
        Me.tbSaldoInicial.Name = "tbSaldoInicial"
        Me.tbSaldoInicial.Size = New System.Drawing.Size(100, 20)
        Me.tbSaldoInicial.TabIndex = 3
        '
        'btnAgregarCuenta
        '
        Me.btnAgregarCuenta.Location = New System.Drawing.Point(133, 110)
        Me.btnAgregarCuenta.Name = "btnAgregarCuenta"
        Me.btnAgregarCuenta.Size = New System.Drawing.Size(100, 23)
        Me.btnAgregarCuenta.TabIndex = 4
        Me.btnAgregarCuenta.Text = "Agregar Cuenta"
        Me.btnAgregarCuenta.UseVisualStyleBackColor = True
        '
        'FrmAgregarCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 162)
        Me.Controls.Add(Me.btnAgregarCuenta)
        Me.Controls.Add(Me.tbSaldoInicial)
        Me.Controls.Add(Me.lblSaldoInicial)
        Me.Controls.Add(Me.lblTipoCuenta)
        Me.Controls.Add(Me.cbTipoCuenta)
        Me.Name = "FrmAgregarCuenta"
        Me.Text = "Agregar Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbTipoCuenta As ComboBox
    Friend WithEvents lblTipoCuenta As Label
    Friend WithEvents lblSaldoInicial As Label
    Friend WithEvents tbSaldoInicial As TextBox
    Friend WithEvents btnAgregarCuenta As Button
End Class
