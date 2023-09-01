Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ORDENAR

    Dim conexion As New SqlConnection("Data Source=FAU;Initial Catalog=PIZZERIA;Integrated Security=True")
    Dim comando As SqlCommand
    Dim subtotal As New Integer
    Dim sumatoria As New Integer
    Private Sub ORDENAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        Llenar_Grip1()
        Llenar_Grip2()
    End Sub

    Private Sub Llenar_Grip1()
        Dim dt As New DataTable
        Dim consulta As String = "select * from PEDIDOS"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DG_PEDIDOS.DataSource = dt
    End Sub

    Private Sub Llenar_Grip2()

        Dim dt As New DataTable
        Dim consulta As String = "select COD_PRODUCTO, PRODUCTO, PRECIO from PRODUCTOS"
        Dim adaptador As New SqlDataAdapter(consulta, conexion)
        adaptador.Fill(dt)
        DG_PRODUCTOS.DataSource = dt

    End Sub

    Private Sub Limpiar()
        TBT_NUM_PEDIDOS.Clear()
        TBT_ID_PRODUCTO.Clear()
        TBT_NOM_PRODUCTO.Clear()
        TBT_PRECIO.Clear()
        TBT_CANTIDAD.Clear()

    End Sub

    Private Sub ELIMINAR()
        Dim consulta As String = "DELETE FROM PEDIDOS where NUM_PEDIDO =" & TBT_NUM_PEDIDOS.Text
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()
        Llenar_Grip1()
        Limpiar()
    End Sub

    Private Sub AÑADIR()
        Dim consulta As String = "insert into PEDIDOS ( MESA, PRODUCTO, PRECIO, CANTIDAD, CLIENTE, ID_CLIENTE) values ( '" & TBT_MESA.Text & "','" & TBT_NOM_PRODUCTO.Text & "','" & TBT_PRECIO.Text & "','" & TBT_CANTIDAD.Text & "','" & TBT_NON_CLIENTE.Text & "','" & TBT_ID_CLIENTE.Text & "')"
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()
        Llenar_Grip1()
        Limpiar()

    End Sub

    Private Sub TOTAL()
        sumatoria = TBT_CANTIDAD.Text * TBT_PRECIO.Text
        subtotal = sumatoria + subtotal
        TBT_SUBTOTAL.Text = subtotal

    End Sub

    Private Sub BT_AÑADIR_Click(sender As Object, e As EventArgs) Handles BT_AÑADIR.Click
        AÑADIR()
        Llenar_Grip1()
        Limpiar()

    End Sub

    Private Sub BT_ELIMINAR_Click(sender As Object, e As EventArgs) Handles BT_ELIMINAR.Click
        ELIMINAR()
        Llenar_Grip1()
        TBT_MESA.Clear()
        Limpiar()
    End Sub

    Private Sub BT_ORDENAR_Click(sender As Object, e As EventArgs) Handles BT_ORDENAR.Click
        TOTAL()
        ELIMINAR()

    End Sub

    Private Sub BT_SALIR_Click(sender As Object, e As EventArgs) Handles BT_SALIR.Click
        MESAS.Show()
        Me.Hide()
    End Sub

    Private Sub DG_PEDIDOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PEDIDOS.CellContentClick
        TBT_pedido_num.Text = DG_PEDIDOS.SelectedCells(0).Value
        TBT_NUM_PEDIDOS.Text = DG_PEDIDOS.SelectedCells(0).Value
        TBT_MESA.Text = DG_PEDIDOS.SelectedCells(1).Value
        TBT_NOM_PRODUCTO.Text = DG_PEDIDOS.SelectedCells(2).Value
        TBT_PRECIO.Text = DG_PEDIDOS.SelectedCells(3).Value
        TBT_CANTIDAD.Text = DG_PEDIDOS.SelectedCells(4).Value
        TBT_NON_CLIENTE.Text = DG_PEDIDOS.SelectedCells(5).Value
        TBT_ID_CLIENTE.Text = DG_PEDIDOS.SelectedCells(6).Value
    End Sub

    Private Sub DG_PRODUCTOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_PRODUCTOS.CellContentClick
        TBT_ID_PRODUCTO.Text = DG_PRODUCTOS.SelectedCells(0).Value
        TBT_NOM_PRODUCTO.Text = DG_PRODUCTOS.SelectedCells(1).Value
        TBT_PRECIO.Text = DG_PRODUCTOS.SelectedCells(2).Value
        TBT_CANTIDAD.Text = 1
    End Sub



    Private Sub BT_CAJA_Click(sender As Object, e As EventArgs) Handles BT_FACTURAS.Click

        PAGOS.Show()
        Me.Hide()
    End Sub
    Private Sub BT_PAGAR_Click(sender As Object, e As EventArgs) Handles BT_PAGAR.Click


        Dim consulta As String = "insert into FACTURAS( MESA, CLIENTE, ID_CLIENTE, FECHA, TOTAL_PAGAR) values (  '" & TBT_MESA.Text & "','" & TBT_NON_CLIENTE.Text & "','" & TBT_ID_CLIENTE.Text & "','" & DateTimePicker1.Text & "','" & TBT_TOTAL.Text & "')"
        comando = New SqlCommand(consulta, conexion)
        comando.ExecuteNonQuery()
        Facturar()
        Limpiar()
        TBT_MESA.Clear()
        TBT_NON_CLIENTE.Clear()
        TBT_ID_CLIENTE.Clear()
        PAGOS.Llenar_Grip1()
        subtotal = 0
        TBT_TOTAL.Clear()
        Factura.Show()

    End Sub
    Private Sub Facturar()
        Factura.LB_cliente.Text = TBT_NON_CLIENTE.Text
        Factura.LB_id.Text = TBT_ID_CLIENTE.Text
        Factura.LB_mesa.Text = TBT_MESA.Text
        Factura.LB_fecha.Text = DateTimePicker1.Text
        Factura.LB_pedido.Text = TBT_pedido_num.Text
        Factura.LB_total.Text = TBT_TOTAL.Text
    End Sub

    Private Sub BT_AÑADIR_CLI_Click(sender As Object, e As EventArgs) Handles BT_AÑADIR_CLI.Click
        CLIENTES.Limpiar()
        CLIENTES.Llenar_Grip1()
        CLIENTES.Show()
        Me.Hide()
    End Sub



    Private Sub TB_TARJETA_Click(sender As Object, e As EventArgs) Handles TB_TARJETA.Click
        TBT_TOTAL.Text = TBT_SUBTOTAL.Text
        TBT_SUBTOTAL.Clear()
    End Sub

    Private Sub BT_EFECTIVO_Click(sender As Object, e As EventArgs) Handles BT_EFECTIVO.Click
        TBT_TOTAL.Text = TBT_SUBTOTAL.Text - (TBT_SUBTOTAL.Text * 0.05)
        TBT_SUBTOTAL.Clear()
    End Sub


End Class