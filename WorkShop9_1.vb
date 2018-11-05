Option Explicit On
Option Strict On
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Public Class WorkShop9_1
    Private wdPaperLegal As WdPaperSize
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CreateTableInWordDocument()
    End Sub
    Private Sub CreateTableInWordDocument()
        Dim objWord As Word.Application
        Dim objDoc As Word.Document
        Dim objTable, glatable, objTableTitle, objTableTitle2, footerTable1 As Table
        Dim mypage As Integer
        Dim orange As Word.Range
        Dim orange1 As Word.Range
        Dim colx As Integer = 11
        Dim rowx As Integer = 45
        Dim r, x, tr2, tc2 As Integer
        objWord = CType(CreateObject("Word.Application"), Application)
        objWord.Visible = True
        objDoc = objWord.Documents.Add
        objDoc.PageSetup.PaperSize = WdPaperSize.wdPaperLegal
        objDoc.PageSetup.LeftMargin = 15
        objDoc.PageSetup.RightMargin = 15
        objDoc.PageSetup.TopMargin = 15
        objDoc.PageSetup.BottomMargin = 15
        objDoc.Paragraphs(1).Range.Font.Size = 1
        'For mypage = 1 To 1
        objTableTitle = objDoc.Tables.Add(objDoc.Bookmarks.Item("\endofdoc").Range, 3, 1)
        With objTableTitle
            .Cell(1, 1).Range.Font.Bold = CInt(True)
            .Cell(1, 1).Range.Font.BoldBi = CInt(True)
            .Cell(1, 1).Range.Font.Size = 20
            .Cell(1, 1).Range.Font.SizeBi = 20
            .Cell(1, 1).Range.Font.Name = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(1, 1).Range.Font.NameBi = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(1, 1).Range.Text = "มหาวท� ยาลย�ราชภฏ�รอ�ยเอด� "
            .Cell(2, 1).Range.Font.Bold = CInt(True)
            .Cell(2, 1).Range.Font.BoldBi = CInt(True)
            .Cell(2, 1).Range.Font.Size = 18
            .Cell(2, 1).Range.Font.SizeBi = 18
            .Cell(2, 1).Range.Font.Name = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(2, 1).Range.Font.NameBi = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(2, 1).Range.Text = "อา�เภอเสลภม� � จง�หวด�รอ�ยเอด� "
            .Cell(3, 1).Range.Font.Bold = CInt(True)
            .Cell(3, 1).Range.Font.BoldBi = CInt(True)
            .Cell(3, 1).Range.Font.Size = 18
            .Cell(3, 1).Range.Font.SizeBi = 18
            .Cell(3, 1).Range.Font.Name = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(3, 1).Range.Font.NameBi = "TH SarabunPSK" 'ส�าหรบ�ภาษาอง�กฤษ
            .Cell(3, 1).Range.Text = "ใบรายงานผลการ�ก�ษา (ตรวจสอบส�าเรจ�การ�ก�ษา)"
            .Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            .Cell(2, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            .Cell(3, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        End With
        objDoc.Paragraphs.Add()
    End Sub
End Class