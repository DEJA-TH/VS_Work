Option Explicit On
Option Strict On
Public Class workshop3
    Dim i As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(Trim(i.ToString) + ". " + Text1.Text)
        Text1.Clear()
        Text1.Focus()
        i += 1
    End Sub
    Private Sub workshop3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text1.Focus()
    End Sub
    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        Text2.Text = ListBox1.SelectedItem.ToString
    End Sub
End Class