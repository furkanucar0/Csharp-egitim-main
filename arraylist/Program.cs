using System;
using System.Collections;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Furkan");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');

            // içerisindeki verilere erişme

            // Console.WriteLine(liste[1]);
            // foreach (var item in liste)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange Birden fazla veriyi aynı anda yazdırma işlemi yapılabilir.
            Console.WriteLine("----AddRange------");
            //string[] renkler ={"Kırmızı", "Mavi", "turuncu",};
            List<int> sayılar = new List<int>(){1,5,6,7,2,4,95,10};
            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort sıralama işlemleri için kullanılır
            Console.WriteLine("-------Sort---------");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //BinarySearch Liste içerinsde girilen değerin var olup olmadığını anlamaya yarar(öncesinde sıralamak gerekir)
            Console.WriteLine("-------BinarySearch----");
          
            Console.WriteLine(liste.BinarySearch(4));

            //Reverse listenin ortasından aynalamaya yarar ters yazdırmak için kullanılabilir
            Console.WriteLine("-------Reverse--------");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);   
            }

            //Clear Listenin içeriğini temizlemeye yarar 
            Console.WriteLine("-----Clear------");
            liste.Clear();
            foreach (var item in liste)
            {   
                    Console.WriteLine(item);   
            }
           
            Console.ReadKey();
        }
    }
}