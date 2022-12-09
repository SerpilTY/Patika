namespace AreaCalculation;
public class Rectangle{

    static int edge1;
    static int edge2;
    static int edge3;
     

    static string dimension=Dimension.Choose();

    public static void Calculate(){

        System.Console.WriteLine("Enter the length of first dimension.");
        edge1=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the length of second dimension.");
        edge2=int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the length of third dimension.");
        edge3=int.Parse(Console.ReadLine());

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
    double Perimeter=2*(edge1+edge2);
    System.Console.WriteLine("Perimeter of your shape based on given values: " +Perimeter);
    }

    public static void CalculateArea(int edge1,int edge2){
    double area=edge1*edge2;
    System.Console.WriteLine("Area of your shape based on given values: " +area);
    }

    public static void CalculateVolume(int edge1,int edge2,int edge3){
    double volume=edge1*edge2*edge3;
    System.Console.WriteLine("Volume of your shape based on given values: " +volume);
    }

}




