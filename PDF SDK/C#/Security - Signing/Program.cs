//*******************************************************************
//       ByteScout PDF SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using System.Drawing;
using Bytescout.PDF;
using Font = Bytescout.PDF.Font;
using SolidBrush = Bytescout.PDF.SolidBrush;
using StringFormat = Bytescout.PDF.StringFormat;

namespace Signing
{
	/// <summary>
	/// This example demonstrates how to digitally sign PDF document.
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

			// Add sample page content
			SolidBrush brush = new SolidBrush();
			Font font = new Font("Arial", 16);
			RectangleF rect = new RectangleF(0, 50, page.Width, 100);
			StringFormat stringFormat = new StringFormat();
			stringFormat.HorizontalAlign = HorizontalAlign.Center;
			page.Canvas.DrawString("Signature Test", font, brush, rect, stringFormat);

			// Signing parameters
			string certficateFile = ".\\demo_certificate.pfx";
			string certficatePassword = "123";
			// Optional parameters
			string signingReason = "Approval";
			string contactName = "John Smith";
			string location = "Corporate HQ";
			
			// Invisible signature
			//pdfDocument.Sign(certficateFile, certficatePassword);
			
			// Visible signature
			RectangleF signatureRect = new RectangleF(400, 50, 150, 100);
			pdfDocument.Sign(certficateFile, certficatePassword, signatureRect, signingReason, contactName, location);

			// Save document to file
			pdfDocument.Save("result.pdf");

			// Cleanup 
			pdfDocument.Dispose();

			// Open document in default PDF viewer application
			Process.Start("result.pdf");
		}
	}
}
