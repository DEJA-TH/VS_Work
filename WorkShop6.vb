Option Explicit On
Option Strict On
Imports System.Data.OleDb
Public Class workshop6
    Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\mydata\register.accdb;Persist Security Info=False;"
    Public conn As New OleDb.OleDbConnection
    Public objCmd As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    Public Sub connection()
        conn = New OleDb.OleDbConnection
        With conn
            .ConnectionString = strconn
            .Open()
        End With
    End Sub
    Public Sub showData()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String
        strSQL = "select uname,upassword from member"
        Call connection()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter(strSQL, conn)
        da.Fill(dt)
        MyGridView.DataSource = dt.DefaultView
    End Sub
    Private Sub workshop6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call connection()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim found As Boolean
        Try
            Call connection()
            objCmd = New OleDb.OleDbCommand
            With objCmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "SELECT * FROM member WHERE (uname = '" & TextBox1.Text & "')"
                dr = .ExecuteReader
            End With
            While dr.Read()
                TextBox1.Text = dr("uname").ToString
                TextBox2.Text = dr("upassword").ToString
                found = True
            End While
            conn.Close()
            If found = False Then MsgBox("user name not found.", MsgBoxStyle.Critical)
            dr.Close()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Call connection()
            objCmd = New OleDb.OleDbCommand
            With objCmd
                .Connection = conn
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO member (uname,upassword) VALUES(@uname,@upassword)"
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@uname", System.Data.OleDb.OleDbType.VarChar, 20, Me.TextBox1.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@upassword", System.Data.OleDb.OleDbType.VarChar, 8, Me.TextBox2.Text))
                objCmd.Parameters("@uname").Value = Me.TextBox1.Text
                objCmd.Parameters("@upassword").Value = Me.TextBox2.Text
                objCmd.ExecuteNonQuery()
                MsgBox("Record saved.", MsgBoxStyle.Information)
                Me.TextBox1.Text = ""
                Me.TextBox2.Text = ""
                Call showData()
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class