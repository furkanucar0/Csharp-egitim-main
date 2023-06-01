using System;

namespace statik_sinif_ve_uyeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.Calisansayisi);

            Calisan calisan = new Calisan ("Furkan", "Ucar", "Back-end Developer");
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.Calisansayisi);
            Calisan calisan1 = new Calisan ("Nisa", "Ucar", "ik");
            Calisan calisan2 = new Calisan ("Seher", "Bozgeyik", "Diyetisyen");
            Console.WriteLine("Calisan Sayisi:{0}", Calisan.Calisansayisi);

            System.Console.WriteLine("Toplama isleminin sonucu: {0}", Islemler.Topla(100,200));
            System.Console.WriteLine("Cikarma isleminin sonucu: {0}",Islemler.Cikar(400,200));
             




            Console.ReadKey();
        }
    }
    class Calisan 
    {
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi; set => calisansayisi = value; }

        private string isim;
        private string soyisim;
        private string departman;

        static Calisan(){
            calisansayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.departman = departman;
            calisansayisi ++;
        }

    }
    static class Islemler
    {

        public static long Topla (int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikar (int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }

    }
}