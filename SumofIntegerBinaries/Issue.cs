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
            System.Console.WriteLine("Enter a number: ");
            Numbers[i] = int.Parse(Console.ReadLine());
        }
        double sonuc;
        for (int i = 0; i < 1; i++)
        {
            if (Numbers[i] == Numbers[i + 1])
            {
                sonuc = Math.Pow((Numbers[0] + Numbers[1]), 2);
                FinalDizi.Add(sonuc);
            }
            else if (Numbers[i] != Numbers[i + 1])
            {
                sonuc = (Numbers[0] + Numbers[1]);
                FinalDizi.Add(sonuc);
            }
        }
        for (int i = 2; i < n; i++)
        {
            if (i % 2 == 0 && Numbers[i] == Numbers[i + 1])
            {
                sonuc = Math.Pow((Numbers[i] + Numbers[i + 1]), 2);
                FinalDizi.Add(sonuc);
            }
            else if (i % 2 == 0 && Numbers[i] != Numbers[i + 1])
            {
                sonuc = (Numbers[i] + Numbers[i + 1]);
                FinalDizi.Add(sonuc);
            }
            else break;
        }
}    
public static void PrintValues(IEnumerable myList)
        {
            Console.WriteLine("*****************");
            foreach (Object obj in myList)
            Console.Write("   {0}", obj);
            Console.WriteLine("\n*****************");
        }
}