'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDF

''' <summary>
''' This example demonstrates how add text watermark to document page.
''' </summary>
Class Program

    Shared Sub Main()

        ' Create new document
        Dim pdfDocument = New Document()
        pdfDocument.RegistrationName = "demo"
		pdfDocument.RegistrationKey = "demo"
        ' Add pages
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))
        pdfDocument.Pages.Add(New Page(PaperFormat.A4))

        ' Add autosized watermark to every page of the document
        Dim watermark1 = New TextWatermark("Diagonal Watermark")
        watermark1.WatermarkLocation = TextWatermarkLocation.DiagonalFromBottomLeftToTopRight
        watermark1.Font = New Font("Times New Roman", 16)
        Dim brush As SolidBrush = New SolidBrush(New ColorRGB(255, 0, 0))
        brush.Opacity = 50 ' make the brush semitransparent
        watermark1.Brush = brush
        watermark1.Pen = New SolidPen(New ColorRGB(255, 0, 0)) ' outline pen is optional
        pdfDocument.Watermarks.Add(watermark1)

        ' Add watermark of custom size and location to the first page only
        Dim watermark2 = New TextWatermark("Simple Watermark")
        watermark2.Font = New Font(StandardFonts.HelveticaBold, 24)
        watermark2.Brush = New SolidBrush(New ColorRGB(0, 128, 0))
        watermark2.Left = 350
        watermark2.Top = 800
        pdfDocument.Pages(0).Watermarks.Add(watermark2)

        ' Save document to file
        pdfDocument.Save("result.pdf")

        ' Cleanup 
		pdfDocument.Dispose()

        ' Open document in default PDF viewer app
        Process.Start("result.pdf")

    End Sub

End Class
