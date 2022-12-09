namespace AreaCalculation;
public class Triangle{
    static int baseEdge;
    static int heigth;
    static int edge2;
    static int edge3;
    static int prismHeight;
    static string dimension=Dimension.Choose();
    
    
    public static void Calculate(){

    System.Console.WriteLine("Please enter the length of base edge");
    baseEdge=int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of height");
    heigth=int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of second edge");
    edge2=int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of third edge");
    edge3=int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the length of prism height");
    prismHeight=int.Parse(Console.ReadLine());

            switch (Triangle.dimension)
            {
                case "perimeter":
                Triangle.CalculatePerimeter(edge2,edge3,baseEdge);
                    break;
                case "area":
                Triangle.CalculateArea(baseEdge,heigth);
                    break; 
                case "volume":
                Triangle.CalculateVolume(baseEdge,heigth,prismHeight);  
                    break; 
                default:
                    break;
            }
    }
    
    public static void CalculatePerimeter(int edge1,int edge2,int baseEdge){
    double Perimeter=baseEdge+edge1+edge2;
    System.Console.WriteLine("Perimeter of your shape based on given values: " +Perimeter);
    }

    public static void CalculateArea(int baseEdge,int heigth){
    double area=(baseEdge*heigth)/2;
    System.Console.WriteLine("Area of your shape based on given values: " +area);
    }

    public static void CalculateVolume(int baseEdge,int heigth,int prismHeight){
    double volume=(baseEdge*heigth*prismHeight)/2;
    System.Console.WriteLine("Volume of your shape based on given values: " +volume);
    }

}
