using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("girmiş olduğunuz sayı :" + sayi);
        }
    }
}
