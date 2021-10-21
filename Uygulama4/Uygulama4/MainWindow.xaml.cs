using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System;
using System.IO;

namespace Uygulama4
{
    public partial class MainWindow : Window
    {
        Dictionary<string, string> ogrenciler;
        public MainWindow()
        {
            InitializeComponent();
            DosyadanOku();
            listele();
        }

        private void DosyadanOku()
        {
            ogrenciler = new Dictionary<string, string>();
            if (File.Exists("ogrenciler.txt"))
            {
                string[] satirlar = File.ReadAllLines("ogrenciler.txt");
                foreach (var satir in satirlar)
                {
                    string[] parcalar = satir.Split("-");
                    ogrenciler.Add(parcalar[0], parcalar[1]);
                }
            }
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            string numara = TbNumara.Text;//numarayı bir değişkene al
            string adSoyad = TbAdSoyad.Text;//ad soyad'ı bir değişkene al
            if (!ogrenciler.ContainsKey(numara))//Eğer girilen numara sözlükte yoksa
                ogrenciler.Add(numara, adSoyad);//bu değişkenleri sözlüğe ekle
            else
                MessageBox.Show("Zaten ekli", "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            TbNumara.Clear();
            TbAdSoyad.Clear();
            listele();//listeyi güncelle
        }

        private void listele()
        {
            LbListe.Items.Clear();
            foreach (var anahtar in ogrenciler.Keys)
            {
                string satir = $"{anahtar}-{ogrenciler[anahtar]}";
                LbListe.Items.Add(satir);
            }
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            List<string> dosyayaYazilacaklar = new List<string>();
            foreach (KeyValuePair<string, string> ikili in ogrenciler)
            {
                string yazilacak = $"{ikili.Key}-{ikili.Value}";
                dosyayaYazilacaklar.Add(yazilacak);
            }
            File.WriteAllLines("ogrenciler.txt", dosyayaYazilacaklar);
        }

        private void TbNumara_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Sözlükteki herhangi bir anahtar girilen değeri içeriyorsa
            string anahtarParcasi = TbNumara.Text;
            if (anahtarParcasi == string.Empty) //string.Empty yerine "" kullanabilirsiniz.
                listele();
            else
            {
                LbListe.Items.Clear();
                foreach (var anahtar in ogrenciler.Keys)
                {
                    //Bu değeri listeye ekle
                    if (anahtar.Contains(anahtarParcasi))
                        LbListe.Items.Add($"{anahtar}-{ogrenciler[anahtar]}");
                }
            }
        }
    }
}
