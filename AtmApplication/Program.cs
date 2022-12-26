namespace AtmApplication;
class Program
{
    static void Main(string[] args)
    {
        if (Register.SignIn())
        {
            System.Console.WriteLine("Which operation you would like to do?");
            System.Console.WriteLine("Press 1 for Withdrawal, 2 for Payment and 3 for Deposit please.");
            string operation = Console.ReadLine();
            if (operation == "1") Business.Withdrawal();
            else if (operation == "2") Business.Payment();
            else if (operation == "3") Business.Deposit();
        }
    }
}
