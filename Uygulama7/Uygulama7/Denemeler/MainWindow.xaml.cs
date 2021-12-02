using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Denemeler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOku_Click(object sender, RoutedEventArgs e)
        {
            //using(FileStream akis = new FileStream(TbDosyaYolu.Text, FileMode.Open))
            //{
            //    //TbOkunan.Text = akis.Length.ToString();
            //    StreamReader sr = new StreamReader(akis);
            //    TbOkunan.Text = sr.ReadToEnd();
            //    //byte[] okunan = new byte[50];
            //    //akis.Read(okunan, 0, 50);
            //    //var cikti = new String(okunan.Select(x=>(char)x).ToArray());
            //    //foreach (var b in okunan)
            //    //    cikti += (char)b;
            //    //TbOkunan.Text = Encoding.GetEncoding("Windows1254").GetString(okunan);
            //}
            //var klasor = System.IO.Path.GetDirectoryName(TbDosyaYolu.Text);
            //FileStream akis = new FileStream(TbDosyaYolu.Text, FileMode.Open);
            //using (StreamWriter sw = new StreamWriter(akis))
            //{
            //    sw.Write(TbOkunan.Text);
            //}
            //using (BinaryWriter bw = new BinaryWriter(akis))
            //{
            //    var deger = Convert.ToByte(TbOkunan.Text);
            //    bw.Write(deger);
            //}
            //using(BinaryReader br = new BinaryReader(akis))
            //{
            //    var donen = br.ReadBytes(10);
            //    TbOkunan.Text = new String(donen.Select(x => (char)x).ToArray());
            //}
            //if (File.Exists(TbDosyaYolu.Text))
            //    File.Delete(TbDosyaYolu.Text);
            //string[] sonuc = File.ReadAllLines(TbDosyaYolu.Text);
            //int i = 0;
            //foreach (var satir in sonuc)
            //    TbOkunan.Text += (++i).ToString() + "." + satir+Environment.NewLine;
            //string degisken = "BirinciSatir\nİkinciSatir";
            //File.WriteAllText(TbDosyaYolu.Text, degisken);
            //var klasor = System.IO.Path.GetDirectoryName(TbDosyaYolu.Text);
            //var sonuc = Directory.GetFiles(klasor + "/new folder");
            //foreach (var satir in sonuc)
            //{
            //    var dosyaAdi = System.IO.Path.GetFileNameWit(satir);
            //    //var parcalar = dosyaAdi.Split(".");
            //    //var cikti = "";
            //    //for(int i=0;i<parcalar.Length-1;i++)
            //    //    cikti += parcalar[i];
            //    TbOkunan.Text += dosyaAdi + "\n";
            //}
            //var dosyaYolu = @"C:\users\emiro\desktop";
            //var dosyaAdi = "deneme.txt";
            //var yol = Path.Combine(dosyaYolu, dosyaAdi);
            //string cikti = $"sonuc={a} ikinciSonuc={b}";
        }
    }
}
