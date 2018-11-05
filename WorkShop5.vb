Option Explicit On
Option Strict On
Imports System.Data
Imports System.Data.OleDb
Public Class workshop5
    Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\mydata\register.accdb;Persist Security Info=False;"
    Dim conn As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Private Sub workshop5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSQL As String
        strSQL = "select uname,upassword from member"
        With conn
            If conn.State = ConnectionState.Open Then .Close()
            conn.ConnectionString = strconn
            conn.Open()
        End With
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter(strSQL, conn)
        da.Fill(dt)
        myGridView.DataSource = dt.DefaultView
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objCmd As New OleDbCommand
        Dim strSQL As String
        strSQL = "select count(uname) from member where uname='" & TextBox1.Text & "' and upassword='" & TextBox2.Text & "'"
        objCmd = New OleDbCommand(strSQL, conn)
        Dim intNumRows As Integer
        intNumRows = CInt(objCmd.ExecuteScalar())
        If intNumRows > 0 Then
            MessageBox.Show("Username or Password Correct")
        Else
            MessageBox.Show("Username or Password Incorrect")
        End If
    End Sub
End Class