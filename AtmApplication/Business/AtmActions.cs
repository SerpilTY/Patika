namespace AtmApplication
{
    public class Business
    {
        Logger logger=new Logger();
        public void Withdrawal()
        {
            string message="You succesfully withdrawed money.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);
            
            
        }
        public void Payment()
        {
            string message="Your payment succesfully done.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);
            
        }
        public  void Deposit()
        {
            string message="Your deposit succesfully done.";
            System.Console.WriteLine(message);
            logger.WriteFile(message);
        }
    }
}