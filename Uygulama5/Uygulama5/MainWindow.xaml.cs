using System;
using System.Collections.Generic;
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

namespace Uygulama5
{
    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Kisi(string Ad,string Soyad)
        {
            this.Ad = Ad;
            this.Soyad = Soyad;
        }

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //if (Takvim.SelectedDate.HasValue)
            //{
            //    DateTime SecilenTarihSaat = Takvim.SelectedDate.Value;
            //    Tb2.Text = SecilenTarihSaat.ToString();
            //}
            //else
            //    Tb2.Text = "Tarih Seçilmedi";
            //DateTime tarihSaat = Takvim.DisplayDate;
            //Tb1.Text = tarihSaat.ToString();
            //Tb1.Text = DpTarih.Text;
            List<Kisi> kisiListesi = new List<Kisi>();
            kisiListesi.Add(new Kisi("Emir", "Öztürk"));
            kisiListesi.Add(new Kisi("Ömer", "Yıldız"));
            GridBilgi.ItemsSource = kisiListesi;
        }
    }
}
