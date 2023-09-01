Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CLIENTES
    Dim conexion As New SqlConnection("Data Source=FAU;Initial Catalog=PIZZERIA;Integrated Security=True")
    Dim comando As SqlCommand


    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Llenar_Grip1()

    End Sub

    Public Sub Llenar_Grip1()
        Dim dt As New DataTable
        Dim consulta As String = "select * from CLIENTES"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DG_CLIENTES.DataSource = dt

    End Sub

    Public Sub Limpiar()
        TBT_ID.Clear()
        TBT_NOMBRE.Clear()
        TBT_TEL.Clear()
        TBT_DIRECCION.Clear()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_CLIENTES.CellContentClick
        TBT_ID.Text = DG_CLIENTES.SelectedCells(0).Value
        TBT_NOMBRE.Text = DG_CLIENTES.SelectedCells(1).Value
    End Sub

    Private Sub BT_AÑADIR_Click(sender As Object, e As EventArgs) Handles BT_AÑADIR.Click
        Dim consulta As String = "insert into CLIENTES (Id, NOMBRE, TEL, DIRECCION) values ( '" & TBT_ID.Text & "', '" & TBT_NOMBRE.Text & "','" & TBT_TEL.Text & "','" & TBT_DIRECCION.Text & "')"
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()
        Llenar_Grip1()
        Limpiar()
    End Sub

    Private Sub BT_SELECCIONAR_Click(sender As Object, e As EventArgs) Handles BT_SELECCIONAR.Click
        ORDENAR.TBT_NON_CLIENTE.Text = TBT_NOMBRE.Text
        ORDENAR.TBT_ID_CLIENTE.Text = TBT_ID.Text

        ORDENAR.Show()
        Me.Hide()
    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        Dim consulta As String = "DELETE FROM CLIENTES where Id=" & TBT_ID.Text
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()
        Llenar_Grip1()
        Limpiar()
    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        ORDENAR.Show()
        Me.Hide()
    End Sub
End Class