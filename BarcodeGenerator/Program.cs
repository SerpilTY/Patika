using BarcodeLib;
using barcode_generator_reader;

namespace BarcodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the barcode generation process...");
            Console.WriteLine("Please select the action you want to do.");
            int process=0;
             do
                {
                    printOptions();
                    try
                    {
                        process = Convert.ToInt32(Console.ReadLine());
                    }
                    catch{}
                    if(process == 1)
                    {
                        Console.WriteLine("Please enter the barcode sequence number:");
                        string value = Console.ReadLine();
                        if(value.Length > 2) 
                    {
                        Barcode barcode =Process.CreateAndSaveBarcode(value);
                        StreamWriter Yaz = new StreamWriter(@"C:\Users\serpil\Desktop\kayit.txt",true);  
                        Yaz.WriteLine("Barcode Value: " + barcode.RawData);  
                        Yaz.Close();
                    }else{Console.WriteLine("You made a wrong or incomplete keying...");}
                
                }
                else if(process == 2)
                {
                    Console.WriteLine("Please enter the barcode sequence number:");
                    string value = Console.ReadLine();
                    Barcode barcode = new Barcode(value);
                    Process.ReadBarcode(barcode);
                    if(barcode.RawData == value)
                    {
                        Console.WriteLine(Process.ReadBarcode(barcode));
                    }

                }
                }
                while(process != 3);
                Console.WriteLine("Thank you, have a nice day.");
        }

        private static void printOptions()
        {
            Console.WriteLine("Please select the action you want to do...");
            Console.WriteLine("1 - Barcode Generating");
            Console.WriteLine("2 - Barcode Reading");
            Console.WriteLine("3 - Quit");
        }
    }
}
