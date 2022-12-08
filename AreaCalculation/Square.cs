namespace AreaCalculation;
public class Square{
    static int edge=int.Parse(Console.ReadLine());
    static string dimension=Dimension.Choose();

    public static void Calculate(){

            switch (Square.dimension)
            {
                case "perimeter":
                Square.CalculatePerimeter(edge);
                    break;
                case "area":
                Square.CalculateArea(edge);
                    break; 
                case "volume":
                Square.CalculateVolume(edge);  
                    break; 
                default:
                    break;
            }
    }
    
    public static void CalculatePerimeter(int edge){
    double Perimeter=4*edge;
    System.Console.WriteLine(Perimeter);
    }

    public static void CalculateArea(int edge){
    double area=Math.Pow(edge,2);
    System.Console.WriteLine(area);
    }

    public static void CalculateVolume(int edge){
    double volume=(Math.Pow(edge,3));
    System.Console.WriteLine(volume);
    }

}




