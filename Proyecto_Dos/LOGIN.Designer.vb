<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(LOGIN))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        GroupBox1 = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(142, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(149, 155)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(197, 269)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 34)
        Label1.TabIndex = 1
        Label1.Text = "ID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(132, 350)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 34)
        Label2.TabIndex = 2
        Label2.Text = "PASSWORD"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.SlateGray
        TextBox1.Location = New Point(116, 306)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(205, 41)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.SlateGray
        TextBox2.Location = New Point(116, 387)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(205, 41)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Times New Roman", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(212, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(279, 53)
        Label3.TabIndex = 5
        Label3.Text = "PIZZERIA SV"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(142, 445)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 40)
        Button1.TabIndex = 6
        Button1.Text = "START"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(12, 907)
        Button2.Name = "Button2"
        Button2.Size = New Size(52, 50)
        Button2.TabIndex = 7
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.ForeColor = Color.Black
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.Location = New Point(327, 400)
        Button3.Name = "Button3"
        Button3.Size = New Size(33, 28)
        Button3.TabIndex = 8
        Button3.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Location = New Point(136, 170)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(422, 585)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        ' 
        ' LOGIN
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        BackColor = Color.Aqua
        ClientSize = New Size(704, 969)
        Controls.Add(GroupBox1)
        Controls.Add(Button2)
        Controls.Add(Label3)
        ForeColor = SystemColors.ControlDark
        Name = "LOGIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LOGIN"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
