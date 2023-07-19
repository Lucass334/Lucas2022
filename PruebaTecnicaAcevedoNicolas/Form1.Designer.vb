<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NuevoClient = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewClientes = New System.Windows.Forms.DataGridView()
        Me.InsertClientes = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Insert = New System.Windows.Forms.Button()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.TextBoxtelefono = New System.Windows.Forms.TextBox()
        Me.TextBoxCliente = New System.Windows.Forms.TextBox()
        Me.Correo = New System.Windows.Forms.Label()
        Me.Telefono = New System.Windows.Forms.Label()
        Me.Cliente = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Precio = New System.Windows.Forms.Label()
        Me.TextBoxCategoria = New System.Windows.Forms.TextBox()
        Me.Categoria = New System.Windows.Forms.Label()
        Me.TextBoxPrecio = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreProducto = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InsertClientes.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(66, 42)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(664, 361)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.InsertClientes)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.DataGridViewClientes)
        Me.TabPage1.Controls.Add(Me.NuevoClient)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(656, 335)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NuevoClient
        '
        Me.NuevoClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoClient.Location = New System.Drawing.Point(115, 199)
        Me.NuevoClient.Name = "NuevoClient"
        Me.NuevoClient.Size = New System.Drawing.Size(149, 39)
        Me.NuevoClient.TabIndex = 8
        Me.NuevoClient.Text = "Nuevo"
        Me.NuevoClient.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(286, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Clientes"
        '
        'DataGridViewClientes
        '
        Me.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewClientes.Location = New System.Drawing.Point(104, 36)
        Me.DataGridViewClientes.Name = "DataGridViewClientes"
        Me.DataGridViewClientes.ReadOnly = True
        Me.DataGridViewClientes.Size = New System.Drawing.Size(472, 85)
        Me.DataGridViewClientes.TabIndex = 1
        '
        'InsertClientes
        '
        Me.InsertClientes.Controls.Add(Me.Label1)
        Me.InsertClientes.Controls.Add(Me.Insert)
        Me.InsertClientes.Controls.Add(Me.TextBoxCorreo)
        Me.InsertClientes.Controls.Add(Me.TextBoxtelefono)
        Me.InsertClientes.Controls.Add(Me.TextBoxCliente)
        Me.InsertClientes.Controls.Add(Me.Correo)
        Me.InsertClientes.Controls.Add(Me.Telefono)
        Me.InsertClientes.Controls.Add(Me.Cliente)
        Me.InsertClientes.Location = New System.Drawing.Point(104, 127)
        Me.InsertClientes.Name = "InsertClientes"
        Me.InsertClientes.Size = New System.Drawing.Size(472, 193)
        Me.InsertClientes.TabIndex = 0
        Me.InsertClientes.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nuevo Cliente"
        '
        'Insert
        '
        Me.Insert.Location = New System.Drawing.Point(249, 166)
        Me.Insert.Name = "Insert"
        Me.Insert.Size = New System.Drawing.Size(75, 23)
        Me.Insert.TabIndex = 6
        Me.Insert.Text = "Crear"
        Me.Insert.UseVisualStyleBackColor = True
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(176, 123)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxCorreo.TabIndex = 5
        '
        'TextBoxtelefono
        '
        Me.TextBoxtelefono.Location = New System.Drawing.Point(176, 90)
        Me.TextBoxtelefono.Name = "TextBoxtelefono"
        Me.TextBoxtelefono.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxtelefono.TabIndex = 4
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(176, 55)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxCliente.TabIndex = 3
        '
        'Correo
        '
        Me.Correo.AutoSize = True
        Me.Correo.Location = New System.Drawing.Point(97, 126)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(38, 13)
        Me.Correo.TabIndex = 2
        Me.Correo.Text = "Correo"
        '
        'Telefono
        '
        Me.Telefono.AutoSize = True
        Me.Telefono.Location = New System.Drawing.Point(96, 93)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(49, 13)
        Me.Telefono.TabIndex = 1
        Me.Telefono.Text = "Telefono"
        '
        'Cliente
        '
        Me.Cliente.AutoSize = True
        Me.Cliente.Location = New System.Drawing.Point(97, 58)
        Me.Cliente.Name = "Cliente"
        Me.Cliente.Size = New System.Drawing.Size(39, 13)
        Me.Cliente.TabIndex = 0
        Me.Cliente.Text = "Cliente"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(656, 335)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Nombre)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Precio)
        Me.Panel1.Controls.Add(Me.TextBoxCategoria)
        Me.Panel1.Controls.Add(Me.Categoria)
        Me.Panel1.Controls.Add(Me.TextBoxPrecio)
        Me.Panel1.Controls.Add(Me.TextBoxNombreProducto)
        Me.Panel1.Location = New System.Drawing.Point(168, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 244)
        Me.Panel1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nuevo Producto"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(32, 76)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(44, 13)
        Me.Nombre.TabIndex = 8
        Me.Nombre.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(184, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Crear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Precio
        '
        Me.Precio.AutoSize = True
        Me.Precio.Location = New System.Drawing.Point(31, 111)
        Me.Precio.Name = "Precio"
        Me.Precio.Size = New System.Drawing.Size(37, 13)
        Me.Precio.TabIndex = 9
        Me.Precio.Text = "Precio"
        '
        'TextBoxCategoria
        '
        Me.TextBoxCategoria.Location = New System.Drawing.Point(111, 141)
        Me.TextBoxCategoria.Name = "TextBoxCategoria"
        Me.TextBoxCategoria.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxCategoria.TabIndex = 13
        '
        'Categoria
        '
        Me.Categoria.AutoSize = True
        Me.Categoria.Location = New System.Drawing.Point(32, 144)
        Me.Categoria.Name = "Categoria"
        Me.Categoria.Size = New System.Drawing.Size(52, 13)
        Me.Categoria.TabIndex = 10
        Me.Categoria.Text = "Categoria"
        '
        'TextBoxPrecio
        '
        Me.TextBoxPrecio.Location = New System.Drawing.Point(111, 108)
        Me.TextBoxPrecio.Name = "TextBoxPrecio"
        Me.TextBoxPrecio.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxPrecio.TabIndex = 12
        '
        'TextBoxNombreProducto
        '
        Me.TextBoxNombreProducto.Location = New System.Drawing.Point(111, 73)
        Me.TextBoxNombreProducto.Name = "TextBoxNombreProducto"
        Me.TextBoxNombreProducto.Size = New System.Drawing.Size(148, 20)
        Me.TextBoxNombreProducto.TabIndex = 11
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(270, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 39)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(425, 199)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 39)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Modificar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DataGridViewClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InsertClientes.ResumeLayout(False)
        Me.InsertClientes.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents InsertClientes As Panel
    Friend WithEvents Telefono As Label
    Friend WithEvents Cliente As Label
    Friend WithEvents Correo As Label
    Friend WithEvents Insert As Button
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents TextBoxtelefono As TextBox
    Friend WithEvents TextBoxCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Nombre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Precio As Label
    Friend WithEvents TextBoxCategoria As TextBox
    Friend WithEvents Categoria As Label
    Friend WithEvents TextBoxPrecio As TextBox
    Friend WithEvents TextBoxNombreProducto As TextBox
    Friend WithEvents DataGridViewClientes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents NuevoClient As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
End Class
