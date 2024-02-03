<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Gray
        Button1.Font = New Font("Segoe UI Historic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(70, 146)
        Button1.Margin = New Padding(3, 2, 3, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 71)
        Button1.TabIndex = 0
        Button1.Text = "✊🏻"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Gray
        Button2.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(212, 146)
        Button2.Margin = New Padding(3, 2, 3, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(88, 71)
        Button2.TabIndex = 1
        Button2.Text = "🖐🏻"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gray
        Button3.Font = New Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(362, 146)
        Button3.Margin = New Padding(3, 2, 3, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(88, 71)
        Button3.TabIndex = 2
        Button3.Text = "✌🏻"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.SlateGray
        Label1.Font = New Font("Segoe UI Emoji", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 32)
        Label1.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(464, 258)
        Button4.Name = "Button4"
        Button4.Size = New Size(86, 38)
        Button4.TabIndex = 4
        Button4.Text = "Back"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Gray
        Label2.Font = New Font("Rockwell", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(148, 89)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 27)
        Label2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(148, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(243, 35)
        Label3.TabIndex = 6
        Label3.Text = "Rock Paper Scissor"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(555, 308)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button4)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form4"
        Text = "rock paper scissor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
