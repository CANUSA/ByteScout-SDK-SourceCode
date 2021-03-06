'*******************************************************************
'       ByteScout PDF Renderer SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' Create Bytescout.PDFRenderer.RasterRenderer  object
Set renderer = CreateObject("Bytescout.PDFRenderer.RasterRenderer")

renderer.RegistrationName = "demo"
renderer.RegistrationKey = "demo"

' Load sample PDF document
renderer.LoadDocumentFromFile "../../multipage.pdf"

' Image format: 0 - BMP; 1 - JPEG; 2 - PNG; 3 - TIFF; 4 - GIF
Dim outputImageFormat
outputImageFormat = 2

' Render PDF document at 96 DPI - default PC display resolution
' To get higher quality output, set 200, 300 or more
Dim renderingResolution
renderingResolution = 96

Set renderingOptions = CreateObject("Bytescout.PDFRenderer.RenderingOptions")
' Set pixel format to 1-bit
renderingOptions.ImageBitsPerPixel = 0 ' 0 - 1-bit; 1 - 8-bit; 2 - 24-bit; 3 - 32-bit

' iterate through pages
For i = 0 To renderer.GetPageCount() - 1
	' Save 1-bit image to file
	renderer.Save_2 "page" & CStr(i) & ".bmp", outputImageFormat, i, renderingResolution, (renderingOptions)
Next

