'*******************************************************************
'       ByteScout PDF SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

' This example demonstrates how to copy pages from one document to another

' Open first document
Set pdfDocument1 = CreateObject("Bytescout.PDF.Document")
pdfDocument1.RegistrationName = "demo"
pdfDocument1.RegistrationKey = "demo"
pdfDocument1.Load("document1.pdf")
' Open second document
Set pdfDocument2 = CreateObject("Bytescout.PDF.Document")
pdfDocument2.RegistrationName = "demo"
pdfDocument2.RegistrationKey = "demo"
pdfDocument2.Load("document2.pdf")

' Add pages from document2 to document1
For i = 0 To pdfDocument2.Pages.Count - 1
    pdfDocument1.Pages.Add(pdfDocument2.Pages.Item(i))
Next

' Save document to file
pdfDocument1.Save("merged.pdf")

' Open document in default PDF viewer app
Set shell = CreateObject("WScript.Shell")
shell.Run "merged.pdf", 1, false
