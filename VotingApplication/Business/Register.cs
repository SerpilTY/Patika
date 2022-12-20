namespace Business;

public class Register{
public static void SignIn()
    {


        Console.WriteLine("You are welcome, Please enter your user name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Please enter your password:");
        string password = Console.ReadLine();
        UserController userController = new UserController();
        bool a = userController.Controller(userName, password);


        if (a == true)
        {
            Console.WriteLine("Succesfully Signed In.");
            Business.Vote.VoteNow();
        }
        if (a == false)
        {
            SignUp();
        }
    }

    public static void SignUp()
    {
        Console.WriteLine("Enter your username to sing up");
        string newUserName = Console.ReadLine();
        Console.WriteLine("Enter your password");
        string newPassword = Console.ReadLine();
        UserController userController = new UserController();
        bool c = userController.AddUser(newUserName, newPassword);
        if (c == true)
        {
            Console.WriteLine("Signed up Succesfully!");
            Business.Vote.VoteNow();
        }
        else Console.WriteLine("That username has already taken. ");
    }

}