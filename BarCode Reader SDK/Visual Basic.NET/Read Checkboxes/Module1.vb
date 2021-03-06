Imports System.IO
Imports Bytescout.BarCodeReader

Module Module1

    Sub Main()

        Dim ImageFile As String = "checkboxes-checked.png"

        Console.WriteLine("Reading checkboxes from image {0}", Path.GetFullPath(ImageFile))

        Dim reader As New Reader()
        reader.RegistrationName = "demo"
        reader.RegistrationKey = "demo"

        ' Enable check boxes recognition
        reader.BarcodeTypesToFind.Checkbox = True


        ' Find check boxes
        Dim barcodes = reader.ReadFrom(ImageFile)

        For Each barcode As FoundBarcode In barcodes
            Console.WriteLine("Found checkbox with type '{0}' and value '{1}'", barcode.Type, barcode.Value)
        Next

        Console.WriteLine("Press any key to exit..")
        Console.ReadKey()

    End Sub

End Module
