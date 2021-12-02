using Microsoft.Win32;
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

namespace Uygulama7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string dosyaYolu = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnDosyaAc_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text dosyaları|*.txt|İkinci dosya türü|*.tür";
            //ofd.Multiselect = true;
            var sonuc = ofd.ShowDialog();
            if (sonuc.HasValue && sonuc.Value)
            {
                dosyaYolu = ofd.FileName;
                TbText.Text = File.ReadAllText(dosyaYolu);
            }
        }

        private void BtnDosyayaYaz_Click(object sender, RoutedEventArgs e)
        {
            if (dosyaYolu == null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                var sonuc = sfd.ShowDialog();
                if (sonuc.HasValue && sonuc.Value)
                    dosyaYolu = sfd.FileName;
            }
            if (dosyaYolu != null)
                File.WriteAllText(dosyaYolu, TbText.Text);
        }
    }
}
