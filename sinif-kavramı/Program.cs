
// söz dizimi

// class sinifadi
// {
//     [erişim belirleyici]    [veri tipi]  özellikadi; 
//     [erişim belirleyici]    [geridönüş tipi] metotadi [parametre listesi]
//     {
//         metot konuları 
//     }
// }

// erişim belirleyici 
// * public
// * private 
// * internal 
// * protected 

calisan calisan1 = new calisan();
calisan1.adi="Furkan ";
calisan1.soyadi="Uçar";
calisan1.no=123456;
calisan1.departman="Back-And Developer";

calisan1.calisanbilgileri();
System.Console.WriteLine("---");

calisan calisan2 = new calisan();
calisan2.adi="Seher";
calisan2.soyadi="Bozgeyik";
calisan2.no=123457;
calisan2.departman="Sosyal Medya Danismani";

calisan2.calisanbilgileri();
Console.ReadKey();
class calisan
{
    public string adi;
    public string soyadi;
    public int no;
    public string departman;

    public void calisanbilgileri()
    {
       Console.WriteLine("calisan adi:{0}", adi);
       Console.WriteLine("Calisan Soyadi:{0}", soyadi);
       Console.WriteLine("Calisanin numarasi:{0}",no);
       Console.WriteLine("Calisanin Departmani:{0}",departman);  
    }
}

