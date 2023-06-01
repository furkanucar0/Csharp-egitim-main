//1 den başlayarak n e kadar olan sayıların aritmetik ortalamasını alan program

Console.Write("Bir Sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine());
int sayac = 1;
int toplam = 0;

while (sayac <= sayi)
{
   toplam += sayac;
   sayac ++;  
}
Console.WriteLine(toplam/sayi);