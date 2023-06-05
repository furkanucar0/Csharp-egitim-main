namespace abtract;
class Program
{
    static void Main(string[] args)
    {
            Newfocus focus = new Newfocus();
            Console.WriteLine(focus.Hangimarkaninaraci().ToString());
            Console.WriteLine(focus.Kactekerlektenolusur());
            Console.WriteLine(focus.Standartrengine().ToString());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Newcivic civic = new Newcivic();
            Console.WriteLine(civic.Hangimarkaninaraci().ToString());
            Console.WriteLine(civic.Kactekerlektenolusur());
            Console.WriteLine(civic.Standartrengine().ToString());

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*");

            Newcorolla corolla = new Newcorolla();
            Console.WriteLine(corolla.Hangimarkaninaraci().ToString());
            Console.WriteLine(corolla.Kactekerlektenolusur());
            Console.WriteLine(corolla.Standartrengine().ToString());

            Console.ReadKey();
    }
}
