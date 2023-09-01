Public Class MESAS

    Public mesa As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        mesa = 2
        ORDENAR.Show()
        Me.Hide()
        ORDENAR.TBT_MESA.Text = mesa
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        mesa = 3
        ORDENAR.Show()
        Me.Hide()
        ORDENAR.TBT_MESA.Text = mesa

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        mesa = 4
        ORDENAR.Show()
        Me.Hide()
        ORDENAR.TBT_MESA.Text = mesa
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        mesa = 5
        ORDENAR.Show()
        Me.Hide()
        ORDENAR.TBT_MESA.Text = mesa
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        mesa = 1
        ORDENAR.Show()
        Me.Hide()
        ORDENAR.TBT_MESA.Text = mesa
    End Sub
End Class