'*******************************************************************
'       ByteScout PDF Extractor SDK
'                                                                   
'       Copyright © 2017 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports Bytescout.PDFExtractor

Namespace ConsoleApplication1
    Class Program
        Shared Sub Main(ByVal args As String())

            ' Create Bytescout.PDFExtractor.XMLExtractor instance
            Dim extractor As New XMLExtractor()
            extractor.RegistrationName = "demo"
            extractor.RegistrationKey = "demo"

            ' Load sample PDF document
            extractor.LoadDocumentFromFile("sample1.pdf")

            ' Uncomment this line to get rid of empty nodes in XML
            'extractor.PreserveFormattingOnTextExtraction = False

            ' Set output image format
            extractor.ImageFormat = OutputImageFormat.PNG

            ' Save images to external files
            extractor.SaveImages = ImageHandling.OuterFile
            extractor.ImageFolder = "images" ' Folder for external images
            extractor.SaveXMLToFile("result_with_external_images.xml")

            ' Embed images into XML as Base64 encoded string
            extractor.SaveImages = ImageHandling.Embed
            extractor.SaveXMLToFile("result_with_embedded_images.xml")

        End Sub
    End Class
End Namespace

