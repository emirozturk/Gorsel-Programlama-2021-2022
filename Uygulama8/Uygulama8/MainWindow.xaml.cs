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
using Uygulama8.Controllers;
using Uygulama8.Models;

namespace Uygulama8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomerController customerController;
        public MainWindow()
        {
            InitializeComponent();
            customerController = new CustomerController();
            Listele();
        }

        private void Listele()
        {
            List<Customer> kullaniciListesi = customerController.KullanicilariAl();
            LbKisiler.ItemsSource = kullaniciListesi;
        }

        private void BtnEkle_Click(object sender, RoutedEventArgs e)
        {
            if (TbAdSoyad.Text != "")
            {
                if (customerController.Bul(TbAdSoyad.Text) == null)
                {
                    Customer yeniKullanici = new Customer();
                    yeniKullanici.Name = TbAdSoyad.Text;
                    customerController.Ekle(yeniKullanici);
                    TbAdSoyad.Text = "";
                    Listele();
                }
                else
                    MessageBox.Show("Eklediğin kayıt zaten mevcut.");
            }
        }

        private void BtnGuncelle_Click(object sender, RoutedEventArgs e)
        {
            if (LbKisiler.SelectedIndex != -1 && TbAdSoyad.Text != "")
            {
                Customer bulunan = customerController.Bul(LbKisiler.SelectedItem.ToString());
                bulunan.Name = TbAdSoyad.Text;
                customerController.Guncelle(bulunan);
                Listele();
            }
        }

        private void BtnSil_Click(object sender, RoutedEventArgs e)
        {
            if (LbKisiler.SelectedIndex != -1)
            {
                Customer bulunan = customerController.Bul(LbKisiler.SelectedItem.ToString());
                customerController.Sil(bulunan);
                Listele();
            }
        }
    }
}
