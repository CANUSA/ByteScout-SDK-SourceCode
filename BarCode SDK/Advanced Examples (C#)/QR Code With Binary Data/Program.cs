﻿//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Diagnostics;
using System.Text;
using Bytescout.BarCode;

namespace QRCodeWithBinaryData
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Barcode component instance
			using (Barcode barcode = new Barcode())
			{
				barcode.RegistrationName = "demo";
				barcode.RegistrationKey = "demo";

				// Set barcode type
				barcode.Symbology = SymbologyType.QRCode;

				// Sample byte array to use as value  
				byte[] byteArray = new byte[] { 0, 10, 11, 12, 13, 14, 15, 0xFF };

				// Set value by converting byte array to string  
				barcode.Value = Encoding.Default.GetString(byteArray);

				// Save barcode image
				barcode.SaveImage("result.png");

				// Open output image in default associated application
				Process.Start("result.png");
			}
		}
	}
}
