namespace AtmApplication;
class Program
{
    static void Main(string[] args)
    {
        Entities.User user = new Entities.User();
        user.Id = 1;
        user.CardNumber = "54";
        user.Password = "55";
        Register.Users.Add(user);
        Logger logger = new Logger();

        if (Register.UserCheck())
        {

            System.Console.WriteLine("Which operation you would like to do?");
            System.Console.WriteLine("Press 1 for Withdrawal, 2 for Payment and 3 for Deposit please.");
            string operation = Console.ReadLine();
            Business Atm = new Business();
            if (operation == "1") Atm.Withdrawal();
            else if (operation == "2") Atm.Payment();
            else if (operation == "3") Atm.Deposit();
        }

        logger.EndOfTheDayReadFile();

    }
}

