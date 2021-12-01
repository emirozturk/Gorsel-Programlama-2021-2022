/*
int Topla(int a,int b)
{
    return a + b;
}
*/
//int Topla(int a, int b) => a + b;
//Func<int,int,int> Topla = (a,b) => a + b;
//Action<int, int> ToplamGoster = (a, b) => { a = 10; Console.WriteLine(a + b); };
//ToplamGoster(3, 5);
//List<int> liste = new List<int> {330,14,26,8,11,999,65536,14716,20, 3, 243, -435, -123 };
//int enKucuk=liste[0];
//for(int i = 1; i < liste.Count; i++)
//    if(liste[i] < enKucuk)
//        enKucuk=liste[i];
//Console.WriteLine(enKucuk);
//Console.WriteLine(liste.Min());
//Console.WriteLine(liste.Max());
//Console.WriteLine(liste.Average());
////Console.WriteLine(liste.Sum());
//List<int> liste = new List<int> { 330, 14, 26, 8, 11, 999, 65536, 14716, 20, 3, 243, -435, -123 };
//List<int> ondanBuyukler = new List<int>();
//for(int i = 0; i < liste.Count; i++)
//    if(liste[i] > 10)
//        ondanBuyukler.Add(liste[i]);
//foreach(var eleman in ondanBuyukler)
//    Console.WriteLine(eleman);
////Func<int,int,int> Topla = (a,b) => a + b;
//Func<int, bool> OndanBuyukMu = x => x > 10;
//Console.WriteLine(liste.Any(OndanBuyukMu));
//Console.WriteLine(liste.All(OndanBuyukMu));
//List<long> liste = new List<long> { 330, 14, 26, 8, 11, 999, 65536, 14716, 20, 3, 243, -435, -123 };
//Console.WriteLine(liste.Any(x=>x>10));
//List<long> kareler = new List<long>();
//foreach (var i in liste)
//    kareler.Add(i*i);
//var sonuc = liste.Select(x => x*x);
//foreach(var s in sonuc)
//    Console.Write(s + " ");
//List<int> liste = new List<int> { 330, 14, 26, 8, 11, 999, 65535, 14716, 20, 3, 243, -435, -123 };
//foreach(var s in liste.Where(x => x > 10 && x < 50))
//    Console.WriteLine(s);
//for (int i = 0; i < liste.Count; i++)
//    for (int j = 0; j < liste.Count; j++)
//        if(liste[i]<liste[j])
//        {
//            int temp = liste[i];
//            liste[i] = liste[j];
//            liste[j] = temp;
//        }
//List<int> dizi = liste.OrderByDescending(x => x).ToList();
//foreach (var eleman in liste.Skip(5))
//    Console.WriteLine(eleman);
List<int> liste = new List<int> { 330, 14, 26, 8, 11, 999, 4958, 14716, 20, 3, 243,67,345, 3453, 3,45,3453,346,739,2243,7700,24367,34534, -435, -123 };
//Liste içerisindeki 50den büyük sayıların 5. elemandan 10. elemana kadar olanlarını alan ve bu sayıların karelerini küçükten büyüğe sıralayıp bir string dizisi olarak döndüren metot
//for (int i = 0; i < liste.Count; i++)
//    if (liste[i] <= 50)
//    {
//        liste.RemoveAt(i);
//        i--;
//    }
//List<int> ellidenBuyukler = new List<int>();
//foreach (int eleman in liste)
//    if (eleman > 50)
//        ellidenBuyukler.Add(eleman);

//List<int> araliktakiler = new List<int>();
//for(int i=5;i<10;i++)
//    araliktakiler.Add(ellidenBuyukler[i]*ellidenBuyukler[i]);
//for(int i=0;i<araliktakiler.Count;i++)
//    for(int j=0;j<araliktakiler.Count;j++)
//        if (araliktakiler[i] < araliktakiler[j])
//        {
//            int temp = araliktakiler[i];
//            araliktakiler[i] = araliktakiler[j];
//            araliktakiler[j] = temp;
//        }
//string[] dizi = new string[5];
//for (int i = 0; i < 5; i++)
//    dizi[i] = araliktakiler[i].ToString();
//Liste içerisindeki 50den büyük sayıların 5. elemandan 10. elemana kadar olanlarını alan ve bu sayıların karelerini küçükten büyüğe sıralayıp bir string dizisi olarak döndüren metot
var dizi = liste.Where(eleman => eleman > 50)
                .Skip(5)
                .Take(5)
                .Select(x => x * x)
                .OrderBy(x => x)
                .Select(x => x.ToString());

foreach (var eleman in dizi)
    Console.WriteLine(eleman);