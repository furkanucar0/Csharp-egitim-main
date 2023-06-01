using System;

namespace csharp_enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Günler.pazar);
            System.Console.WriteLine((int)Günler.cumartesi);

            int sicaklik = 32;

            if (sicaklik <=(int)HavaDurumu.normal)
            {
                System.Console.WriteLine("Dişariya çikmak biraz daha havanin isinmasini bekleyin!!");
            }
            else if (sicaklik >= (int)HavaDurumu.sicak)
            {
                System.Console.WriteLine("Dişariya çikmak için sicak bir gün!!");
            }
            else if (sicaklik >= (int)HavaDurumu.normal && sicaklik<(int)HavaDurumu.Çoksicak)
            {
                Console.WriteLine("Hadi dişariya cikalim!!!");
            }

            
            Console.ReadKey();
        }
    }
    enum Günler
    {
        pazartesi,
        sali =1,
        çarşamba,
        perşembe,
        cuma = 23 ,
        cumartesi,
        pazar
    }
    enum HavaDurumu
    {
        soguk = 5,
        normal = 20,
        sicak = 30,
        Çoksicak = 34

    }
}