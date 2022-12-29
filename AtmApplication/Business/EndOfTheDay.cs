namespace AtmApplication
{
    public static class EndOfTheDay
    {
        public static void TransactionLog()
        {
            string writeText="Transaction Occured, Logging as Transaction Log.";
            
            string fileName = @"C:\EOD_#Tarih#.txt";
            string logFileName=fileName.Replace("#Tarih#", DateTime.Now.ToString("ddMMyyy"));

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }

        public static void FraudDetected()
        {
            string writeText="Invalid Register, Logging as Fraud Detection.";    
            string fileName = @"C:\EOD_#Tarih#.txt";
            string logFileName=fileName.Replace("#Tarih#", DateTime.Now.ToString("ddMMyyy"));

            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(fileName, Environment.NewLine + writeText);
        }

    }
}