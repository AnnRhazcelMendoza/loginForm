Public Class Form4
    Dim random As New Random()
    Dim computerchoice As Integer
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        playgame(3)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        playgame(1)
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        computerchoice = random.Next(1, 4)
    End Sub


    Private Sub playgame(userchoice As Integer)
        If userchoice = computerchoice Then
            Label1.Text = "its a tie!"
        ElseIf (userchoice = 1 AndAlso computerchoice = 3) Or
               (userchoice = 2 AndAlso computerchoice = 1) Or
               (userchoice = 3 AndAlso computerchoice = 2) Then
            Label1.Text = "you win!"
        Else
            Label1.Text = "computer win!"

        End If
        computerchoice = random.Next(1, 4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        playgame(2)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class