//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.IO;
using System.Drawing;
using Bytescout.PDFRenderer;


namespace PDF2PNG
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
			RasterRenderer renderer = new RasterRenderer();
			renderer.RegistrationName = "demo";
			renderer.RegistrationKey = "demo";

			// Load PDF document.
			renderer.LoadDocumentFromFile("multipage.pdf");

            // Iterate through pages
			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Render document page and save to memory stream
                    renderer.Save(memoryStream, RasterImageFormat.PNG, i, 300);
                    
                    // Create image from memory stream
                    Image pngImg = Image.FromStream(memoryStream);
                    // Save image to file
                    pngImg.Save(i + ".png");
                }
			}

			// Open the first output file in default image viewer.
            // open the very first page
			System.Diagnostics.Process.Start("0.png");
		}
	}
}
