using System;

namespace AreaCalculation;

public class Dimension{
    
 public static string Choose(){
    System.Console.WriteLine("Enter the dimension you want to calculate.(like the perimeter, area or volume) ");

   string _dimension=Console.ReadLine();
   return _dimension;
 }
}
