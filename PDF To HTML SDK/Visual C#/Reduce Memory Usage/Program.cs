﻿//*******************************************************************
//       ByteScout PDF To HTML SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using Bytescout.PDF2HTML;

namespace ReduceMemoryUsage
{
	class Program
	{
		static void Main(string[] args)
		{
            // When processing huge PDF documents you may run into OutOfMemoryException.
			// This example demonstrates a way to spare the memory by disabling page data caching.

            // Create Bytescout.PDF2HTML.HTMLExtractor instance
            using (HTMLExtractor extractor = new HTMLExtractor("demo", "demo"))
			{
			    try
			    {
			        // Load sample PDF document
			        extractor.LoadDocumentFromFile("sample2.pdf");

					// Disable page data caching, so processed pages wiil be disposed automatically
					extractor.PageDataCaching = PageDataCaching.None;

					// Save result to file
                    extractor.SaveHtmlToFile("output.html");
			    }
			    catch (PDF2HTMLException exception)
                {
                    Console.Write(exception.ToString());
                }
			}

			// Open the output file in default associated application
			System.Diagnostics.Process.Start("output.html");
		}
	}
}
