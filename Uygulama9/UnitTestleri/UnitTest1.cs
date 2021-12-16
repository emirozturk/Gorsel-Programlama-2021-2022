using NUnit.Framework;
using System;
using System.Collections.Generic;
using Uygulama9;
namespace UnitTestleri
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SayiTesti()
        {
            var sayilar = new List<string>() { "150", "50", "", "3,6" };
            var kontrolDegerleri = new List<double>() { Math.Round(0.67,2), 50, -1, 3.6 };
            for (int i = 2; i < sayilar.Count; i++)
            {
                string sayi = sayilar[i];
                var donenDeger = Math.Round(Sinif.Hesapla(sayi), 2);
                double kontrol = kontrolDegerleri[i];
                Assert.AreEqual(kontrol, donenDeger);
            }
        }
        [Test]
        public void SinirTesti()
        {
            var sayiMetni = "100";
            var kontrolDegeri = 1.0d;
            var donenSonuc = Sinif.Hesapla(sayiMetni);
            Assert.AreEqual(kontrolDegeri, donenSonuc);
        }
    }
}