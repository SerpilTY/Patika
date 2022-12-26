namespace AtmApplication
{
    public static class Register
    {

        public static List<Entities.User> Users = new List<Entities.User>();


        public static bool SignIn()
        {
            System.Console.WriteLine("Welcome to ATM, Please enter your cardNumber: ");
            string CardNumber = Console.ReadLine();
            System.Console.WriteLine("Please enter your password: ");
            string Password = Console.ReadLine();

            foreach (var item in Users)
            {
                if (CardNumber == item.CardNumber && Password == item.Password)
                {
                    System.Console.WriteLine("You are successfully signed in to system.");
                    return true;
                }

                else
                {
                    System.Console.WriteLine("Invalid entry, please sign up your Card.");
                    return false;
                    Logger.FraudDetected();
                    SignUp();

                }
            }
            return true;
        }

        public static void SignUp()
        {
            System.Console.WriteLine("Welcome to Atm, please enter your card number");
            Entities.User User = new Entities.User();
            User.CardNumber = Console.ReadLine();
            System.Console.WriteLine("Welcome to Atm, please enter your password");
            User.Password = Console.ReadLine();
        }
    }
}