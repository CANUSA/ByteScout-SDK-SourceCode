'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFRenderer.VectorRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.VectorRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' iterate through pages
For i = 0 To renderer.GetPageCount() - 1

	' Render document page to EMF image file
    renderer.Save "image" & i & ".emf", i, 300

Next


