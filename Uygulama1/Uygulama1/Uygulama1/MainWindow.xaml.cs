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

namespace Uygulama1
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

        private void BtnKaydet_Click(object sender, RoutedEventArgs e)
        {
            string adSoyad;
            string numara;
            adSoyad = TbAdSoyad.Text;
            numara = TbNumara.Text;
            bool instagramSeciliMi = CbInstagram.IsChecked.Value;
            bool tinderSeciliMi = CbTinder.IsChecked.Value;
            bool redditSeciliMi = CbReddit.IsChecked.Value;
            bool facebookSeciliMi = CbFacebook.IsChecked.Value;
            bool tiktokSeciliMi = CbTikTok.IsChecked.Value;
            bool linkedInSeciliMi = CbLinkedIn.IsChecked.Value;
            string sonuc = "";
            sonuc += numara + "-";
            sonuc += adSoyad + "-";
            if (instagramSeciliMi) sonuc += "Instagram-";
            if (tinderSeciliMi) sonuc += "Tinder-";
            if (redditSeciliMi) sonuc += "Reddit-";
            if (facebookSeciliMi) sonuc += "Facebook-";
            if (tiktokSeciliMi) sonuc += "Tiktok-";
            if (linkedInSeciliMi) sonuc += "Linkedin-";
            sonuc = sonuc.Substring(0, sonuc.Length - 1);
            LbKayitlar.Items.Add(sonuc);
            TbAdSoyad.Clear();
            TbNumara.Clear();
            CbInstagram.IsChecked = false;

        }
        private void Rb_Checked(object sender, RoutedEventArgs e)
        {
            //Eğer rb evet checked ise
            //BtnKaydet enabled yap
            //değilse
            //btnkaydet disabled yap
            if (RbEvet.IsChecked.HasValue)
                BtnKaydet.IsEnabled = RbEvet.IsChecked.Value;
        }
    }
}
