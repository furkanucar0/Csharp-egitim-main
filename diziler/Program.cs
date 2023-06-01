string[] renkler = new string[5];

string[] hayvanlar = {"Kedi","Köpek","Kuş","Maymun"};

int[] dizi;

dizi = new int[5];

//Dizilerde atama ve erişim

renkler[0] = "Mavi";
dizi[3] = 10;

Console.WriteLine(dizi[3]);

Console.WriteLine(renkler[0]);

Console.WriteLine(hayvanlar[2]);



//Döngüler ile dizi kullanımı


//Klavyeden girilen n tane sayının ortalamasını hesaplayan program 

Console.WriteLine("Lütfen Eleman Sayısını Giriniz: ");
int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
int[] sayıDizisi = new int[diziUzunlugu];

for (int i = 0; i < diziUzunlugu; i++)
{
    Console.Write("Dizinin {0}. elamanını giriniz: ", i+1);
    sayıDizisi[i] = Convert.ToInt32(Console.ReadLine());
}
var toplam = 0m;
foreach (var sayi in sayıDizisi)
{
    toplam+=sayi;

}
Console.WriteLine("Girmiş olduğunuz sayıların ortalaması: "+  (toplam/diziUzunlugu) );
Console.ReadKey();


