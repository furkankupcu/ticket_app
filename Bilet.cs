using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    //decoratör
    public abstract class Bilet
    {

        protected string isim = "isimsiz";
        protected double fiyat = 0;

        public virtual string getisim()
        {
            return isim;
        }
        public virtual double getfiyat()
        {
            return fiyat;
        }

    }
    
    public class NumaralıTribün : Bilet
    {
        public NumaralıTribün()
        {
            isim = "Numaralı Tribün";
            fiyat = 180;
        }
        public override double getfiyat()
        {
            return fiyat;
        }
        public override string getisim()
        {
            return isim;
        }
    }

    public class Maraton: Bilet
    { 
        public Maraton()
        {
            isim = "Maraton Tribünü";
            fiyat = 100;
        }

        public override double getfiyat()
        {
            return fiyat;    
        }
        public override string getisim()
        {
            return isim;
        }

     }

    public class KaleArkası : Bilet
    {
        public KaleArkası()
        {
            isim = "Kale Arkası Tribünü";
            fiyat = 75;
        }

        public override double getfiyat()
        {
            return fiyat;
        }
        public override string getisim()
        {
            return isim;
        }   
    }

    public abstract class İlave : Bilet
    {
        protected double İlavefiyat = 0;
    }

    public class yemek : İlave
    {
        Bilet bilet;
        public yemek(Bilet yenibilet)
        {
            bilet = yenibilet;
            İlavefiyat = 50;
        }

        public override double getfiyat()
        {
            return this.bilet.getfiyat() + 50; ;
        }
        public override string getisim()
        {
            return this.bilet.getisim() + "+yemek";
        }
    }
    public class otopark : İlave
    {
        Bilet bilet1;
        public otopark(Bilet yenibilet1)
        {
            bilet1 = yenibilet1;
            İlavefiyat = 25; ;
        }
        public override double getfiyat()
        {
            return this.bilet1.getfiyat() + 25; ;
        }
        public override string getisim()
        {
            return this.bilet1.getisim() + "+otopark";
        }
    }
}






