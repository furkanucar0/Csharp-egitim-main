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
            tohumlubitki.Boşaltim();
            tohumlubitki.FotosentezYapmak();
            tohumlubitki.tohumlacogalma();

                System.Console.WriteLine("*****************");

            kuslar marti = new kuslar();
            marti.Solunum();
            marti.beslenme();
            marti.Boşaltim();
            marti.Adaptasyon();
            marti.ucmak();

           
            Console.ReadKey(); 
        }
        
    }
}   