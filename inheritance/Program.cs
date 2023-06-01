using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            tohumlubitki.beslenme();
            tohumlubitki.Solunum();
            tohumlubitki.Boşaltım();
            tohumlubitki.FotosentezYapmak();
            tohumlubitki.tohumlacogalma();

                System.Console.WriteLine("*****************");

            kuslar martı = new kuslar();
            martı.Solunum();
            martı.beslenme();
            martı.Boşaltım();
            martı.Adaptasyon();
            martı.ucmak();

           
            Console.ReadKey(); 
        }
        
    }
}   