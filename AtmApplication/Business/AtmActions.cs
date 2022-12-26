namespace AtmApplication
{
    public static class Business
    {
    public static void Withdrawal(){
        System.Console.WriteLine("You succesfully withdrawed money.");
        Logger.TransactionLog();
}
    public static void Payment(){
        System.Console.WriteLine("Your payment succesfully done.");
        Logger.TransactionLog();
}
    public static void Deposit(){
        System.Console.WriteLine("Your deposit succesfully done.");
        Logger.TransactionLog();
}

    
    }
}