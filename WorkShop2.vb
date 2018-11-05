Option Explicit On
Option Strict On
Public Class workshop2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Chk1.Checked) Then
            Label1.Text = Chk1.Text
        Else
            Label1.Text = ""
        End If
        If (Chk2.Checked) Then
            Label2.Text = Chk2.Text
        Else
            Label2.Text = ""
        End If
        Label3.Text = ""
        For i As Integer = 0 To chkList1.Items.Count - 1
            If (chkList1.GetItemChecked(i) = True) Then
                Label3.Text = Label3.Text + "CheckList" + Str(i) + Chr(10)
            End If
        Next
        If (Radio1.Checked) Then
            Label4.Text = Radio1.Text
        ElseIf (Radio2.Checked) Then
            Label4.Text = Radio2.Text
        Else
            Label4.Text = "NA."
        End If
    End Sub
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "..."
        Label2.Text = "..."
        Label3.Text = "วัตถุดิบ"
        Label4.Text = "เพศ"
        Chk1.Checked = False
        Chk2.Checked = False
        For i As Integer = 0 To chkList1.Items.Count - 1
            If (chkList1.GetItemChecked(i) = True) Then
                chkList1.SetItemChecked(i, False)
            End If
        Next
        Radio1.Checked = False
        Radio2.Checked = False
    End Sub
End Class