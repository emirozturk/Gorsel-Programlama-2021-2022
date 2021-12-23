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

namespace Uygulama11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> eklenecekListesi = new List<string>() { "Toplantı", "Kontrol", "Yemek", "Mesai" };
        public MainWindow()
        {
            InitializeComponent();
            Listele();
        }

        private void Listele()
        {
            foreach(var eklenecek in eklenecekListesi)
            {
                var eleman = new ListeElemani(eklenecek,false,true);
                LbEklenecek.Items.Add(eleman);
            }
        }

        private void LbEklenecek_Click(object sender, RoutedEventArgs e)
        {
            var eleman = e.Source as ListeElemani;
            eleman.TusDegistir();
            LbEklenecek.Items.Remove(eleman);
            LbEklenen.Items.Add(eleman);
        }

        private void LbEklenen_Click(object sender, RoutedEventArgs e)
        {
            var eleman = e.Source as ListeElemani;
            eleman.TusDegistir();
            LbEklenen.Items.Remove(eleman);
            LbEklenecek.Items.Add(eleman);
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
