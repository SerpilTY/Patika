namespace AreaCalculation;
public class Rectangle{
    static int edge1=int.Parse(Console.ReadLine());
    static int edge2=int.Parse(Console.ReadLine());
    static int edge3=int.Parse(Console.ReadLine());

    static string dimension=Dimension.Choose();

    public static void Calculate(){

            switch (Rectangle.dimension)
            {
                case "perimeter":
                Rectangle.CalculatePerimeter(edge1,edge2);
                    break;
                case "area":
                Rectangle.CalculateArea(edge1,edge2);
                    break; 
                case "volume":
                Rectangle.CalculateVolume(edge1,edge2,edge3);  
                    break; 
                default:
                    break;
            }
    }
    
    public static void CalculatePerimeter(int edge1,int edge2){
    double Perimeter=2*edge1+2*edge2;
    System.Console.WriteLine(Perimeter);
    }

    public static void CalculateArea(int edge1,int edge2){
    double area=edge1*edge2;
    System.Console.WriteLine(area);
    }

    public static void CalculateVolume(int edge1,int edge2,int edge3){
    double volume=edge1*edge2*edge3;
    System.Console.WriteLine(volume);
    }

}




