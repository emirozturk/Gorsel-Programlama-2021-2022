using System;
using System.Collections;
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

namespace Uygulama9
{
    public class PerformansSinif
    {
        public int sayi { get; set; }
        public int Hesapla()
        {
            return (int)Math.Pow(sayi,2);
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnHesapla_Click(object sender, RoutedEventArgs e)
        {
            var sayiText = TbSayi.Text;
            var dondurulenDeger = Sinif.Hesapla(sayiText);
            MessageBox.Show(dondurulenDeger.ToString());
        }

        private void BtnPerformans_Click(object sender, RoutedEventArgs e)
        {
            var liste = new List<int>();
            var sonuc = new List<int>();
            for (int i = 0; i < 10000000; i++)
                liste.Add(i);
            int count = liste.Count;
            var s = new PerformansSinif();
            for (int i = 0; i < count; i++)
            {
                s.sayi = i;
                sonuc.Add(s.Hesapla());
            }
        }
    }
}