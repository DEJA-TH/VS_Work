Option Explicit On
Option Strict On
Public Class workshop4
    Dim i As Integer
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (ListView1.Items.Count > 0) Then
            If (ListView1.Items(ListView1.Items.Count - 1).SubItems(0).Text.ToLower = "total") Then
                ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
            End If
        End If
        i = i + 1
        Dim str(2) As String
        Dim itm As ListViewItem
        str(0) = Text1.Text
        str(1) = Text2.Text
        itm = New ListViewItem(str)
        ListView1.Items.Insert(0, itm)
        Text1.Clear()
        Text2.Clear()
        Text1.Focus()
    End Sub
    Private Sub workshop4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("รหัสนักศึกษา", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("ชือ­สกุล", 150, HorizontalAlignment.Left)
    End Sub
    Private Sub button12_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListView1.Clear()
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        Text3.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(0).Text
        Text4.Text = ListView1.Items(ListView1.FocusedItem.Index).SubItems(1).Text
    End Sub
End Class