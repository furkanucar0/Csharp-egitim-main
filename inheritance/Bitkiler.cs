using System;

namespace inheritance
{
    public class Bitkiler:Canlilar
    {
        public void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public void tohumlacogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalir.");
        }
    }
    public class tohumsuzbitkiler:Bitkiler
    {
        public void sporlacogalma()
        {
            System.Console.WriteLine("Tohumsuz bitkiler spor ile çoğalir.");
        }
    }
}