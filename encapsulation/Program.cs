using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ogrenci ogrenci1 = new ogrenci("Furkan","Uçar",12,12);
            ogrenci1.sinifatlat();
            ogrenci1.ogrencibilgisigetir();

            ogrenci ogrenci2 = new ogrenci("Nisa", "Uçar", 13, 1);
            ogrenci2.sinifdusur();
            ogrenci2.sinifdusur();
            ogrenci2.ogrencibilgisigetir();
            Console.ReadKey();
        }
    }

    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public ogrenci(string isim, string soyIsim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            SoyIsim = soyIsim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        {
             get => sinif; 
             set{
                if (value < 1)
                {
                    System.Console.WriteLine("Sinif en az 1 olabilir");
                    sinif = 1;
                }
                else
                {
                   sinif = value;   
                }
             } 
              
             
        }

        public void ogrencibilgisigetir()
        {
            System.Console.WriteLine("*********Öğrenci bilgileri*********");
            System.Console.WriteLine("Öğrenci Adi       :{0}", this.Isim);
            System.Console.WriteLine("Öğrenci Soyadi    :{0}", this.SoyIsim);
            System.Console.WriteLine("Öğrenci Numarasi  :{0}", this.OgrenciNo);
            System.Console.WriteLine("Öğrencinin sinifi :{0}", this.Sinif);
        }
        public void sinifatlat()
        {
            this.Sinif = this.Sinif +1;
        }

        public void sinifdusur()
        {
            this.Sinif = this.Sinif = -1;
        }
    }   
    
}