using System;

namespace Uygulama3
{
    class Sinif
    {
        public void Yazdir(int deger)
        {
            Console.WriteLine(deger);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int degisken = 235;
            var x = new Sinif();
            x.Yazdir(degisken);
        }
    }
}
