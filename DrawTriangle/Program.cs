namespace DrawTriangle;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Taban uzunluğunu girin.");
        int a = Convert.ToInt32(Console.ReadLine());
        SomeTraingles.LeftSidedTriangle(a);
        SomeTraingles.RightSidedTriangle(a);
        SomeTraingles.PineTreeTriangle(a);
       
    }
}
