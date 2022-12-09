namespace AreaCalculation;
public class Square{
    static int edge;
        
    static string dimension=Dimension.Choose();

    public static void Calculate(){
        System.Console.WriteLine("Enter the length of edge.");
        edge=int.Parse(Console.ReadLine().ToLower());

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
    System.Console.WriteLine("Perimeter of your shape based on given values: " +Perimeter);
    }

    public static void CalculateArea(int edge){
    double area=Math.Pow(edge,2);
    System.Console.WriteLine("Area of your shape based on given values: " +area);
    }

    public static void CalculateVolume(int edge){
    double volume=(Math.Pow(edge,3));
    System.Console.WriteLine("Volume of your shape based on given values: " +volume);
    }

}




