using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumlubitki = new TohumluBitkiler();
            tohumlubitki.tohumlacogalma();

                System.Console.WriteLine("*****************");

            kuslar marti = new kuslar();
            marti.ucmak();

           
            Console.ReadKey(); 
        }
        
    }
}   