Console.Write("Bir Sayı giriniz :");
int sayac = int.Parse(Console.ReadLine());

for (int i = 0; i <= sayac; i++)
{
  if(i%2 == 1)   
  Console.WriteLine(i);
}


Console.Write("Bir Sayı giriniz :");
int sayac2 = int.Parse(Console.ReadLine());
int tek = 0;
int çift = 0;

for (int i = 0; i <= sayac2; i++)
{
  if (i%2 == 1)
  tek += i;
  else
  çift += i;
  
}
Console.WriteLine ("Tek Sayıların Toplamı: " + tek);
Console.WriteLine ("Çift Sayıların Toplamı: " + çift);


