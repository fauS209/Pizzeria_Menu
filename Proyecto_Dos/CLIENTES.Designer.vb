<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CLIENTES
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CLIENTES))
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        DG_CLIENTES = New DataGridView()
        BT_SALIR = New Button()
        GroupBox2 = New GroupBox()
        Label1 = New Label()
        BT_SELECCIONAR = New Button()
        BT_ELIMINAR = New Button()
        BT_AÑADIR = New Button()
        TBT_DIRECCION = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        TBT_TEL = New TextBox()
        TBT_ID = New TextBox()
        TBT_NOMBRE = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        CType(DG_CLIENTES, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(51, -252)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(698, 102)
        GroupBox1.TabIndex = 17
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(200, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(379, 68)
        Label3.TabIndex = 6
        Label3.Text = "PIZZERIA SV"
        ' 
        ' DG_CLIENTES
        ' 
        DG_CLIENTES.AllowUserToAddRows = False
        DG_CLIENTES.AllowUserToDeleteRows = False
        DG_CLIENTES.AllowUserToResizeColumns = False
        DG_CLIENTES.AllowUserToResizeRows = False
        DG_CLIENTES.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DG_CLIENTES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DG_CLIENTES.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_CLIENTES.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DG_CLIENTES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DG_CLIENTES.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DG_CLIENTES.DefaultCellStyle = DataGridViewCellStyle2
        DG_CLIENTES.Location = New Point(55, 289)
        DG_CLIENTES.Margin = New Padding(4, 3, 4, 3)
        DG_CLIENTES.Name = "DG_CLIENTES"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkGray
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkGray
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DG_CLIENTES.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DG_CLIENTES.RowHeadersWidth = 51
        DG_CLIENTES.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_CLIENTES.Size = New Size(588, 192)
        DG_CLIENTES.TabIndex = 20
        ' 
        ' BT_SALIR
        ' 
        BT_SALIR.BackColor = Color.Transparent
        BT_SALIR.BackgroundImage = CType(resources.GetObject("BT_SALIR.BackgroundImage"), Image)
        BT_SALIR.ForeColor = Color.Transparent
        BT_SALIR.Location = New Point(17, 898)
        BT_SALIR.Margin = New Padding(4, 3, 4, 3)
        BT_SALIR.Name = "BT_SALIR"
        BT_SALIR.Size = New Size(60, 55)
        BT_SALIR.TabIndex = 19
        BT_SALIR.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(3, 7)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(698, 102)
        GroupBox2.TabIndex = 18
        GroupBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(200, 21)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 68)
        Label1.TabIndex = 6
        Label1.Text = "PIZZERIA SV"
        ' 
        ' BT_SELECCIONAR
        ' 
        BT_SELECCIONAR.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        BT_SELECCIONAR.Location = New Point(270, 649)
        BT_SELECCIONAR.Name = "BT_SELECCIONAR"
        BT_SELECCIONAR.Size = New Size(168, 31)
        BT_SELECCIONAR.TabIndex = 52
        BT_SELECCIONAR.Text = "Seleccionar "
        BT_SELECCIONAR.UseVisualStyleBackColor = False
        ' 
        ' BT_ELIMINAR
        ' 
        BT_ELIMINAR.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        BT_ELIMINAR.Location = New Point(54, 648)
        BT_ELIMINAR.Name = "BT_ELIMINAR"
        BT_ELIMINAR.Size = New Size(168, 31)
        BT_ELIMINAR.TabIndex = 51
        BT_ELIMINAR.Text = "Eliminar"
        BT_ELIMINAR.UseVisualStyleBackColor = False
        ' 
        ' BT_AÑADIR
        ' 
        BT_AÑADIR.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        BT_AÑADIR.Location = New Point(482, 648)
        BT_AÑADIR.Name = "BT_AÑADIR"
        BT_AÑADIR.Size = New Size(168, 31)
        BT_AÑADIR.TabIndex = 50
        BT_AÑADIR.Text = "Añadir"
        BT_AÑADIR.UseVisualStyleBackColor = False
        ' 
        ' TBT_DIRECCION
        ' 
        TBT_DIRECCION.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_DIRECCION.Location = New Point(547, 556)
        TBT_DIRECCION.Multiline = True
        TBT_DIRECCION.Name = "TBT_DIRECCION"
        TBT_DIRECCION.Size = New Size(102, 30)
        TBT_DIRECCION.TabIndex = 49
        TBT_DIRECCION.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(369, 554)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(136, 32)
        Label8.TabIndex = 48
        Label8.Text = "Direccion:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(286, 243)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(99, 32)
        Label7.TabIndex = 46
        Label7.Text = "Cliente"
        ' 
        ' TBT_TEL
        ' 
        TBT_TEL.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_TEL.Location = New Point(547, 507)
        TBT_TEL.Multiline = True
        TBT_TEL.Name = "TBT_TEL"
        TBT_TEL.Size = New Size(103, 30)
        TBT_TEL.TabIndex = 44
        TBT_TEL.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_ID
        ' 
        TBT_ID.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_ID.Location = New Point(177, 556)
        TBT_ID.Multiline = True
        TBT_ID.Name = "TBT_ID"
        TBT_ID.Size = New Size(103, 30)
        TBT_ID.TabIndex = 43
        TBT_ID.TextAlign = HorizontalAlignment.Center
        ' 
        ' TBT_NOMBRE
        ' 
        TBT_NOMBRE.Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        TBT_NOMBRE.Location = New Point(177, 507)
        TBT_NOMBRE.Multiline = True
        TBT_NOMBRE.Name = "TBT_NOMBRE"
        TBT_NOMBRE.Size = New Size(103, 30)
        TBT_NOMBRE.TabIndex = 42
        TBT_NOMBRE.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(370, 505)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 32)
        Label5.TabIndex = 40
        Label5.Text = "Telefono :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(58, 554)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 32)
        Label4.TabIndex = 39
        Label4.Text = "Cedula :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(58, 505)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 32)
        Label2.TabIndex = 38
        Label2.Text = "Nombre :"
        ' 
        ' CLIENTES
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        ClientSize = New Size(704, 969)
        Controls.Add(BT_SELECCIONAR)
        Controls.Add(BT_ELIMINAR)
        Controls.Add(BT_AÑADIR)
        Controls.Add(TBT_DIRECCION)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(TBT_TEL)
        Controls.Add(TBT_ID)
        Controls.Add(TBT_NOMBRE)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(DG_CLIENTES)
        Controls.Add(BT_SALIR)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "CLIENTES"
        StartPosition = FormStartPosition.CenterScreen
        Text = "CLIENTES"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DG_CLIENTES, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DG_CLIENTES As DataGridView
    Friend WithEvents BT_SALIR As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BT_SELECCIONAR As Button
    Friend WithEvents BT_ELIMINAR As Button
    Friend WithEvents BT_AÑADIR As Button
    Friend WithEvents TBT_DIRECCION As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBT_TEL As TextBox
    Friend WithEvents TBT_ID As TextBox
    Friend WithEvents TBT_NOMBRE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
End Class
