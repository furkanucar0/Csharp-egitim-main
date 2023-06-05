namespace abtract{
    public abstract class Otomobil{

        public int Kactekerlektenolusur(){
            return 4;
        }

        public virtual Renk Standartrengine(){
            return Renk.Beyaz;
        }

        public abstract Marka Hangimarkaninaraci();
    }
}