using System;

namespace Uygulama3
{
    class LogSinifi
    {
        private string log;
        public LogSinifi(string log)
        {
            this.log = log;
        }
        public override string ToString()
        {
            return log;
        }
    }
    class Sinif<T>
    {
        private T deger;
        public Sinif(T deger)
        {
            this.deger = deger;
        }
        public void Yazdir()
        {

            Console.WriteLine(deger);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var intSinifim = new Sinif<int>(2394);
            intSinifim.Yazdir();
            var stringSinifim = new Sinif<string>("Yazdirilacak bir string");
            stringSinifim.Yazdir();
            var floatSinifim = new Sinif<float>(10.0f);
            floatSinifim.Yazdir();
            var logSinifim = new Sinif<LogSinifi>(new LogSinifi("Düşen kayıt."));
            logSinifim.Yazdir();
        }
    }
}
