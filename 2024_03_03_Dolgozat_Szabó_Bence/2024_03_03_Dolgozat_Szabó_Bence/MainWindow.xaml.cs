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

namespace _2024_03_03_Dolgozat_Szabó_Bence
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        ObservableCollection<Konyv> konyvek;
        public MainWindow()
        {
            InitializeComponent();
            konyvek = new ObservableCollection<Konyv>();
            konyvek.Add(new Konyv("Odusszeia", "Homérosz", "Eposz"));//Teszt

            ltb_konyvek.ItemsSource = konyvek;
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            Konyv k = new Konyv();
            KonyvSzerkesztő ksz = new KonyvSzerkesztő(k);
            if (ksz.ShowDialog()==true)
            {
                konyvek.Add(k);
            };
        }

        private void btn_torol_Click(object sender, RoutedEventArgs e)
        {
            this.konyvek.Remove(ltb_konyvek.SelectedItem as Konyv);
        }

        private void btn_szerkeszt_Click(object sender, RoutedEventArgs e)
        {
            Konyv k = ltb_konyvek.SelectedItem as Konyv;
            KonyvSzerkesztő ksz = new KonyvSzerkesztő(k);
            ksz.ShowDialog();
        }

        private void btn_kesz_Click(object sender, RoutedEventArgs e)
        {
            foreach(Konyv konyv in ltb_konyvek.SelectedItems)
            {
                konyv.Olvasott = true;
            }
        }
    }
}
