using System;

namespace inheritance
{
    public class Bitkiler:Canlilar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar");
        }
    }
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler(){
            base.FotosentezYapmak();
            base.beslenme();
            base.Boşaltim();
            base.Solunum();
        }
        public void tohumlacogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalir.");
        }
    }
    public class tohumsuzbitkiler:Bitkiler
    {
         public tohumsuzbitkiler(){
            base.FotosentezYapmak();
            base.beslenme();
            base.Boşaltim();
            base.Solunum();
        }
        public void sporlacogalma()
        {
            System.Console.WriteLine("Tohumsuz bitkiler spor ile çoğalir.");
        }
    }
}