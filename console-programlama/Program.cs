using System;

namespace console_programlama
{
    internal class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Merhaba Dünya!");
        
            Console.WriteLine("İsminizi Giriniz");
            var name = Console.ReadLine();
            Console.WriteLine("Soyadinizi Giriniz");
            var Surname = Console.ReadLine();

            Console.WriteLine("Merhaba: " + name + " " + Surname);
            Console.ReadKey();
        }
    }
}
