Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class MENU

    Dim conexion As New SqlConnection("Data Source=FAU;Initial Catalog=PIZZERIA;Integrated Security=True")
    Dim cuenta As Integer
    Dim ds As New DataSet
    Dim rows As New Integer
    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Dim cadena As String = "select PRODUCTO, DESCRIPCION, PRECIO from PRODUCTOS"
        Dim comando As SqlCommand
        comando = New SqlCommand(cadena, conexion)
        Dim Productos As SqlDataReader
        Productos = comando.ExecuteReader()
        Dim limitador As Integer = 5



        For i = 0 To limitador Step 1


            If Productos.Read() = True Then
                TextBox1.AppendText(Productos("PRODUCTO"))
                TextBox1.AppendText("..............................")
                TextBox1.AppendText(vbCrLf)
                TextBox1.AppendText(Productos("DESCRIPCION"))
                TextBox1.AppendText(vbCrLf)
                TextBox1.AppendText(vbCrLf)
                TextBox1.AppendText(vbCrLf)
                TextBox1.AppendText(vbCrLf)
                TextBox2.AppendText("$ ")
                TextBox2.AppendText(Productos("PRECIO"))
                TextBox2.AppendText(vbCrLf)
                TextBox2.AppendText(vbCrLf)
                TextBox2.AppendText(vbCrLf)
                TextBox2.AppendText(vbCrLf)
                TextBox2.AppendText(vbCrLf)
            End If

        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
