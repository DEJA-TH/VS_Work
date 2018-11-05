Option Explicit On
Option Strict On
Public Class WorkShop1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label3.Text = TextBox1.Text
        Label4.Text = TextBox2.Text
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        'Comment ctrl k+c
        Label3.Text = "คุณชื่อ"
        Label4.Text = "นามสกุลคุณ"
        Label1.Focus()
    End Sub
End Class