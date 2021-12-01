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

namespace Tekrar
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //int degisken = Convert.ToInt32(Tb1.Text);
            //if (degisken == 10)
            //    Tb2.Text = degisken.ToString();
            //else
            //    Tb2.Text = "15";
            int x = 0;
            while (x < 10000)
                x++;
            Tb2.Text = x.ToString();
            for (int i = 0; i < 10; i++)
                x = i;
            var dizi = new int[] { 1, 2, 3, 4, 56, 6, 7, 8, 9, 9,4 };
            foreach (var degisken in dizi)
            {
                Tb2.Text += degisken.ToString() +" ";
            }
            List<int> liste = new List<int>();
            liste.Add(4);
            liste.Add(1);
            liste.AddRange(dizi);
            Tb2.Text = "";
            //for (int i = 0; i < liste.Count; i++)
            //    Tb2.Text += liste[i];
            foreach (var eleman in liste)
                Tb2.Text += eleman + " ";
        }
    }
}
