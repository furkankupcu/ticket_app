using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Mac m1 = Mac.GetOrnek();


            int seçim;

            Console.WriteLine("Bilet Seçiniz");
            Console.WriteLine("*1-Numaralı Tribün");
            Console.WriteLine("*2 Numaralı Tribün+Yemek");
            Console.WriteLine("*3 Numaralı Tribün+Otopark");
            Console.WriteLine("*4-Numaralı Tribün+Yemek+Otopark");

            Console.WriteLine("*5-MaratonTribün");
            Console.WriteLine("*6-MaratonTribün+Yemek");
            Console.WriteLine("*7-MaratonTribün+Otopark");
            Console.WriteLine("*8-MaratonTribün+Otopark+Yemek");

            Console.WriteLine("*9-MaratonTribün");
            Console.WriteLine("*10-Kale Arkası Tribün+Yemek");
            Console.WriteLine("*11-Kale Arkası+Otopark");
            Console.WriteLine("*12-Kale Arkası Tribün+Otopark+Yemek");


            seçim = Convert.ToInt32(Console.ReadLine());
            //numaralı tribün
            if (seçim == 1)
            {
                Bilet b1 = new NumaralıTribün();
                Console.WriteLine("Numaralı Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", b1.getisim(), b1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();


            }
            else if (seçim == 2)
            {
                Bilet bilet1 = new NumaralıTribün();
                Console.WriteLine("Numaralı Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Numaralı Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }
            else if (seçim == 3)
            {
                Bilet bilet1 = new NumaralıTribün();
                Console.WriteLine("Numaralı Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Numaralı Tribün+Otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }

            else if (seçim == 4)
            {

                Bilet bilet1 = new NumaralıTribün();
                Console.WriteLine("Numaralı Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Numaralı Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Numaralı Tribün+Yemek+otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }
            //maraton
            else if (seçim == 5)
            {
                Bilet b1 = new Maraton();
                Console.WriteLine("Maraton Tribünü");
                Console.WriteLine(string.Format(" {0}---{1}", b1.getisim(), b1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();


            }
            else if (seçim == 6)
            {
                Bilet bilet1 = new Maraton();
                Console.WriteLine("Maraton Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Maraton Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }
            else if (seçim == 7)
            {
                Bilet bilet1 = new Maraton();
                Console.WriteLine("Maraton Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Maraton Tribün+Otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }
            else if (seçim == 8)
            {
                Bilet bilet1 = new Maraton();
                Console.WriteLine("Maraton Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Maraton Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Maraton Tribün+Yemek+otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır"); Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }

            //Kale Arkası
            else if (seçim == 9)
            {
                Bilet b1 = new KaleArkası();
                Console.WriteLine("Kale Arkası Tribünü");
                Console.WriteLine(string.Format(" {0}---{1}", b1.getisim(), b1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();


            }
            else if (seçim == 10)
            {
                Bilet bilet1 = new KaleArkası();
                Console.WriteLine("Kale Arkası Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Kale Arkası Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }

            else if (seçim == 11)
            {
                Bilet bilet1 = new KaleArkası();
                Console.WriteLine("Kale Arkası Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Kale Arkası Tribün+Otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }
            else if (seçim == 12)
            {
                Bilet bilet1 = new KaleArkası();
                Console.WriteLine("Kale Arkası Tribün");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new yemek(bilet1);
                Console.WriteLine("Kale Arkası Tribün+Yemek");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                bilet1 = new otopark(bilet1);
                Console.WriteLine("Kale Arkası Tribün+Yemek+otopark");
                Console.WriteLine(string.Format(" {0}---{1}", bilet1.getisim(), bilet1.getfiyat()));
                Console.WriteLine("Bilet Alınmıştır");
                Console.ReadLine();
            }

        }

    }
}

