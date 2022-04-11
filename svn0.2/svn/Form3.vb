Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a As Object
        a = Val(TextBox1.Text)
        If a < -25 Then
            Label2.Text = "Занятия в школе отменяются!"
        Else
            Label2.Text = "Можешь идти в школу. Желаю успехов!"
        End If
    End Sub
End Class