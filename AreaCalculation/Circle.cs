namespace AreaCalculation;
public class Circle{

    static int radius=int.Parse(Console.ReadLine());
    static string dimension=Dimension.Choose();

    public static void Calculate(){

            switch (Circle.dimension)
            {
                case "perimeter":
                Circle.CalculatePerimeter(radius);
                    break;
                case "area":
                Circle.CalculateArea(radius);
                    break; 
                case "volume":
                Circle.CalculateVolume(radius);  
                    break; 
                default:
                    break;
            }
    }
    
    public static void CalculatePerimeter(int radius){
    double Perimeter=2*(Math.PI)*radius;
    System.Console.WriteLine(Perimeter);
    }

    public static void CalculateArea(int radius){
    double area=(Math.PI)*(Math.Pow(radius,2));
    System.Console.WriteLine(area);
    }

    public static void CalculateVolume(int radius){
    double volume=0.75*(Math.PI)*(Math.Pow(radius,3));
    System.Console.WriteLine(volume);
    }

}
