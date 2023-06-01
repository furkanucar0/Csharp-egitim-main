
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

    // calisan calisan1 = new calisan();
    // calisan1.ad = "Furkan";
    // calisan1.soyad = "Uçar";
    // calisan1.no = 123456;
    // calisan1.departman = "Back-end Developer";
    // calisan1.calisanbilgileri();

    calisan calisan2 = new calisan("Furkan", "Uçar", 123456, "Back-end Developer");
    calisan2.calisanbilgileri();
    
    Console.WriteLine("******************");

    calisan calisan1= new calisan("Samet", "Cetin", 123457, "Front-end Devoloper");
    calisan1.calisanbilgileri();

Console.ReadKey();
class calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public calisan (string ad, string soyad, int no, string departman)
    {
        this.ad = ad;
        this.soyad = soyad;
        this.no = no;
        this.departman = departman;
    }


    public void calisanbilgileri()
    {
        System.Console.WriteLine("Çalişanin adi: {0}", ad);
        System.Console.WriteLine("Çalişanin soyadi: {0}", soyad);
        System.Console.WriteLine("Çalişanin Numarasi: {0}", no);
        System.Console.WriteLine("Çalişanin Departmani: {0}", departman);

    }
    
}