﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearCliente
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
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(239, 121)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(167, 56)
        Me.txtDireccion.TabIndex = 7
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(25, 121)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(167, 22)
        Me.txtTelefono.TabIndex = 6
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(16, 347)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(153, 58)
        Me.btnAgregar.TabIndex = 12
        Me.btnAgregar.Text = "Agregar Cliente"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(256, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 29)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Agregar Cliente"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTelefono)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.txtApellido)
        Me.Panel1.Location = New System.Drawing.Point(16, 80)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(451, 238)
        Me.Panel1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Apellido"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Teléfono"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 17)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(28, 37)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(164, 22)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(239, 37)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(164, 22)
        Me.txtApellido.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(256, 347)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(153, 58)
        Me.btnUpdate.TabIndex = 14
        Me.btnUpdate.Text = "Actualizar Cliente"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'FrmCrearCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 492)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmCrearCliente"
        Me.Text = "FrmCrearCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUpdate As Button
End Class
