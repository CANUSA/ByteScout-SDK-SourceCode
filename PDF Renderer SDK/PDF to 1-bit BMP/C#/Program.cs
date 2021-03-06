//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Drawing;
using System.Drawing.Imaging;
using Bytescout.PDFRenderer;


namespace PDF2BMP
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

            RenderingOptions renderingOptions = new RenderingOptions();
            // Set pixel format to 1-bit
	        renderingOptions.ImageBitsPerPixel = ImageBitsPerPixel.BPP1;

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
				// Save 1-bit image to file
                renderer.Save("image" + i + ".bmp", RasterImageFormat.BMP, i, 200, renderingOptions);
			}

			// Open the first output image in default image viewer.
			System.Diagnostics.Process.Start("image0.bmp");
		}
	}
}
