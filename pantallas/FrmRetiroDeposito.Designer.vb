<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRetiroDeposito
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEnviar = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.cbCuenta = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.txtSaldo = New System.Windows.Forms.Label()
        Me.tbSaldo = New System.Windows.Forms.TextBox()
        Me.txtTransaccion = New System.Windows.Forms.Label()
        Me.txtCuenta = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.Button27 = New System.Windows.Forms.Button()
        Me.Button28 = New System.Windows.Forms.Button()
        Me.Button29 = New System.Windows.Forms.Button()
        Me.Button30 = New System.Windows.Forms.Button()
        Me.Button31 = New System.Windows.Forms.Button()
        Me.Button32 = New System.Windows.Forms.Button()
        Me.Button33 = New System.Windows.Forms.Button()
        Me.Button34 = New System.Windows.Forms.Button()
        Me.Button35 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.btnEnviar)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(12, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(582, 358)
        Me.Panel3.TabIndex = 21
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(15, 274)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(74, 45)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Location = New System.Drawing.Point(481, 274)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(88, 45)
        Me.btnEnviar.TabIndex = 15
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.cbTipo)
        Me.Panel4.Controls.Add(Me.cbCuenta)
        Me.Panel4.Controls.Add(Me.cbCliente)
        Me.Panel4.Controls.Add(Me.txtSaldo)
        Me.Panel4.Controls.Add(Me.tbSaldo)
        Me.Panel4.Controls.Add(Me.txtTransaccion)
        Me.Panel4.Controls.Add(Me.txtCuenta)
        Me.Panel4.Controls.Add(Me.txtNombre)
        Me.Panel4.Controls.Add(Me.Button27)
        Me.Panel4.Controls.Add(Me.Button28)
        Me.Panel4.Controls.Add(Me.Button29)
        Me.Panel4.Controls.Add(Me.Button30)
        Me.Panel4.Controls.Add(Me.Button31)
        Me.Panel4.Controls.Add(Me.Button32)
        Me.Panel4.Controls.Add(Me.Button33)
        Me.Panel4.Controls.Add(Me.Button34)
        Me.Panel4.Controls.Add(Me.Button35)
        Me.Panel4.Location = New System.Drawing.Point(95, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(374, 272)
        Me.Panel4.TabIndex = 10
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"retiro", "deposito"})
        Me.cbTipo.Location = New System.Drawing.Point(202, 132)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(160, 24)
        Me.cbTipo.TabIndex = 22
        '
        'cbCuenta
        '
        Me.cbCuenta.FormattingEnabled = True
        Me.cbCuenta.Location = New System.Drawing.Point(202, 70)
        Me.cbCuenta.Name = "cbCuenta"
        Me.cbCuenta.Size = New System.Drawing.Size(160, 24)
        Me.cbCuenta.TabIndex = 21
        '
        'cbCliente
        '
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(202, 16)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(160, 24)
        Me.cbCliente.TabIndex = 20
        '
        'txtSaldo
        '
        Me.txtSaldo.AutoSize = True
        Me.txtSaldo.Location = New System.Drawing.Point(13, 196)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(43, 16)
        Me.txtSaldo.TabIndex = 18
        Me.txtSaldo.Text = "Saldo"
        '
        'tbSaldo
        '
        Me.tbSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbSaldo.Location = New System.Drawing.Point(202, 190)
        Me.tbSaldo.Name = "tbSaldo"
        Me.tbSaldo.Size = New System.Drawing.Size(160, 22)
        Me.tbSaldo.TabIndex = 17
        '
        'txtTransaccion
        '
        Me.txtTransaccion.AutoSize = True
        Me.txtTransaccion.Location = New System.Drawing.Point(13, 135)
        Me.txtTransaccion.Name = "txtTransaccion"
        Me.txtTransaccion.Size = New System.Drawing.Size(132, 16)
        Me.txtTransaccion.TabIndex = 16
        Me.txtTransaccion.Text = "Tipo de Transacción"
        '
        'txtCuenta
        '
        Me.txtCuenta.AutoSize = True
        Me.txtCuenta.Location = New System.Drawing.Point(13, 73)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(99, 16)
        Me.txtCuenta.TabIndex = 14
        Me.txtCuenta.Text = "Tipo de Cuenta"
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.Location = New System.Drawing.Point(13, 19)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(48, 16)
        Me.txtNombre.TabIndex = 12
        Me.txtNombre.Text = "Cliente"
        '
        'Button27
        '
        Me.Button27.Location = New System.Drawing.Point(298, 483)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(64, 45)
        Me.Button27.TabIndex = 9
        Me.Button27.Text = "Button27"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'Button28
        '
        Me.Button28.Location = New System.Drawing.Point(298, 433)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(64, 45)
        Me.Button28.TabIndex = 8
        Me.Button28.Text = "Button28"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Location = New System.Drawing.Point(158, 483)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(64, 45)
        Me.Button29.TabIndex = 7
        Me.Button29.Text = "Button29"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Location = New System.Drawing.Point(228, 483)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(64, 45)
        Me.Button30.TabIndex = 6
        Me.Button30.Text = "Button30"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Location = New System.Drawing.Point(228, 433)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(64, 45)
        Me.Button31.TabIndex = 5
        Me.Button31.Text = "Button31"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.Location = New System.Drawing.Point(158, 433)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(64, 45)
        Me.Button32.TabIndex = 4
        Me.Button32.Text = "Button32"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.Location = New System.Drawing.Point(298, 382)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(64, 45)
        Me.Button33.TabIndex = 3
        Me.Button33.Text = "Button33"
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Location = New System.Drawing.Point(228, 382)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(64, 45)
        Me.Button34.TabIndex = 2
        Me.Button34.Text = "Button34"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button35
        '
        Me.Button35.Location = New System.Drawing.Point(158, 382)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(64, 45)
        Me.Button35.TabIndex = 1
        Me.Button35.Text = "Button35"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(200, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(150, 29)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Banco FAGA"
        '
        'FrmRetiroDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(924, 751)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FrmRetiroDeposito"
        Me.Text = "FrmRetiroDeposito"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEnviar As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cbCuenta As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents txtSaldo As Label
    Friend WithEvents tbSaldo As TextBox
    Friend WithEvents txtTransaccion As Label
    Friend WithEvents txtCuenta As Label
    Friend WithEvents txtNombre As Label
    Friend WithEvents Button27 As Button
    Friend WithEvents Button28 As Button
    Friend WithEvents Button29 As Button
    Friend WithEvents Button30 As Button
    Friend WithEvents Button31 As Button
    Friend WithEvents Button32 As Button
    Friend WithEvents Button33 As Button
    Friend WithEvents Button34 As Button
    Friend WithEvents Button35 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cbTipo As ComboBox
End Class
