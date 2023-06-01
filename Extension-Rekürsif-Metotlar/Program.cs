int taban;
Console.Write("Üssü alınacak sayıyı giriniz: ");
taban = Convert.ToInt32(Console.ReadLine());

int kuvvet;
Console.WriteLine(taban + " " +"Üzeri kaç almak istersiniz: ");
kuvvet = Convert.ToInt32(Console.ReadLine());

 int result = 1;
 for (int i = 0; i < kuvvet; i++)
 {
    result = result * taban;
 }
 Console.WriteLine(result);


islemler instance =new();
Console.WriteLine(instance.expo(taban,kuvvet));


string ifade = "Furkan Uçar";
bool sonuc = ifade.CheckSpaces();

Console.WriteLine(sonuc);

if(sonuc)
    Console.WriteLine(ifade.RemoveWhiteSpaces());

Console.WriteLine(ifade.MakeLoverCase());
Console.WriteLine(ifade.MakeUpperCase());

int[] dizi = {9,8,7,6,2,1,4,5,3,0,};
dizi.SortArray();
dizi.ekranayazdır();

int sayi2 = 5;
Console.WriteLine(sayi2.IsEvenNumber());

Console.WriteLine(ifade.GetFirstCharacter());





public class islemler{
    public int expo(int sayi, int üs)
    {
        if(üs<2)
        {
            return(sayi);
        }
        return expo(sayi, üs-1)*sayi;
    }
}

public static class Extension{

        public static bool CheckSpaces(this string param)
        {
           return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLoverCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void ekranayazdır(this int[] param)
        {
            foreach (int item in param)
            Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param%2 == 0;
        }
        
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }
}


