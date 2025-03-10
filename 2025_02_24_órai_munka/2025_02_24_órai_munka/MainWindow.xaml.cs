using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace _2025_02_24_órai_munka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Feladat> feladatok;
        public MainWindow()
        {
            InitializeComponent();
            feladatok = new ObservableCollection<Feladat>();
            feladatok.Add(new Feladat("Teszt","Teszt Feladat leiras", "2024/02/24"));
            feladatok.Add(new Feladat("Teszt2","Teszt Feladat leiras", "2024/02/24"));
            feladatok.Add(new Feladat("Teszt3","Teszt Feladat leiras", "2024/02/24"));

            ltb_feladatok.ItemsSource = feladatok;
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            Feladat f = new Feladat();
            Feladatszerkesztő fsz = new Feladatszerkesztő(f);
            if (fsz.ShowDialog() == true)
            {
                feladatok.Add(f);
            };
        }

        private void btn_szerkeszt_Click(object sender, RoutedEventArgs e)
        {
            Feladat f = ltb_feladatok.SelectedItem as Feladat;
            Feladatszerkesztő fsz = new Feladatszerkesztő(f);
            fsz.ShowDialog();
            
        }

        private void btn_torol_Click(object sender, RoutedEventArgs e)
        {
            this.feladatok.Remove(ltb_feladatok.SelectedItem as Feladat);
        }

        private void btn_minden_torles_Click(object sender, RoutedEventArgs e)
        {
            this.feladatok.Clear();
            ltb_feladatok.Background = Brushes.Red;
        }

        private void btn_kesz_Click(object sender, RoutedEventArgs e)
        {
            foreach (Feladat feladat in ltb_feladatok.SelectedItems)
            {
                feladat.Kesz = true;
            }
        }
    }
}
