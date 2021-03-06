//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using Bytescout.PDF;

namespace Watermarks
{
	/// <summary>
	/// This example demonstrates how add text watermark to document page.
	/// </summary>
	class Program
	{
		static void Main()
		{
			// Create new document
			Document pdfDocument = new Document();
			pdfDocument.RegistrationName = "demo";
			pdfDocument.RegistrationKey = "demo";
			// Add pages
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));
            pdfDocument.Pages.Add(new Page(PaperFormat.A4));

			// Add autosized watermark to every page of the document
            TextWatermark watermark1 = new TextWatermark("Diagonal Watermark");
            watermark1.WatermarkLocation = TextWatermarkLocation.DiagonalFromBottomLeftToTopRight;
		    watermark1.Font = new Font("Times New Roman", 16);
		    SolidBrush brush = new SolidBrush(new ColorRGB(255, 0, 0));
		    brush.Opacity = 50; // make the brush semitransparent
		    watermark1.Brush = brush;
            watermark1.Pen = new SolidPen(new ColorRGB(255, 0, 0)); // outline pen is optional
		    pdfDocument.Watermarks.Add(watermark1);

            // Add watermark of custom size and location to the first page only
            TextWatermark watermark2 = new TextWatermark("Simple Watermark");
            watermark2.Font = new Font(StandardFonts.HelveticaBold, 24);
		    watermark2.Brush = new SolidBrush(new ColorRGB(0, 128, 0));
            watermark2.Left = 350;
            watermark2.Top = 800;
            pdfDocument.Pages[0].Watermarks.Add(watermark2);
			
			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer app
			Process.Start("result.pdf");
		}
	}
}
