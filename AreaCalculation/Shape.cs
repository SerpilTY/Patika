namespace AreaCalculation;
public class Shape{

public static void Choose(){
    Console.WriteLine("Enter the geometric shape whose area you want to calculate.(circle, square, rectangular, triangle)");
        string shape=Console.ReadLine().ToLower();

        switch (shape)
        {
          case "circle":
          AreaCalculation.Circle.Calculate();
            break;
            case "rectangle":
          AreaCalculation.Rectangle.Calculate();
            break;
            case "square":
          AreaCalculation.Square.Calculate();
            break;
            case "triangle":
          AreaCalculation.Triangle.Calculate();
            break;
          default:
          AreaCalculation.Error.DefaultError();
            break;
        }
}

}