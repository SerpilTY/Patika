using System.Reflection.Metadata;
namespace AtmApplication
{
    public  class Register
    {

        public static List<Entities.User> Users = new List<Entities.User>();
        

        public static bool UserCheck()
        {
            
            System.Console.WriteLine("Welcome to ATM, Please enter your cardNumber: ");
            string CardNumber = Console.ReadLine();
            System.Console.WriteLine("Please enter your password: ");
            string Password = Console.ReadLine();
            Logger logger=new Logger();
           
            foreach (var item in Users)
            {
                if (CardNumber == item.CardNumber && Password == item.Password)
                {
                    System.Console.WriteLine("You are successfully signed in to system.");
                    return true;
                }

                else
                {
                    string message="Invalid entry, please register your Card.";
                    System.Console.WriteLine(message);
                    logger.WriteFile(message) ;
                    RegisterCard();
                    return false;
                }
          }return false;

        }

        public static void RegisterCard()
        {
            System.Console.WriteLine("Welcome to Atm, please enter your card number");
            Entities.User User = new Entities.User();
            User.CardNumber = Console.ReadLine();
            System.Console.WriteLine("Welcome to Atm, please enter your password");
            User.Password = Console.ReadLine();
            User.Id=(Users.Count()+1);
            Users.Add(User);
        }
    }
}