<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ORDENAR
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ORDENAR))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        BT_FACTURAS = New Button()
        Label2 = New Label()
        BT_SALIR = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TBT_MESA = New TextBox()
        TBT_ID_PRODUCTO = New TextBox()
        TBT_NOM_PRODUCTO = New TextBox()
        TBT_PRECIO = New TextBox()
        Label7 = New Label()
        TBT_NON_CLIENTE = New TextBox()
        TBT_CANTIDAD = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        BT_AÑADIR = New Button()
        BT_ELIMINAR = New Button()
        BT_ORDENAR = New Button()
        DG_PRODUCTOS = New DataGridView()
        DG_PEDIDOS = New DataGridView()
        BT_AÑADIR_CLI = New Button()
        TBT_ID_CLIENTE = New TextBox()
        TBT_SUBTOTAL = New TextBox()
        Label10 = New Label()
        TBT_NUM_PEDIDOS = New TextBox()
        BT_PAGAR = New Button()
        Label11 = New Label()
        TBT_TOTAL = New TextBox()
        BT_EFECTIVO = New Button()
        TB_TARJETA = New Button()
        TBT_pedido_num = New TextBox()
        GroupBox1.SuspendLayout()
        CType(DG_PRODUCTOS, ComponentModel.ISupportInitialize).BeginInit()
        CType(DG_PEDIDOS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(BT_FACTURAS)
        GroupBox1.Location = New Point(2, 4)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(698, 102)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.CalendarMonthBackground = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        DateTimePicker1.Location = New Point(11, 12)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(130, 30)
        DateTimePicker1.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(198, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(379, 68)
        Label3.TabIndex = 6
        Label3.Text = "PIZZERIA SV"
        ' 
        ' BT_FACTURAS
        ' 
        BT_FACTURAS.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        BT_FACTURAS.Location = New Point(608, 8)
        BT_FACTURAS.Name = "BT_FACTURAS"
        BT_FACTURAS.Size = New Size(86, 31)
        BT_FACTURAS.TabIndex = 38
        BT_FACTURAS.Text = "Facturas"
        BT_FACTURAS.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(53, 365)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 32)
        Label2.TabIndex = 3
        Label2.Text = "Mesa : "
        ' 
        ' BT_SALIR
        ' 
        BT_SALIR.BackColor = Color.Transparent
        BT_SALIR.BackgroundImage = CType(resources.GetObject("BT_SALIR.BackgroundImage"), Image)
        BT_SALIR.ForeColor = Color.Transparent
        BT_SALIR.Location = New Point(13, 843)
        BT_SALIR.Margin = New Padding(4, 3, 4, 3)
        BT_SALIR.Name = "BT_SALIR"
        BT_SALIR.Size = New Size(60, 55)
        BT_SALIR.TabIndex = 8
        BT_SALIR.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(49, 414)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 32)
        Label4.TabIndex = 19
        Label4.Text = "Codigo :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(361, 365)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(151, 32)
        Label5.TabIndex = 20
        Label5.Text = "Productos :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(351, 467)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(161, 32)
        Label6.TabIndex = 21
        Label6.Text = "Precio en $ :"
        ' 
        ' TBT_MESA
        ' 
        TBT_MESA.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_MESA.Location = New Point(168, 368)
        TBT_MESA.Multiline = True
        TBT_MESA.Name = "TBT_MESA"
        TBT_MESA.Size = New Size(103, 30)
        TBT_MESA.TabIndex = 22
        TBT_MESA.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_ID_PRODUCTO
        ' 
        TBT_ID_PRODUCTO.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_ID_PRODUCTO.Location = New Point(168, 416)
        TBT_ID_PRODUCTO.Multiline = True
        TBT_ID_PRODUCTO.Name = "TBT_ID_PRODUCTO"
        TBT_ID_PRODUCTO.Size = New Size(103, 30)
        TBT_ID_PRODUCTO.TabIndex = 23
        TBT_ID_PRODUCTO.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_NOM_PRODUCTO
        ' 
        TBT_NOM_PRODUCTO.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_NOM_PRODUCTO.Location = New Point(538, 367)
        TBT_NOM_PRODUCTO.Multiline = True
        TBT_NOM_PRODUCTO.Name = "TBT_NOM_PRODUCTO"
        TBT_NOM_PRODUCTO.Size = New Size(103, 30)
        TBT_NOM_PRODUCTO.TabIndex = 24
        TBT_NOM_PRODUCTO.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_PRECIO
        ' 
        TBT_PRECIO.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_PRECIO.Location = New Point(538, 471)
        TBT_PRECIO.Multiline = True
        TBT_PRECIO.Name = "TBT_PRECIO"
        TBT_PRECIO.Size = New Size(103, 30)
        TBT_PRECIO.TabIndex = 25
        TBT_PRECIO.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(45, 469)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(108, 32)
        Label7.TabIndex = 26
        Label7.Text = "Cliente:"
        ' 
        ' TBT_NON_CLIENTE
        ' 
        TBT_NON_CLIENTE.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_NON_CLIENTE.Location = New Point(168, 456)
        TBT_NON_CLIENTE.Multiline = True
        TBT_NON_CLIENTE.Name = "TBT_NON_CLIENTE"
        TBT_NON_CLIENTE.Size = New Size(103, 30)
        TBT_NON_CLIENTE.TabIndex = 27
        TBT_NON_CLIENTE.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_CANTIDAD
        ' 
        TBT_CANTIDAD.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_CANTIDAD.Location = New Point(538, 416)
        TBT_CANTIDAD.Multiline = True
        TBT_CANTIDAD.Name = "TBT_CANTIDAD"
        TBT_CANTIDAD.Size = New Size(102, 30)
        TBT_CANTIDAD.TabIndex = 30
        TBT_CANTIDAD.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(360, 414)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(143, 32)
        Label8.TabIndex = 29
        Label8.Text = "Cantidad :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(283, 122)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(117, 38)
        Label9.TabIndex = 31
        Label9.Text = "Pedido"
        ' 
        ' BT_AÑADIR
        ' 
        BT_AÑADIR.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BT_AÑADIR.Location = New Point(473, 520)
        BT_AÑADIR.Name = "BT_AÑADIR"
        BT_AÑADIR.Size = New Size(168, 31)
        BT_AÑADIR.TabIndex = 32
        BT_AÑADIR.Text = "Añadir"
        BT_AÑADIR.UseVisualStyleBackColor = False
        ' 
        ' BT_ELIMINAR
        ' 
        BT_ELIMINAR.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BT_ELIMINAR.Location = New Point(45, 520)
        BT_ELIMINAR.Name = "BT_ELIMINAR"
        BT_ELIMINAR.Size = New Size(168, 31)
        BT_ELIMINAR.TabIndex = 33
        BT_ELIMINAR.Text = "Eliminar"
        BT_ELIMINAR.UseVisualStyleBackColor = False
        ' 
        ' BT_ORDENAR
        ' 
        BT_ORDENAR.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BT_ORDENAR.Location = New Point(261, 521)
        BT_ORDENAR.Name = "BT_ORDENAR"
        BT_ORDENAR.Size = New Size(168, 31)
        BT_ORDENAR.TabIndex = 34
        BT_ORDENAR.Text = "Ordenar"
        BT_ORDENAR.UseVisualStyleBackColor = False
        ' 
        ' DG_PRODUCTOS
        ' 
        DG_PRODUCTOS.AllowUserToAddRows = False
        DG_PRODUCTOS.AllowUserToDeleteRows = False
        DG_PRODUCTOS.AllowUserToResizeColumns = False
        DG_PRODUCTOS.AllowUserToResizeRows = False
        DG_PRODUCTOS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DG_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DG_PRODUCTOS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_PRODUCTOS.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DG_PRODUCTOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DG_PRODUCTOS.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DG_PRODUCTOS.DefaultCellStyle = DataGridViewCellStyle2
        DG_PRODUCTOS.Location = New Point(53, 570)
        DG_PRODUCTOS.Margin = New Padding(4, 3, 4, 3)
        DG_PRODUCTOS.Name = "DG_PRODUCTOS"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkGray
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkGray
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DG_PRODUCTOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DG_PRODUCTOS.RowHeadersWidth = 51
        DG_PRODUCTOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_PRODUCTOS.Size = New Size(588, 192)
        DG_PRODUCTOS.TabIndex = 15
        ' 
        ' DG_PEDIDOS
        ' 
        DG_PEDIDOS.AllowUserToAddRows = False
        DG_PEDIDOS.AllowUserToDeleteRows = False
        DG_PEDIDOS.AllowUserToResizeColumns = False
        DG_PEDIDOS.AllowUserToResizeRows = False
        DG_PEDIDOS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DG_PEDIDOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DG_PEDIDOS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_PEDIDOS.BackgroundColor = Color.LightGray
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.Gray
        DataGridViewCellStyle4.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle4.SelectionBackColor = Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DG_PEDIDOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        DG_PEDIDOS.ColumnHeadersHeight = 29
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.Gainsboro
        DataGridViewCellStyle5.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DG_PEDIDOS.DefaultCellStyle = DataGridViewCellStyle5
        DG_PEDIDOS.Location = New Point(45, 163)
        DG_PEDIDOS.Margin = New Padding(4, 3, 4, 3)
        DG_PEDIDOS.Name = "DG_PEDIDOS"
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.DarkGray
        DataGridViewCellStyle6.Font = New Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle6.SelectionForeColor = Color.DarkGray
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        DG_PEDIDOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        DG_PEDIDOS.RowHeadersWidth = 51
        DG_PEDIDOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_PEDIDOS.Size = New Size(596, 192)
        DG_PEDIDOS.TabIndex = 35
        ' 
        ' BT_AÑADIR_CLI
        ' 
        BT_AÑADIR_CLI.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        BT_AÑADIR_CLI.Location = New Point(277, 475)
        BT_AÑADIR_CLI.Name = "BT_AÑADIR_CLI"
        BT_AÑADIR_CLI.Size = New Size(27, 27)
        BT_AÑADIR_CLI.TabIndex = 36
        BT_AÑADIR_CLI.Text = "+"
        BT_AÑADIR_CLI.UseVisualStyleBackColor = False
        ' 
        ' TBT_ID_CLIENTE
        ' 
        TBT_ID_CLIENTE.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_ID_CLIENTE.Location = New Point(168, 487)
        TBT_ID_CLIENTE.Multiline = True
        TBT_ID_CLIENTE.Name = "TBT_ID_CLIENTE"
        TBT_ID_CLIENTE.Size = New Size(103, 30)
        TBT_ID_CLIENTE.TabIndex = 37
        TBT_ID_CLIENTE.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_SUBTOTAL
        ' 
        TBT_SUBTOTAL.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_SUBTOTAL.Location = New Point(351, 809)
        TBT_SUBTOTAL.Multiline = True
        TBT_SUBTOTAL.Name = "TBT_SUBTOTAL"
        TBT_SUBTOTAL.Size = New Size(103, 30)
        TBT_SUBTOTAL.TabIndex = 39
        TBT_SUBTOTAL.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(200, 807)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(179, 32)
        Label10.TabIndex = 40
        Label10.Text = "Subotal en $ :"
        ' 
        ' TBT_NUM_PEDIDOS
        ' 
        TBT_NUM_PEDIDOS.BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        TBT_NUM_PEDIDOS.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_NUM_PEDIDOS.Location = New Point(404, 126)
        TBT_NUM_PEDIDOS.Multiline = True
        TBT_NUM_PEDIDOS.Name = "TBT_NUM_PEDIDOS"
        TBT_NUM_PEDIDOS.Size = New Size(25, 30)
        TBT_NUM_PEDIDOS.TabIndex = 41
        TBT_NUM_PEDIDOS.TextAlign = HorizontalAlignment.Center
        ' 
        ' BT_PAGAR
        ' 
        BT_PAGAR.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        BT_PAGAR.Location = New Point(560, 843)
        BT_PAGAR.Name = "BT_PAGAR"
        BT_PAGAR.Size = New Size(116, 31)
        BT_PAGAR.TabIndex = 42
        BT_PAGAR.Text = "Pagar"
        BT_PAGAR.UseVisualStyleBackColor = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(244, 851)
        Label11.Margin = New Padding(4, 0, 4, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(90, 32)
        Label11.TabIndex = 44
        Label11.Text = "Total :"
        ' 
        ' TBT_TOTAL
        ' 
        TBT_TOTAL.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_TOTAL.Location = New Point(351, 853)
        TBT_TOTAL.Multiline = True
        TBT_TOTAL.Name = "TBT_TOTAL"
        TBT_TOTAL.Size = New Size(103, 30)
        TBT_TOTAL.TabIndex = 43
        TBT_TOTAL.TextAlign = HorizontalAlignment.Center
        ' 
        ' BT_EFECTIVO
        ' 
        BT_EFECTIVO.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        BT_EFECTIVO.Location = New Point(351, 767)
        BT_EFECTIVO.Name = "BT_EFECTIVO"
        BT_EFECTIVO.Size = New Size(116, 31)
        BT_EFECTIVO.TabIndex = 47
        BT_EFECTIVO.Text = "Efectivo"
        BT_EFECTIVO.UseVisualStyleBackColor = False
        ' 
        ' TB_TARJETA
        ' 
        TB_TARJETA.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        TB_TARJETA.Location = New Point(205, 767)
        TB_TARJETA.Name = "TB_TARJETA"
        TB_TARJETA.Size = New Size(116, 31)
        TB_TARJETA.TabIndex = 48
        TB_TARJETA.Text = "Tarjeta"
        TB_TARJETA.UseVisualStyleBackColor = False
        ' 
        ' TBT_pedido_num
        ' 
        TBT_pedido_num.BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        TBT_pedido_num.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_pedido_num.Location = New Point(453, 202)
        TBT_pedido_num.Multiline = True
        TBT_pedido_num.Name = "TBT_pedido_num"
        TBT_pedido_num.Size = New Size(25, 30)
        TBT_pedido_num.TabIndex = 49
        TBT_pedido_num.TextAlign = HorizontalAlignment.Center
        ' 
        ' ORDENAR
        ' 
        AutoScaleDimensions = New SizeF(11F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        ClientSize = New Size(704, 898)
        Controls.Add(TB_TARJETA)
        Controls.Add(BT_EFECTIVO)
        Controls.Add(Label11)
        Controls.Add(TBT_TOTAL)
        Controls.Add(BT_PAGAR)
        Controls.Add(TBT_NUM_PEDIDOS)
        Controls.Add(Label10)
        Controls.Add(TBT_SUBTOTAL)
        Controls.Add(TBT_ID_CLIENTE)
        Controls.Add(BT_AÑADIR_CLI)
        Controls.Add(DG_PEDIDOS)
        Controls.Add(BT_ORDENAR)
        Controls.Add(BT_ELIMINAR)
        Controls.Add(BT_AÑADIR)
        Controls.Add(Label9)
        Controls.Add(TBT_CANTIDAD)
        Controls.Add(Label8)
        Controls.Add(TBT_NON_CLIENTE)
        Controls.Add(Label7)
        Controls.Add(TBT_PRECIO)
        Controls.Add(TBT_NOM_PRODUCTO)
        Controls.Add(TBT_ID_PRODUCTO)
        Controls.Add(TBT_MESA)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(BT_SALIR)
        Controls.Add(Label2)
        Controls.Add(GroupBox1)
        Controls.Add(DG_PRODUCTOS)
        Controls.Add(TBT_pedido_num)
        Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4, 3, 4, 3)
        Name = "ORDENAR"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ORDENAR"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DG_PRODUCTOS, ComponentModel.ISupportInitialize).EndInit()
        CType(DG_PEDIDOS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_SALIR As Button
    Friend WithEvents Verificar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBT_MESA As TextBox
    Friend WithEvents TBT_ID_PRODUCTO As TextBox
    Friend WithEvents TBT_NOM_PRODUCTO As TextBox
    Friend WithEvents TBT_PRECIO As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TBT_NON_CLIENTE As TextBox
    Friend WithEvents TBT_CANTIDAD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BT_PAGAR As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DG_PRODUCTOS As DataGridView
    Friend WithEvents DG_PEDIDOS As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents TBT_ID_CLIENTE As TextBox
    Friend WithEvents BT_AÑADIR As Button
    Friend WithEvents BT_ELIMINAR As Button
    Friend WithEvents BT_ORDENAR As Button
    Friend WithEvents BT_AÑADIR_CLI As Button
    Friend WithEvents BT_FACTURAS As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBT_SUBTOTAL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TBT_NUM_PEDIDOS As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBT_TOTAL As TextBox
    Friend WithEvents RB_EFECTIVO As RadioButton
    Friend WithEvents RB_TARJETA As RadioButton
    Friend WithEvents BT_EFECTIVO As Button
    Friend WithEvents TB_TARJETA As Button
    Friend WithEvents TBT_pedido_num As TextBox
End Class
