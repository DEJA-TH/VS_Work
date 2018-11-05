Imports Microsoft.office.Interop
Public Class WorkShop8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.ColumnCount = 3
        DataGridView1.Columns(0).Name = "Product Id"
        DataGridView1.Columns(1).Name = "Product Name"
        DataGridView1.Columns(2).Name = "Product Price"

        DataGridView2.ColumnCount = 3
        DataGridView2.Columns(0).Name = "Product Id"
        DataGridView2.Columns(1).Name = "Product Name"
        DataGridView2.Columns(2).Name = "Product Price"

        Dim row As String() = New String() {"1", "Banana", "20"}
        DataGridView1.Rows.Add(row)
        row = New String() {"2", "Coke", "15"}
        DataGridView1.Rows.Add(row)
        row = New String() {"3", "Papsi", "15"}
        DataGridView1.Rows.Add(row)
        row = New String() {"4", "Fanta", "15"}
        DataGridView1.Rows.Add(row)
        row = New String() {"5", "RJ", "150"}
        DataGridView1.Rows.Add(row)
    End Sub

    'Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    'End Sub

    'Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

    'End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim row As String()
        If (DataGridView1.RowCount > 0) Then
            row = New String() {DataGridView1.CurrentRow.Cells(0).Value, DataGridView1.CurrentRow.Cells(1).Value, DataGridView1.CurrentRow.Cells(2).Value}
            DataGridView2.Rows.Add(row)
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Dim row As String()
        If (DataGridView2.RowCount > 0) Then
            row = New String() {DataGridView2.CurrentRow.Cells(0).Value, DataGridView2.CurrentRow.Cells(1).Value, DataGridView2.CurrentRow.Cells(2).Value}
            DataGridView1.Rows.Add(row)
            DataGridView2.Rows.Remove(DataGridView2.SelectedRows(0))
        End If
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim oApp As New Word.Application
    '    Dim oDoc As Word.Document
    '    Dim oTable As Word.Table
    '    Dim x As Integer
    '    Dim y As Integer
    '    Dim z As Integer
    '    oApp = New Word.Application
    '    'Open an exisiting document
    '    oDoc = oApp.Documents.Open("C:\mydata\Doc.doc")
    '    oTable = oDoc.Tables.Item(1) 'Second table for ex.
    '    With oTable
    '        z = 1
    '        'Populate the data cells
    '        For x = 2 To oTable.Rows.Count-
    '            For y = 1 To oTable.Columns.Count
    '                'Add cell color formatting
    '                .Cell(x, y).Range.Font.ColorIndex = z
    '                'Write to the table cell
    '                .Cell(x, y).Range.Text = "Meow " & x - 1
    '                z = z + 1
    '            Next
    '        Next
    '    End With
    '    'Clean up
    '    oTable = Nothing
    '    oDoc.Save
    '    'Leave the document open for reviewing
    '    oDoc = Nothing
    '    oApp = Nothing


    'End Sub
End Class