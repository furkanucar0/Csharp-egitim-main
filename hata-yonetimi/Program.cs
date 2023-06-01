using System;

namespace hata_yonetimi
{
     class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 sayı giriniz;");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+ sayi);
        }
    }

}