using System;

namespace hazir_metotlar_datatime_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // anlık olarak saaat ve tarihi yazar
            Console.WriteLine(DateTime.Now.Date); // bulunduğun zaman dilimini yazar
            Console.WriteLine(DateTime.Now.Day); // bulunduğun günü yazar
            Console.WriteLine(DateTime.Now.Month); // bulunduğun ayı yazar
            Console.WriteLine(DateTime.Now.Year); // bulunduğun yılı yazar
            Console.WriteLine(DateTime.Now.Hour); // bulunduğun saati yazar
            Console.WriteLine(DateTime.Now.Minute); // bulunduğun dakikayı yazar
            Console.WriteLine(DateTime.Now.Second); //bulunduğun saniyeyi yazar
            
            Console.WriteLine(DateTime.Now.DayOfWeek); // haftanın hangi gününde olduğunu yazdırır
            Console.WriteLine(DateTime.Now.DayOfYear); //yılın hangi gününde olduğunu yazdırır 
            
            Console.WriteLine(DateTime.Now.ToLongDateString()); // 2 agustos 2022 salı 
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 2.08.2022

            Console.WriteLine(DateTime.Now.ToLongTimeString()); //13:57:52
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //13:57

            Console.WriteLine(DateTime.Now.AddDays(3)); // 3 gün ekledik
            Console.WriteLine(DateTime.Now.AddHours(2)); //2 saat ekledik
            Console.WriteLine(DateTime.Now.AddYears(30)); //30 yıl ekledik
            Console.WriteLine(DateTime.Now.AddMinutes(5)); //5 dakika ekledik

            // datetime formatlar //
            Console.WriteLine(DateTime.Now.ToString("dd")); //02
            Console.WriteLine(DateTime.Now.ToString("ddd")); //sal
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Salı

            Console.WriteLine(DateTime.Now.ToString("MM")); //03
            Console.WriteLine(DateTime.Now.ToString("MMM")); // mar
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // mart

            Console.WriteLine(DateTime.Now.ToString("yy")); //Yılın son 2 hanesini getirir
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //Yılın 4 hanesini getirir
            

            Console.WriteLine("------------Math Kütüphanesi---------------");
            // math kütüphanesi

            Console.WriteLine(Math.Abs(-55)); // mutlak değer alır 
            Console.WriteLine(Math.Cos(20)); // cos alır
            Console.WriteLine(Math.Sin(10)); // sin alır
            Console.WriteLine(Math.Tan(20)); // tan alır

            Console.WriteLine(Math.Ceiling(22.3)); // en yakın üst tam sayıya tamlar
            Console.WriteLine(Math.Round(22.3)); //en yakın tam sayıya yuvarlar 22
            Console.WriteLine(Math.Round(22.7)); // en yakın tam sayıya yuvarlar 23
            Console.WriteLine(Math.Floor(22.7)); // yazılan değerden küçük en büyük tam sayıya yuvarlar.

            Console.WriteLine(Math.Min(2,8));
            Console.WriteLine(Math.Max(3,5));

            Console.WriteLine(Math.Pow(3,4)); //3^4 =81
            Console.WriteLine(Math.Sqrt(9)); //karekökünü alır
            Console.WriteLine(Math.Log(9)); // 9 un e tabanındaki logaritmik karşılığı 
            Console.WriteLine(Math.Exp(3)); //e üzeri 3 verir 
            Console.WriteLine(Math.Log10(10)); // 10 sayısının logaritma 10 tabanındaki karşışığını verir 




        }
    }
}