namespace AreaCalculation;
public class Circle{


    static int radius;
    static string dimension=Dimension.Choose();

    public static void Calculate(){
    System.Console.WriteLine("Enter the radius size.");
    radius=int.Parse(Console.ReadLine());

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
    System.Console.WriteLine("Perimeter of your shape based on given values: " + Perimeter);
    }

    public static void CalculateArea(int radius){
    double area=(Math.PI)*(Math.Pow(radius,2));
    System.Console.WriteLine("Area of your shape based on given values: " +area);
    }

    public static void CalculateVolume(int radius){
    double volume=0.75*(Math.PI)*(Math.Pow(radius,3));
    System.Console.WriteLine("Volume of your shape based on given values: " +volume);
    }

}
