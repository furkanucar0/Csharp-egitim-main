﻿using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {      
            // ATAMA VE İŞLEMLİ ATAMA

            int x =3;
            int y =3;
            y = y+2;
            Console.WriteLine(y);
            y +=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);


            // MANTIKSAL OPERETÖRLER
            // && , || !

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfesct!");

            if(isSucces || isCompleted)
                Console.WriteLine("Great!");
            
            if (isSucces && isCompleted)
                Console.WriteLine("Fine!");

        
            // İLİŞKİSEL OPERATÖRLER
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b; 

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            // ARİTMETİK OPERATÖRLER
            //  /,*,+,- İFADELERİDİR

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sayi1);
            sonuc1 = sayi1++;

            // % mod almak için kullanılan ifade kalanı getiren ifade


            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);


            Console.ReadKey();
        }
    }
}