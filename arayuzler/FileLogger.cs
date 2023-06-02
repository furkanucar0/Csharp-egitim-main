using System;

namespace arayuzler
{
    public class FileLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Dosyaya Log Yazar.");
        }
    }
}