using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama2
{
    class Sifreleyici
    {
        public static string Sifrele(string metin)
        {
            //return new string(metin.Select(x => Convert.ToChar(x + 3)).ToArray());
            string output = "";
            //Stringin sırasıyla her elemanını elde edebilmem lazım
            //Daha sonra bir döngü kurarak her elemanı gezmem lazım
            foreach (var karakter in metin)
            {
                //Her karakter için 3 harf ileriye götürüp yeni karakteri outputa eklemem gerek
                output += Convert.ToChar((karakter + 3) % 256);
            }
            return output;

        }
        public static string Ac(string metin)
        {
            //return new string(metin.Select(x => Convert.ToChar(x - 3)).ToArray());
            string output = "";
            //Stringin sırasıyla her elemanını elde edebilmem lazım
            //Daha sonra bir döngü kurarak her elemanı gezmem lazım
            foreach (var karakter in metin)
            {
                //Her karakter için 3 harf geriye götürüp yeni karakteri outputa eklemem gerek
                output += Convert.ToChar(karakter - 3);
            }
            return output;
        }
    }
}
