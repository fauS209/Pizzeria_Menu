Imports System.Data.SqlClient

Public Class PAGOS

    Dim conexion As New SqlConnection("Data Source=FAU;Initial Catalog=PIZZERIA;Integrated Security=True")
    Dim comando As SqlCommand
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ORDENAR.Show()
        Me.Hide()

    End Sub

    Private Sub PAGOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Llenar_Grip1()
    End Sub

    Public Sub Llenar_Grip1()
        Dim dt As New DataTable
        Dim consulta As String = "select * from FACTURAS"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DG_FACTURACION.DataSource = dt

    End Sub


End Class