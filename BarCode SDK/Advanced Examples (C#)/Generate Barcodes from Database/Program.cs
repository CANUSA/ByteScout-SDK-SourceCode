﻿//*******************************************************************
//       ByteScout BarCode SDK		                                     
//                                                                   
//       Copyright © 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

using System.Data.OleDb;
using Bytescout.BarCode;

namespace GenerateFromDatabase
{
	class Program
	{
		static void Main(string[] args)
		{
			// Create Barcode generator instance 
			using (Barcode barcode = new Barcode())
			{
				// Set barcode type to QR Code
				barcode.Symbology = SymbologyType.QRCode;

				// Create database connection
				using (OleDbConnection connection =
					new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=demodb.mdb;User Id=admin;Password=;"))
				{
					connection.Open();

					// Create SQL query
					using (OleDbCommand command = connection.CreateCommand())
					{
						command.CommandText = "SELECT title FROM Books";

						OleDbDataReader dataReader = command.ExecuteReader();

						// Iterate values and generate barcode images 
						int i = 0;
						while (dataReader.Read())
						{
							barcode.Value = dataReader.GetString(0);
							barcode.SaveImage(i + ".png");
							i++;
						}
					}
				}
			}
		}
	}
}
