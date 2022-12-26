namespace AtmApplication
{
    public static class Logger
    {
        public static void FraudDetected()
        {
            System.Console.WriteLine("Invalid Register, Logging as Fraud Detection.");
        }
        public static void TransactionLog()
        {
            System.Console.WriteLine("Transaction Occured, Logging as Transaction Log.");
        }

    }
}