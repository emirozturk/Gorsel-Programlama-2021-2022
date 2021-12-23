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

namespace Uygulama10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int sayac = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            Button tus = new Button()
            {
                Width = 50,
                Height = 50,
                Content = sayac.ToString(),
                FontSize = 24,
                Name = $"Btn{sayac}"
            };
            tus.Click += Tus_Click;
            WpTuslar.Children.Add(tus);
            sayac++;
        }

        private void Tus_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button)
            {
                var tus = sender as Button;
                tus.Foreground = Brushes.White;
                tus.Background = tus.Background == Brushes.Green ? Brushes.Red : Brushes.Green;
            }
        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
            UIElement bulunan = null;
            foreach (var element in WpTuslar.Children)
            {
                if (element is Button && (element as Button).Name == TbAranan.Text)
                    bulunan = element as UIElement;
            }
            WpTuslar.Children.Remove(bulunan);
        }

        private void BtnAra_Click(object sender, RoutedEventArgs e)
        {
            foreach (var element in WpTuslar.Children)
            {
                //LbBilesenler.Items.Add(element.ToString());
                var aranan = TbAranan.Text;
                if (element is Button)
                {
                    var tus = element as Button;
                    if (tus.Name == aranan)
                    {
                        tus.Background = Brushes.Green;
                    }
                }
            }
        }
    }
}
