using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            bool sonuc =int.TryParse(sayi, out int outsayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı:");
                Console.WriteLine(outsayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }
            metotlar instance = new metotlar();
            instance.topla(4,5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

            int ifade = 999;
            instance.ekranayazdir(Convert.ToString(ifade));
            instance.ekranayazdir(ifade);
            instance.ekranayazdir("Furkan" +" "+"Uçar");

        }
    }
    class metotlar
    {
        public void topla(int a, int b, out int toplam)
        {
            toplam = a+b;

        }
        public void ekranayazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void ekranayazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1, veri2);
        }

    }
}