using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama9
{
    public class Sinif
    {
        public static double Hesapla(string metin)
        {
            if (metin == "") return -1;
            double sonuc = -1;
            double deger = Convert.ToDouble(metin);
            if (deger < 100) sonuc = deger;
            else if (deger >= 100) sonuc = 100 / deger;
            return sonuc;
        }
    }
}
