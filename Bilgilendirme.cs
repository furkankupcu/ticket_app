using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    //observer
    class Bilgilendirme
    {
        abstract public class Observer
        {
            public abstract void Update();
        }

        abstract public class TaraftarObserver : Observer
        {

        }

        public class BiletSayısı
        {
            public double BiletSayı = 0;

            bool BiletBittiMi;

            public bool biletBittiMi
            {
                get { return BiletBittiMi; }
                set
                {
                    if (value == true)
                    {
                        Notify();
                        BiletBittiMi = value;
                    }
                    else
                        BiletBittiMi = value;
                }

            }

            private void Notify()
            {
                throw new NotImplementedException();
            }

            List<Observer> Gozlemciler;

            public void Taraftar()
            {
                this.Gozlemciler = new List<Observer>();

            }

            public void AboneEkle(Observer observer)
            {
                Gozlemciler.Add(observer);
            }

            public void AboneCikar(Observer observer)
            {
                Gozlemciler.Remove(observer);


                 void Notify()
                {
                    Gozlemciler.ForEach(g =>
                    {
                        g.Update();



                    });
                    
                   

                }
            }
        }

        public class BiletDeğiştir
        {
        
            public void BiletOLuştur()
            {
                Console.WriteLine("Oluşturacağınız Bilet Sayısını Giriniz");

                double BiletSayısı = double.Parse(Console.ReadLine());
   
            }
            public void BiletBitti()
            {
                double BiletSayısı = 0;   
            }

        }

    }
}
