namespace DrawTriangle;

public class SomeTraingles
{
    public static void LeftSidedTriangle(int a)
    {
        
        for (int i = 0; i <= a; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
        }
    }

    public static void PineTreeTriangle(int a){
         for (int i = 0; i < a; i++) 
         {
             for (int k = i; k < a; k++)
             {
                 Console.Write(" ");
             }
             for (int x = 0; x <= i; x++)
             {
                 Console.Write("*"); 
                 Console.Write(" ");
             }
             Console.WriteLine();
         }
    }
    public static void RightSidedTriangle(int a){
        for (int i = 0; i < 7; i++) 
         {
             for (int k = i; k < 7; k++) 
             {
                 Console.Write(" "); 
             }
             for (int x = 0; x <= i; x++)
             {
                 Console.Write("*");  
                 Console.Write(""); 
             }
             Console.WriteLine();
         }
    }
}