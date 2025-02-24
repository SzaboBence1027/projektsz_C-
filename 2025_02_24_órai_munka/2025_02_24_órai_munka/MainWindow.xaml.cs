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
            feladatok.Add(new Feladat("Teszt","Teszt Feladat leiras", new DateTime(2025, 2, 24, 16, 0, 0)));

            ltb_feladatok.ItemsSource = feladatok;
        }

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            Feladatszerkesztő fsz = new Feladatszerkesztő();
            if (fsz.ShowDialog() == true)
            {
                feladatok.Add(fsz.feladat);
            };
        }
    }
}
