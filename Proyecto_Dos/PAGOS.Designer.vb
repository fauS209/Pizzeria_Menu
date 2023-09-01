<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGOS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(PAGOS))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Button2 = New Button()
        DG_FACTURACION = New DataGridView()
        Label9 = New Label()
        GroupBox1.SuspendLayout()
        CType(DG_FACTURACION, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(2, 2)
        GroupBox1.Margin = New Padding(4, 3, 4, 3)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 3, 4, 3)
        GroupBox1.Size = New Size(698, 102)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(199, 21)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(379, 68)
        Label3.TabIndex = 6
        Label3.Text = "PIZZERIA SV"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(13, 902)
        Button2.Margin = New Padding(4, 3, 4, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(60, 55)
        Button2.TabIndex = 9
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DG_FACTURACION
        ' 
        DG_FACTURACION.AllowUserToAddRows = False
        DG_FACTURACION.AllowUserToDeleteRows = False
        DG_FACTURACION.AllowUserToResizeColumns = False
        DG_FACTURACION.AllowUserToResizeRows = False
        DG_FACTURACION.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DG_FACTURACION.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DG_FACTURACION.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DG_FACTURACION.BackgroundColor = Color.LightGray
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gray
        DataGridViewCellStyle1.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.MenuBar
        DataGridViewCellStyle1.SelectionBackColor = Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DG_FACTURACION.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DG_FACTURACION.ColumnHeadersHeight = 29
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Gainsboro
        DataGridViewCellStyle2.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DG_FACTURACION.DefaultCellStyle = DataGridViewCellStyle2
        DG_FACTURACION.Location = New Point(54, 182)
        DG_FACTURACION.Margin = New Padding(4, 3, 4, 3)
        DG_FACTURACION.Name = "DG_FACTURACION"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.DarkGray
        DataGridViewCellStyle3.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        DataGridViewCellStyle3.SelectionForeColor = Color.DarkGray
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        DG_FACTURACION.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DG_FACTURACION.RowHeadersWidth = 51
        DG_FACTURACION.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DG_FACTURACION.Size = New Size(588, 192)
        DG_FACTURACION.TabIndex = 16
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(293, 128)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(145, 38)
        Label9.TabIndex = 32
        Label9.Text = "Facturas"
        ' 
        ' PAGOS
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        ClientSize = New Size(704, 969)
        Controls.Add(Label9)
        Controls.Add(DG_FACTURACION)
        Controls.Add(Button2)
        Controls.Add(GroupBox1)
        Name = "PAGOS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PAGOS"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DG_FACTURACION, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DG_FACTURACION As DataGridView
    Friend WithEvents Label9 As Label
End Class
