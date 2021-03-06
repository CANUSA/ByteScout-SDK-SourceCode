//*******************************************************************
//       ByteScout PDF Extractor SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System;
using System.Diagnostics;
using System.Drawing;
using Bytescout.PDFExtractor;

namespace RemoveText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Bytescout.PDFExtractor.Remover instance
            Remover remover = new Remover("demo", "demo");

            // Load sample PDF document
            remover.LoadDocumentFromFile(@"sample1.pdf");

            // Remove text "LOREM IPSUM" and save edited document as "result1.pdf".
            // NOTE: The removed text might be larger than the search string. Currently the Remover deletes 
            // the whole PDF text object containing the search string.
            remover.RemoveText(0, "LOREM IPSUM", true, @"result1.pdf");

            // Remove text objects contained in the specified rectangle or intersecting with it.
            // NOTE: The removed text might be larger than the specified rectangle. Currently the Remover is unable 
            // to split PDF text objects.
            remover.RemoveText(0, new RectangleF(74f, 550f, 489f, 67f), @"result2.pdf");

            // Remove text object contained in the specified point.
            // NOTE: The removed text might be larger than a word in the specified point. Currently the Remover is able 
            // to remove only the whole PDF text object containing the word.
            remover.RemoveText(0, new PointF(121f, 230f), @"result3.pdf");
            
            // Clean up.
            remover.Dispose();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue and open result PDF files in default PDF viewer...");
            Console.ReadKey();

            Process.Start("result1.pdf");
            Process.Start("result2.pdf");
            Process.Start("result3.pdf");
        }
    }
}
