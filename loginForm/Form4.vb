﻿Public Class Form4
    Dim random As New Random()
    Dim computerchoice As Integer
    Dim playerscore As Integer = 0
    Dim computerscore As Integer = 0
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
            playerscore += 1
        Else
            Label1.Text = "computer win!"
            computerscore += 1
        End If

        Select Case computerchoice
            Case 1
                Label2.Text = "computer chose: rock"
            Case 2
                Label2.Text = "computer chose: paper"
            Case 3
                Label2.Text = "computer chose: scissor"
        End Select

        Label4.Text = playerscore.ToString
        Label5.Text = computerscore.ToString

        computerchoice = random.Next(1, 4)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        playgame(2)
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class