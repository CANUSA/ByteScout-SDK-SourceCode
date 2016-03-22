﻿//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF;

namespace GraphicsState
{
	/// <summary>
	/// This example demonstrates how to save and restore the graphics state.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add page
			Page page = new Page(PaperFormat.A4);
			pdfDocument.Pages.Add(page);
			
			Canvas canvas = page.Canvas;

			// Keep current graphics state
			canvas.SaveGraphicsState();

			// Transform coordinates and draw rectangle
			canvas.TranslateTransform(200, 200);
			canvas.RotateTransform(45);
			canvas.DrawRectangle(new SolidBrush(new ColorRGB(0, 0, 255)), 0, 0, 100, 100);

			// Restore the state and draw the same rectangle
			canvas.RestoreGraphicsState();
			canvas.DrawRectangle(new SolidBrush(new ColorRGB(255, 0, 0)), 200, 200, 100, 100);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
