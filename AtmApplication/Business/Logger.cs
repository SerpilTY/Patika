using System;
using System.IO;

namespace AtmApplication
{
    internal class Logger : ILogger
    {
        
        public void EndOfTheDayReadFile()
        {
            string filePath = @"C:\Kullanıcılar\Hp\Masaüstü\Metin Belgesi.txt";
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            string log = sr.ReadLine();

            while (log != null)
            {
                Console.WriteLine(log);
                log = sr.ReadLine();
            }

            sr.Close();
            fs.Close();
        }

        public void WriteFile(string message)
        {
            string filePath = @"C:\Kullanıcılar\Hp\Masaüstü\" + DateTime.Now.ToString("dd.MM.yyyy") + ".txt";
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(message);

            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}