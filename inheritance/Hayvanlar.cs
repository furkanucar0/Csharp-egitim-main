using System;

namespace inheritance
{
    public class Hayvanlar:Canlilar
    {
        public void Adaptasyon()
        {
            Console.WriteLine("Canlılar adaptasyon kurabilir");
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
        public void ucmak()
        {
            System.Console.WriteLine("Kuşlar Uçar");
        }
    }
}