int[] sayıDizisi = { 1, 15, 6, 27, 38, 9, };

foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);//sırasız..
}


Console.WriteLine("-------Sıralama----------");
Array.Sort(sayıDizisi);

foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);//sıralı dizi
}
Console.WriteLine("---------Yarısından itibaren ters çevirme------------");
Array.Reverse(sayıDizisi);

foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);//sıralı dizi
}


Console.WriteLine("---------Temizleme------------");
Array.Clear(sayıDizisi, 2, 2);
foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
}

Console.WriteLine("---------array indexof------------");
Console.WriteLine(Array.IndexOf(sayıDizisi, 27));

Console.WriteLine("---------dizi ekleme-----");
Array.Resize<int>(ref sayıDizisi, 6);
sayıDizisi[5] = 99;

foreach (var sayi in sayıDizisi)
{
    Console.WriteLine(sayi);
}
Console.ReadKey();
