Imports System.Data
Imports System.Data.OleDb
Public Class workshop7
    Dim strconn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\mydata\register.accdb;Persist Security Info=False;"
    Public conn As New OleDb.OleDbConnection
    Public objCmd As New OleDb.OleDbCommand
    Public dr As OleDbDataReader
    Public Sub connection()
        conn = New OleDb.OleDbConnection
        With conn
            If .State = ConnectionState.Open Then .Close()
            .ConnectionString = strconn
            .Open()
        End With
    End Sub
    Public Sub showData()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String
        strSQL = "select facId,departId,departName from department"
        Call connection()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter(strSQL, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Public Sub showDataFillter(param1 As String)
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSQL As String
        strSQL = "select facId,departId,departName from department where facid='" & param1 & "'"
        Call connection()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter(strSQL, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub workshop7_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call connection()
        Dim da As New OleDbDataAdapter
        Dim ds As New DataSet
        Dim bindings As New BindingSource
        Dim sqlcbo As String = "select facid,facName from faculty"
        da = New OleDbDataAdapter(sqlcbo, conn)
        da.Fill(ds, "faculty")
        bindings.DataSource = ds
        bindings.DataMember = "faculty"
        With ComboBox1
            .DataSource = bindings
            .DisplayMember = "facName"
            .BeginUpdate()
            .ValueMember = "facid"
            .EndUpdate()
        End With
        showData()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Call connection()
            objCmd = New OleDb.OleDbCommand
            With objCmd
        .Connection = conn
        .CommandType = CommandType.Text
        .CommandText = "INSERT INTO department
        (facid,departid,departname) VALUES
        (@facid,@departid,@departname)"
        .Parameters.Add(New System.Data.OleDb.OleDbParameter("@facid",System.Data.OleDb.OleDbType.VarChar, 2,ComboBox1.SelectedValue.ToString))
        .Parameters.Add(New System.Data.OleDb.OleDbParameter("@departid", System.Data.OleDb.OleDbType.VarChar, 2,TextBox1.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@departname", System.Data.OleDb.OleDbType.VarChar, 50, TextBox2.Text))
                .Parameters("@facid").Value = ComboBox1.SelectedValue.ToString
        .Parameters("@departid").Value = TextBox1.Text
        .Parameters("@departname").Value = TextBox2.Text
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
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        showDataFillter(ComboBox1.SelectedValue.ToString)
    End Sub
End Class