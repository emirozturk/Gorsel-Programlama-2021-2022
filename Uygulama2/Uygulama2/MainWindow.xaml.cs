using System;
using System.Windows;

namespace Uygulama2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            BtnSifreleAc.IsEnabled = RbSifrele.IsChecked.Value || RbAc.IsChecked.Value;
        }

        private void BtnSifreleAc_Click(object sender, RoutedEventArgs e)
        {
            if (RbSifrele.IsChecked.Value)
                TbOutput.Text = Sifreleyici.Sifrele(TbInput.Text);
            else if (RbAc.IsChecked.Value)
                TbOutput.Text = Sifreleyici.Ac(TbInput.Text);
            TbInput.Clear();
            RbSifrele.IsChecked = false;
            RbAc.IsChecked = false;
        }
    }
}
