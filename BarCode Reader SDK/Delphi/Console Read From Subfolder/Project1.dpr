//*******************************************************************
//       ByteScout Barcode Reader SDK		                                     
//                                                                   
//       Copyright � 2016 ByteScout - http://www.bytescout.com       
//       ALL RIGHTS RESERVED                                         
//                                                                   
//*******************************************************************

program Project1;

{$APPTYPE CONSOLE}

{
 Sample that shows reading of barcodes from images in /Images/ subfolder
}

uses
  SysUtils,
  ComObj,
  ActiveX;
var
 reader: Variant;
 SR: TSearchRec;
 arrayOutput: Variant;
 varItem: Variant;
 i: integer;
 pathWithImages, imageType: string;
begin
 CoInitialize(nil);

 // Disable floating point exception to conform to .NET floating point operations behavior.
 System.Set8087CW($133f);

 // Create and initialize Bytescout.BarCodeReader.Reader object
 reader := CreateOleObject('Bytescout.BarCodeReader.Reader');
 reader.RegistrationName := 'demo';
 reader.RegistrationKey := 'demo';

 // Enable Code 39 decoding, you may also enable other types (dozens of types supported)
 // see .BarCodeTypesToFind for more values.
 reader.BarcodeTypesToFind.Code39 := true;

 // For example to enable Code128 uncomment line below
 // reader.BarcodeTypesToFind.Code128 := true;

 // For example to enable QR Code uncomment line below
 // reader.BarcodeTypesToFind.QRCode := true;

 // Setup possible barcode orientations ( ato support rotated images)
 // see BarCode Reader SDK - OrientationType enum for more variations
 // uncomment to support more orientations like right to left 
 {
 reader.Orientation :=
					1 or //OrientationType.HorizontalFromLeftToRight
					16 or // OrientationType.HorizontalFromRightToLeft
					32768 or // OrientationType.VerticalFromBottomToTop
					2; // OrientationType.VerticalFromTopToBottom;
 }

 // uncomment to enable processing of negative barcodes (white bars on dark background)
 // reader.SearchNegative := true;

 // uncomment to Enable Heuristic Mode (try different image processing modes if the default failed).
 // Helps on photos with poor lighting conditions.
 //reader.HeuristicMode := true;

 // define subfolder where we have images 
 pathWithImages := '.\Images\';
 imageType := '*.jpg'; // can also be *.png, *.tiff, *.bmp, *.PDF

 // now search for files with images and processing them one by one
 if FindFirst(pathWithImages + imageType, faAnyFile, SR) = 0 then begin
    repeat
      if (SR.Attr <> faDirectory) then begin
        writeLn(SR.Name);
        writeLn('------------------');
        // processing the file
        reader.ReadFromFile(pathWithImages + SR.Name);
        for i := 0 to reader.FoundCount - 1 do begin
          writeLn(
            '#' + IntToStr(i) + ' barcode with value ' +
            reader.GetFoundBarcodeValue(i)+
            ' at ' + FloatToStr(reader.GetFoundBarCodeLeft(i)) +
            ',' + FloatToStr(reader.GetFoundBarCodeTop(i))
          );
        end;
        writeLn('------------------');
      end;
    until FindNext(SR) <> 0;
    FindClose(SR);
 end;

 WriteLn('Press any key to exit...');
 ReadLn;

 reader := varEmpty;

end.

