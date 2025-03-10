using Jarmupark_kezelo;
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

namespace jarmuvekGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
  
        ObservableCollection<Jarmu> jarmuvek = new ObservableCollection<Jarmu>();
        public MainWindow()
        {
            InitializeComponent();
            tbx_jarmuvek.ItemsSource = jarmuvek;
           
            Jarmu audi = new Auto("audi", "Q3", 2019, 1032313123);
            Jarmu bmw = new Auto("BMW", "M3", 2024, 10121324);

            jarmuvek.Add(audi);
            jarmuvek.Add(bmw);
        }

        private void btn_esemenyMent_Click(object sender, RoutedEventArgs e)
        {
            (tbx_jarmuvek.SelectedItem as Jarmu).EssemenyHozzadas(tbx_Uj_esemeny.Text);
        }

        private void btn_kszorulolistazas_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Jarmu> kszorulojarmuvek = new ObservableCollection<Jarmu>();
            foreach (Jarmu j in jarmuvek)
            {
                if (j.Gyartasiev<2025-2)
                {
                    kszorulojarmuvek.Add(j);
                }
            }
            lbx_karbantartszorulo.ItemsSource = kszorulojarmuvek;
        }
    }
}
