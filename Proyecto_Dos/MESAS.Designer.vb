<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MESAS
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MESAS))
        Button1 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.Cursor = Cursors.Hand
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(71, 163)
        Button1.Name = "Button1"
        Button1.Size = New Size(219, 188)
        Button1.TabIndex = 1
        Button1.Text = "1"
        Button1.TextAlign = ContentAlignment.TopCenter
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.Cursor = Cursors.Hand
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(71, 388)
        Button3.Name = "Button3"
        Button3.Size = New Size(219, 184)
        Button3.TabIndex = 2
        Button3.Text = "3"
        Button3.TextAlign = ContentAlignment.TopCenter
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.Cursor = Cursors.Hand
        Button4.FlatStyle = FlatStyle.Popup
        Button4.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(444, 388)
        Button4.Name = "Button4"
        Button4.Size = New Size(214, 184)
        Button4.TabIndex = 3
        Button4.Text = "4"
        Button4.TextAlign = ContentAlignment.TopCenter
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.Cursor = Cursors.Hand
        Button5.FlatStyle = FlatStyle.Popup
        Button5.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(254, 590)
        Button5.Name = "Button5"
        Button5.Size = New Size(211, 182)
        Button5.TabIndex = 4
        Button5.Text = "5"
        Button5.TextAlign = ContentAlignment.TopCenter
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(279, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 51)
        Label1.TabIndex = 6
        Label1.Text = "MESAS "
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(210), CByte(234), CByte(220))
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(4, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(733, 93)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.Cursor = Cursors.Hand
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(444, 163)
        Button2.Name = "Button2"
        Button2.Size = New Size(214, 188)
        Button2.TabIndex = 5
        Button2.Text = "2"
        Button2.TextAlign = ContentAlignment.TopCenter
        Button2.UseVisualStyleBackColor = True
        ' 
        ' MESAS
        ' 
        AccessibleRole = AccessibleRole.None
        AutoScaleMode = AutoScaleMode.None
        BackColor = Color.FromArgb(CByte(249), CByte(245), CByte(235))
        ClientSize = New Size(704, 969)
        Controls.Add(Button2)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "MESAS"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MESAS"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
End Class
