Public Class LOGIN
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        MESAS.Show()
        Me.Hide()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.UseSystemPasswordChar = False
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MENU.Show()
        Me.Hide()
    End Sub


End Class