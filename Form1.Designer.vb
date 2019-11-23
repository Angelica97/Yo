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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.cod_Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pro_Adquirido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_consumo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtcanArticulo = New System.Windows.Forms.TextBox()
        Me.txtidArticulo = New System.Windows.Forms.TextBox()
        Me.txtnomArticulo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnRegistrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DtpEntrada = New System.Windows.Forms.DateTimePicker()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.idArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nomArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtpCompra = New System.Windows.Forms.DateTimePicker()
        Me.txtCanCliente = New System.Windows.Forms.TextBox()
        Me.txtArticulo = New System.Windows.Forms.TextBox()
        Me.txtIdcliente = New System.Windows.Forms.TextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvCliente = New System.Windows.Forms.DataGridView()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadArt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha_Compra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvVentas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 33)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(834, 307)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Registro de ventas Mensuales"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AllowUserToOrderColumns = True
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_Cliente, Me.Pro_Adquirido, Me.Cant_Producto, Me.Fecha_consumo, Me.Precio_Total})
        Me.dgvVentas.Location = New System.Drawing.Point(8, 6)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.Size = New System.Drawing.Size(822, 294)
        Me.dgvVentas.TabIndex = 42
        '
        'cod_Cliente
        '
        Me.cod_Cliente.HeaderText = "Codigo del Cliente"
        Me.cod_Cliente.Name = "cod_Cliente"
        Me.cod_Cliente.ReadOnly = True
        Me.cod_Cliente.Width = 200
        '
        'Pro_Adquirido
        '
        Me.Pro_Adquirido.HeaderText = "Producto Adquirido"
        Me.Pro_Adquirido.Name = "Pro_Adquirido"
        Me.Pro_Adquirido.ReadOnly = True
        Me.Pro_Adquirido.Width = 200
        '
        'Cant_Producto
        '
        Me.Cant_Producto.HeaderText = "Cantidad del Producto"
        Me.Cant_Producto.Name = "Cant_Producto"
        Me.Cant_Producto.ReadOnly = True
        Me.Cant_Producto.Width = 200
        '
        'Fecha_consumo
        '
        Me.Fecha_consumo.HeaderText = "Fecha de compra"
        Me.Fecha_consumo.Name = "Fecha_consumo"
        Me.Fecha_consumo.ReadOnly = True
        Me.Fecha_consumo.Width = 200
        '
        'Precio_Total
        '
        Me.Precio_Total.HeaderText = "Precio Total"
        Me.Precio_Total.Name = "Precio_Total"
        Me.Precio_Total.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtcanArticulo)
        Me.TabPage2.Controls.Add(Me.txtidArticulo)
        Me.TabPage2.Controls.Add(Me.txtnomArticulo)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.BtnRegistrar)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.DtpEntrada)
        Me.TabPage2.Controls.Add(Me.DgvArticulos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 33)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(834, 307)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro de articulos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtcanArticulo
        '
        Me.txtcanArticulo.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcanArticulo.Location = New System.Drawing.Point(87, 149)
        Me.txtcanArticulo.Name = "txtcanArticulo"
        Me.txtcanArticulo.Size = New System.Drawing.Size(172, 24)
        Me.txtcanArticulo.TabIndex = 52
        '
        'txtidArticulo
        '
        Me.txtidArticulo.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidArticulo.Location = New System.Drawing.Point(87, 70)
        Me.txtidArticulo.Name = "txtidArticulo"
        Me.txtidArticulo.Size = New System.Drawing.Size(172, 24)
        Me.txtidArticulo.TabIndex = 49
        '
        'txtnomArticulo
        '
        Me.txtnomArticulo.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnomArticulo.Location = New System.Drawing.Point(87, 110)
        Me.txtnomArticulo.Name = "txtnomArticulo"
        Me.txtnomArticulo.Size = New System.Drawing.Size(172, 24)
        Me.txtnomArticulo.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Cantidad:"
        '
        'BtnRegistrar
        '
        Me.BtnRegistrar.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegistrar.Location = New System.Drawing.Point(164, 269)
        Me.BtnRegistrar.Name = "BtnRegistrar"
        Me.BtnRegistrar.Size = New System.Drawing.Size(77, 23)
        Me.BtnRegistrar.TabIndex = 50
        Me.BtnRegistrar.Text = "Registrar"
        Me.BtnRegistrar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "IdArticulo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Articulo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Fecha de entrada:"
        '
        'DtpEntrada
        '
        Me.DtpEntrada.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpEntrada.Location = New System.Drawing.Point(23, 221)
        Me.DtpEntrada.Name = "DtpEntrada"
        Me.DtpEntrada.Size = New System.Drawing.Size(249, 24)
        Me.DtpEntrada.TabIndex = 42
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.AllowUserToOrderColumns = True
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idArticulo, Me.nomArticulo, Me.cantArticulo, Me.fecha_Entrada})
        Me.DgvArticulos.Location = New System.Drawing.Point(280, 13)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.Size = New System.Drawing.Size(532, 281)
        Me.DgvArticulos.TabIndex = 41
        '
        'idArticulo
        '
        Me.idArticulo.HeaderText = "IdArticulo"
        Me.idArticulo.Name = "idArticulo"
        Me.idArticulo.ReadOnly = True
        Me.idArticulo.Width = 105
        '
        'nomArticulo
        '
        Me.nomArticulo.HeaderText = "Articulo"
        Me.nomArticulo.Name = "nomArticulo"
        Me.nomArticulo.ReadOnly = True
        '
        'cantArticulo
        '
        Me.cantArticulo.HeaderText = "Cantidad"
        Me.cantArticulo.Name = "cantArticulo"
        Me.cantArticulo.ReadOnly = True
        '
        'fecha_Entrada
        '
        Me.fecha_Entrada.HeaderText = "Fecha de entrada"
        Me.fecha_Entrada.Name = "fecha_Entrada"
        Me.fecha_Entrada.ReadOnly = True
        Me.fecha_Entrada.Width = 190
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.DtpCompra)
        Me.TabPage1.Controls.Add(Me.txtCanCliente)
        Me.TabPage1.Controls.Add(Me.txtArticulo)
        Me.TabPage1.Controls.Add(Me.txtIdcliente)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.DgvCliente)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.BtnIngresar)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 32)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(834, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Registrar cliente"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 18)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Fecha de compra:"
        '
        'DtpCompra
        '
        Me.DtpCompra.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpCompra.Location = New System.Drawing.Point(19, 223)
        Me.DtpCompra.Name = "DtpCompra"
        Me.DtpCompra.Size = New System.Drawing.Size(249, 26)
        Me.DtpCompra.TabIndex = 55
        '
        'txtCanCliente
        '
        Me.txtCanCliente.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanCliente.Location = New System.Drawing.Point(117, 159)
        Me.txtCanCliente.Name = "txtCanCliente"
        Me.txtCanCliente.Size = New System.Drawing.Size(172, 26)
        Me.txtCanCliente.TabIndex = 54
        '
        'txtArticulo
        '
        Me.txtArticulo.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(118, 119)
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Size = New System.Drawing.Size(172, 26)
        Me.txtArticulo.TabIndex = 38
        '
        'txtIdcliente
        '
        Me.txtIdcliente.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdcliente.Location = New System.Drawing.Point(117, 44)
        Me.txtIdcliente.Name = "txtIdcliente"
        Me.txtIdcliente.Size = New System.Drawing.Size(172, 26)
        Me.txtIdcliente.TabIndex = 31
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(117, 79)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(172, 26)
        Me.txtCliente.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Cantidad:"
        '
        'DgvCliente
        '
        Me.DgvCliente.AllowUserToAddRows = False
        Me.DgvCliente.AllowUserToDeleteRows = False
        Me.DgvCliente.AllowUserToOrderColumns = True
        Me.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigo, Me.cliente, Me.articulos, Me.cantidadArt, Me.fecha_Compra})
        Me.DgvCliente.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DgvCliente.Location = New System.Drawing.Point(296, 20)
        Me.DgvCliente.Name = "DgvCliente"
        Me.DgvCliente.ReadOnly = True
        Me.DgvCliente.Size = New System.Drawing.Size(532, 281)
        Me.DgvCliente.TabIndex = 42
        '
        'codigo
        '
        Me.codigo.HeaderText = "IdCliente"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'cliente
        '
        Me.cliente.HeaderText = "Cliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        '
        'articulos
        '
        Me.articulos.HeaderText = "Articulo"
        Me.articulos.Name = "articulos"
        Me.articulos.ReadOnly = True
        '
        'cantidadArt
        '
        Me.cantidadArt.HeaderText = "Cantidad"
        Me.cantidadArt.Name = "cantidadArt"
        Me.cantidadArt.ReadOnly = True
        '
        'fecha_Compra
        '
        Me.fecha_Compra.HeaderText = "Fecha de Compra"
        Me.fecha_Compra.Name = "fecha_Compra"
        Me.fecha_Compra.ReadOnly = True
        Me.fecha_Compra.Width = 190
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 18)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Articulo:"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Location = New System.Drawing.Point(96, 262)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(84, 27)
        Me.BtnIngresar.TabIndex = 36
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "IdCliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cliente:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Constantia", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(842, 344)
        Me.TabControl1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 357)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents idCliente As DataGridViewTextBoxColumn
    Friend WithEvents Articulo As DataGridViewTextBoxColumn
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents RepuestosdeVeiculosDataSet1BindingSource As BindingSource
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents cod_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Pro_Adquirido As DataGridViewTextBoxColumn
    Friend WithEvents Cant_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_consumo As DataGridViewTextBoxColumn
    Friend WithEvents Precio_Total As DataGridViewTextBoxColumn
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txtcanArticulo As TextBox
    Friend WithEvents txtidArticulo As TextBox
    Friend WithEvents txtnomArticulo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnRegistrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DtpEntrada As DateTimePicker
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents idArticulo As DataGridViewTextBoxColumn
    Friend WithEvents nomArticulo As DataGridViewTextBoxColumn
    Friend WithEvents cantArticulo As DataGridViewTextBoxColumn
    Friend WithEvents fecha_Entrada As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpCompra As DateTimePicker
    Friend WithEvents txtCanCliente As TextBox
    Friend WithEvents txtArticulo As TextBox
    Friend WithEvents txtIdcliente As TextBox
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvCliente As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents articulos As DataGridViewTextBoxColumn
    Friend WithEvents cantidadArt As DataGridViewTextBoxColumn
    Friend WithEvents fecha_Compra As DataGridViewTextBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents BtnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
End Class
