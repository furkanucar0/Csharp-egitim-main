using System;
using System.Collections.Generic;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();

            kullanıcılar.Add(10, "Furkan Uçar");
            kullanıcılar.Add(15, "Nisa Uçar");
            kullanıcılar.Add(12, "Seher Bozgeyik");
            kullanıcılar.Add(13, "Defne Uçar");

            // Dizinin elemanlarına erişim 
            Console.WriteLine("-----Elemanlara erişim ------");
            Console.WriteLine(kullanıcılar[10]);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }

            // Count; 
            Console.WriteLine("-----------Count------");
             
            Console.WriteLine(kullanıcılar.Count);

            //Contains içeriği kontrol etmek için kullanılıar 
            Console.WriteLine("------Contains-----");
            Console.WriteLine(kullanıcılar.ContainsKey(20));
            Console.WriteLine(kullanıcılar.ContainsValue("Furkan Uçar"));

            // Remove silme işlemi için kullanılır 
            Console.WriteLine("--------Remove----");
            kullanıcılar.Remove(13);
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
                Console.WriteLine(item.Key);
            }

            //Keys Sadece Keys'ler üzerinde işlem yapılır
            Console.WriteLine("---------Keys----------");
            foreach (var item in kullanıcılar.Keys)
            {
                Console.WriteLine(item);
            }

            //Values Sadece Values'ler üzerinde işlem yaptırılır
            Console.WriteLine("---------Values--------");
            foreach (var item in kullanıcılar.Values)
            {
                Console.WriteLine(item);
                
            }


            Console.ReadKey();
        }
    }
}