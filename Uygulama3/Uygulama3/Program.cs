using System;

namespace Uygulama3
{
    class Sinif
    {
        public void Yazdir(int deger)
        {
            Console.WriteLine(deger);
        }
        public void Yazdir(string metin)
        {
            Console.WriteLine(metin);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int degisken = 235;
            string degisken2 = "Yazdirilacak bir string";
            float degisken3 = 3.235f;
            var x = new Sinif();
            x.Yazdir(degisken);
            x.Yazdir(degisken2);
            x.Yazdir(degisken3);
        }
    }
}
