'*******************************************************************
'       ByteScout Spreadsheet SDK
'                                                                   
'       Copyright © 2016 Bytescout, http://www.bytescout.com        
'       ALL RIGHTS RESERVED                                         
'                                                                   
'*******************************************************************

Imports System.Diagnostics
Imports System.IO
Imports Bytescout.Spreadsheet

Class Program
	Friend Shared Sub Main(args As String())
		' Open spreadsheet from file
		Dim document As New Spreadsheet()
		document.LoadFromFile("example.xls")

		' Get first worksheet
		Dim worksheet As Worksheet = document.Workbook.Worksheets(0)

		' Hide formula in B9 cell
		worksheet.Cell("B9").HiddenFormula = True
		' Protect the worksheet with password
		worksheet.Protect("password")

		' Delete output file if exists
		If File.Exists("changed.xls") Then
			File.Delete("changed.xls")
		End If

		' Save document
		document.SaveAs("changed.xls")

		' Close spreadsheet
		document.Close()

		' Open generated XLS document in default program
		Process.Start("changed.xls")
	End Sub
End Class
