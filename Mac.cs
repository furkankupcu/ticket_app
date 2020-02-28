using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_1
{
    //singleton
       public class Mac
    { 
        private Boolean yok;
        private Boolean MacOynanıyor;
        private static Mac ornek = new Mac();

        private Boolean YokMu()
        {
            return yok;
        }
        private Boolean MacOynanıyorMu()
        {
            return MacOynanıyor;
        }

        public void Başlat()
        {
            if (YokMu())
            {
                Console.WriteLine("Maç Var");
                yok = false;
            }
        }
        public void bosalt()
        { 
            yok = true;
            MacOynanıyor = false;
        }

        private Mac()
       {
    
       }

        public static Mac GetOrnek()
        {
            return ornek;     
        }
     }
}
