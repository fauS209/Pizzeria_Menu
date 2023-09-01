<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Label1 = New Label()
        LB_cliente = New Label()
        LB_id = New Label()
        Label3 = New Label()
        Label2 = New Label()
        LB_fecha = New Label()
        LB_mesa = New Label()
        Label5 = New Label()
        Label4 = New Label()
        LB_pedido = New Label()
        Label6 = New Label()
        LB_total = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 22)
        Label1.TabIndex = 0
        Label1.Text = "Cliente :"
        ' 
        ' LB_cliente
        ' 
        LB_cliente.AutoSize = True
        LB_cliente.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LB_cliente.Location = New Point(85, 84)
        LB_cliente.Name = "LB_cliente"
        LB_cliente.Size = New Size(25, 22)
        LB_cliente.TabIndex = 1
        LB_cliente.Text = "..."
        ' 
        ' LB_id
        ' 
        LB_id.AutoSize = True
        LB_id.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LB_id.Location = New Point(85, 128)
        LB_id.Name = "LB_id"
        LB_id.Size = New Size(25, 22)
        LB_id.TabIndex = 3
        LB_id.Text = "..."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(12, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(37, 22)
        Label3.TabIndex = 2
        Label3.Text = "Id :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(40, 19)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(255, 46)
        Label2.TabIndex = 7
        Label2.Text = "PIZZERIA SV"
        ' 
        ' LB_fecha
        ' 
        LB_fecha.AutoSize = True
        LB_fecha.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LB_fecha.Location = New Point(24, 172)
        LB_fecha.Name = "LB_fecha"
        LB_fecha.Size = New Size(25, 22)
        LB_fecha.TabIndex = 8
        LB_fecha.Text = "..."
        ' 
        ' LB_mesa
        ' 
        LB_mesa.AutoSize = True
        LB_mesa.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LB_mesa.Location = New Point(286, 128)
        LB_mesa.Name = "LB_mesa"
        LB_mesa.Size = New Size(25, 22)
        LB_mesa.TabIndex = 9
        LB_mesa.Text = "..."
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(207, 128)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 22)
        Label5.TabIndex = 10
        Label5.Text = "Mesa :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(207, 84)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 22)
        Label4.TabIndex = 12
        Label4.Text = "Pedido :"
        ' 
        ' LB_pedido
        ' 
        LB_pedido.AutoSize = True
        LB_pedido.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        LB_pedido.Location = New Point(286, 84)
        LB_pedido.Name = "LB_pedido"
        LB_pedido.Size = New Size(25, 22)
        LB_pedido.TabIndex = 11
        LB_pedido.Text = "..."
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(96, 251)
        Label6.Name = "Label6"
        Label6.Size = New Size(99, 33)
        Label6.TabIndex = 14
        Label6.Text = "Total: $"
        ' 
        ' LB_total
        ' 
        LB_total.AutoSize = True
        LB_total.Font = New Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        LB_total.Location = New Point(181, 251)
        LB_total.Name = "LB_total"
        LB_total.Size = New Size(36, 33)
        LB_total.TabIndex = 13
        LB_total.Text = "..."
        ' 
        ' Factura
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(326, 330)
        Controls.Add(Label6)
        Controls.Add(LB_total)
        Controls.Add(Label4)
        Controls.Add(LB_pedido)
        Controls.Add(Label5)
        Controls.Add(LB_mesa)
        Controls.Add(LB_fecha)
        Controls.Add(Label2)
        Controls.Add(LB_id)
        Controls.Add(Label3)
        Controls.Add(LB_cliente)
        Controls.Add(Label1)
        Name = "Factura"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Factura"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LB_cliente As Label
    Friend WithEvents LB_id As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LB_fecha As Label
    Friend WithEvents LB_mesa As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LB_pedido As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LB_total As Label
End Class
