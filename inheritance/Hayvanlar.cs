using System;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Canlilar adaptasyon kurabilir");
        }
    }
    public class sürüngenler:Hayvanlar
    {
        public void surunerekhareketederler()
        {
            System.Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }
    public class kuslar:Hayvanlar
    {
        public kuslar(){
            base.Adaptasyon();
            base.beslenme();
            base.Boşaltim();
            base.Solunum();
        }
        public void ucmak()
        {
            System.Console.WriteLine("Kuşlar Uçar");
        }
    }
}