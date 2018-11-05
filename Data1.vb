Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Data1

    Private Sub Button1_Click(ByVal sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim objConn As New MySqlConnection
        Dim objCmd As New MySqlCommand
        Dim strConnString, strSQL As String

        strConnString = "Server=localhost;User Id=root;Password=12345678; Database=member;Pooling=false"
        objConn.ConnectionString = strConnString
        objConn.Open()

        Dim intNumRows As Integer
        strSQL = "SELECT COUNT(*) FROM members WHERE
        Username = '" & Me.TextBox1.Text & "' AND
        Password = '" & Me.TextBox2.Text & "' "        objCmd = New MySqlCommand(strSQL, objConn)
        intNumRows = objCmd.ExecuteScalar()

        If intNumRows > 0 Then
            Dim frm As New Data2
            frm._strUser = Me.TextBox1.Text
            frm.LoadInfor()
            frm.Show()

            Me.Hide()
        Else
            MessageBox.Show("Username or Password Incorrect")
        End If

        objConn.Close()
        objConn = Nothing
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MessageBox.Show("Exit application?", "",
          MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class