using System;

namespace generic_list{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class.
            //System.Collection.generic;
            // T -> object türündedir. 

            List<int> sayilistesi = new List<int>();

            sayilistesi.Add(10);
            sayilistesi.Add(23);
            sayilistesi.Add(5);
            sayilistesi.Add(92);
            sayilistesi.Add(4);

            List<string> renklistesi = new List<string>();

            renklistesi.Add("Mavi");
            renklistesi.Add("Turuncu");
            renklistesi.Add("Kırmızı");
            renklistesi.Add("Pembe");
            renklistesi.Add("Sarı");

            //Count
            Console.WriteLine(renklistesi.Count);
            Console.WriteLine(sayilistesi.Count);

            Console.WriteLine("********");

            foreach (var item in sayilistesi)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("**********");
            
            foreach (var item in renklistesi)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("********");
            
            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));

            Console.WriteLine("*******");

            renklistesi.ForEach(renk=> Console.WriteLine(renk));
            
            Console.WriteLine("****Listeden eleman çıkarma*****");

            sayilistesi.Remove(4);
            renklistesi.Remove("Turuncu");

            sayilistesi.RemoveAt(0);
            renklistesi.RemoveAt(2);
            
            renklistesi.ForEach(renk=> Console.WriteLine(renk));
            sayilistesi.ForEach(sayi=> Console.WriteLine(sayi));

            Console.WriteLine("*******Liste İçerisinde arama yapma*****");

            if (sayilistesi.Contains(23))
            {
                Console.WriteLine("23 liste içerisinde bulundu");
            }

            //eleman ile index'e erişme

            Console.WriteLine(renklistesi.BinarySearch("Sarı"));

            //diziyi listeye çevirme 

            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanlistesi = new List<string>(hayvanlar);
            hayvanlistesi.ForEach(hayvan=> Console.WriteLine(hayvan));

            //listenin tamamını temizlemek 
            hayvanlistesi.Clear();

            //liste içerisinde nesne tutmak
            List<kullanıcılar> kullanıcılistesi = new List<kullanıcılar>();
            kullanıcılar kullanıcı1 = new kullanıcılar();
            kullanıcı1.Isim="Furkan";
            kullanıcı1.Soyisim="Uçar";
            kullanıcı1.Yas=24;

            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı2.Isim = "Seher";
            kullanıcı2.Soyisim = "Bozgeyik";
            kullanıcı2.Yas = 21;

            
            kullanıcılistesi.Add(kullanıcı1);
            kullanıcılistesi.Add(kullanıcı2);

            List<kullanıcılar> yeniliste = new  List<kullanıcılar>();

            yeniliste.Add(new kullanıcılar(){
                Isim = "Nisa",
                Soyisim = "Uçar",
                Yas = 18
            });

            foreach (kullanıcılar kullanıcı in kullanıcılistesi)
            {
                Console.WriteLine("Kullanıcının Adı: "+ kullanıcı1.Isim);
                //Console.WriteLine("Kullanıcnın Soyadı: ", kullanıcı.Soyisim);
                //Console.WriteLine("Kullanıcın Yaşı: ", kullanıcı.Yas);
                Console.WriteLine($"Kullanıcı Adı :{kullanıcı.Isim}");
                Console.WriteLine($"Kullanıcı Soyadı :{kullanıcı.Soyisim}");
                Console.WriteLine($"Kullanıcı Yaşı:{kullanıcı.Yas}");


            }
            Console.ReadKey();

        }
        public class kullanıcılar{
            private string isim;
            private string soyisim;
            private int yas;

            public string Isim { get => isim; set => isim = value; }
            public string Soyisim { get => soyisim; set => soyisim = value; }
            public int Yas { get => yas; set => yas = value; }
        }
        
    }
            
}