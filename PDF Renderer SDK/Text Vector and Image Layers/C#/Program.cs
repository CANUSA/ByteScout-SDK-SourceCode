//*******************************************************************
//       ByteScout PDF Renderer SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;

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

            RenderingOptions renderingOptions = new RenderingOptions();

			// Enable text objects rendering
            renderingOptions.RenderTextObjects = true;
			// DISABLE vector objects rendering
			renderingOptions.RenderVectorObjects = false;
			// DISABLE image objects rendering
			renderingOptions.RenderImageObjects = false;
			
			// Load PDF document.
			renderer.LoadDocumentFromFile("multipage.pdf");

			for (int i = 0; i < renderer.GetPageCount(); i++)
			{
                // Render document page to PNG image file.
				renderer.Save("image" + i + ".png", RasterImageFormat.PNG, i, 300, renderingOptions);
			}

			// Open the first output file in default image viewer.
			System.Diagnostics.Process.Start("image0.png");
		}
	}
}
