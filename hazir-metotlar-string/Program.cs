using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2= "Dersimiz CSharp";
            string degisken3= "dersimiz CSharp";

            //Lenght..  Cümlenin içindeki harfleri sayar          
            Console.WriteLine(degisken.Length);
            
            //ToUpper, ToLower..  Cümlenin Tamamını küçük veya büyük yazar
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            //Concat..  Birleştirmeye yarar
            Console.WriteLine(string.Concat(degisken, " Merhaba"));

            //compare..
            //1. Değişken 2. değişkene eşit ise 0 
            //1. Değişken 2. değişkenden Büyük ise 1 
            //1. Değişken 2. değişkenden Küçük ise -1
            Console.WriteLine(degisken.CompareTo(degisken2));
            //CompareTo..
            //Tanım ve Kullanım. CompareTo() yöntemi , iki dizeyi sözlükbilimsel olarak karşılaştırır . Karşılaştırma, dizelerdeki her karakterin Unicode değerine dayanır. Dize diğer dizeye eşitse yöntem 0 döndürür.
            Console.WriteLine(string.Compare(degisken2, degisken3, true));
            Console.WriteLine(string.Compare(degisken2, degisken3, false));
            
            //contains 1. değişkenin içinde 2. değişken var mı yok mu kontrol ediyor
            Console.WriteLine(degisken.Contains(degisken2));
            //Değişkenin başlangıç ve bitişi içinde var mı yok mu kontrol ediyor. 
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));
            
            //indexOf Cümlenin veya kelimenin hangi index de olduğunu bulup getiriyor.
            //Hiç bir şey bulamazsa da -1 dönüyor.
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.LastIndexOf("i"));
            //insert
            Console.WriteLine(degisken.Insert(0, "Merhaba "));
            
            //PadLeft, PadRight..
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'.'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'_') + degisken2);

            //Remove silme işlemi yapar
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));
            
            //split
            Console.WriteLine(degisken.Split(' ')[2]);

            //SubString
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));
            
        }
    }
}