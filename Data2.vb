Imports MySql.Data.MySqlClient
Imports System.Data
Public Class Data2
    Dim strUser As String
    Public Property _strUser() As String
        Get
            Return strUser
        End Get
        Set(ByVal value As String)
            strUser = value
        End Set
    End Property

    Public Sub LoadInfor()
        Dim objConn As New MySqlConnection
        Dim objCmd As New MySqlCommand
        Dim dtAdapter As MySqlDataAdapter
        Dim dt As New DataTable
        Dim strConnString, strSQL As String

        strConnString = "Server=localhost;User Id=root;
        Password=12345678; Database=member; Pooling=false"
        objConn.ConnectionString = strConnString
        objConn.Open()

        strSQL = "SELECT * FROM members WHERE Username = '" & strUser & "' "

        dtAdapter = New MySqlDataAdapter(strSQL, objConn)
        dtAdapter.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.TextBox1.Text = strUser
            Me.TextBox2.Text = dt.Rows(0)("Password")
            Me.TextBox3.Text = dt.Rows(0)("Email")
        End If

        objConn.Close()
        objConn = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button1.Click
        Dim frm As New Data1
        frm.Show()
        Me.Hide()
    End Sub
End Class