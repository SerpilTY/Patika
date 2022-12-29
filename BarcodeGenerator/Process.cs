using BarcodeLib;
using System;
using System.Text.Json;

namespace barcode_generator_reader
{
    class Process
    {
        static TYPE type = BarcodeLib.TYPE.PHARMACODE;
        public static Barcode CreateAndSaveBarcode(string data)
        {

            Barcode barcode = new Barcode(data, type);
            barcode.Encode(type, data);
            barcode.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barcode created and saved, stored data -> {0}", data);
            return barcode;
        }

        public static string ReadBarcode(Barcode barcode)
        {
            return "Barcode value = " + barcode.RawData + " \n";
        }
    }
}