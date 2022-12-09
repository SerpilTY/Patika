using System.Collections;

namespace SumofIntegerBinaries;

public class Issue{

   public static ArrayList FinalDizi = new ArrayList();

public static void GetAndCalculateValues(){
    System.Console.WriteLine("Enter n numbers, could be seperate or same. Write down how much number you will enter");
        int n = int.Parse(System.Console.ReadLine());
        int[] Numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            System.Console.WriteLine("Enter the {0}. number: ",i+1);
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        double sonuc;
       
        for (int i = 0; i < n; i +=2)
        {
            if (Numbers[i] == Numbers[i + 1])
            {
                sonuc = Math.Pow((Numbers[i] + Numbers[i + 1]), 2);
                System.Console.Write(sonuc+" ");
            }
            else if (Numbers[i] != Numbers[i + 1])
            {
                sonuc = (Numbers[i] + Numbers[i + 1]);
                System.Console.Write(sonuc+" ");
            }
            else continue;
        }
}    }