Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "admin123" Then

            Form2.Show()
            Me.Hide()


        Else
            MsgBox("wrong username or password")
        End If
    End Sub
End Class
