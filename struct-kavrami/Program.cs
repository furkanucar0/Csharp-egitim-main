using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.kisakenar = 3;
            dikdortgen.uzunkenar = 4;

            Console.WriteLine("Class alan hesapla  :{0}" , dikdortgen.alanhesapla());

            Dikdortgen_struct dikdortgen_Struct;
            dikdortgen_Struct.kisakenar = 3;
            dikdortgen_Struct.uzunkenar = 4;  
            Console.WriteLine("Class alan hesapla  :{0}", dikdortgen_Struct.alanhesapla());   
            
            
            
            Console.ReadKey();
        }
    }

    class Dikdortgen
    {
        public int kisakenar;
        public int uzunkenar;

        public long alanhesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }

    struct Dikdortgen_struct
    {
        public int kisakenar;
        public int uzunkenar;

        public Dikdortgen_struct(int kisakenar, int uzunkenar)
        {
            this.kisakenar = kisakenar;
            this.uzunkenar = uzunkenar;
        }

        public long alanhesapla()
        {
            return this.kisakenar * this.uzunkenar;
        }
    }
}