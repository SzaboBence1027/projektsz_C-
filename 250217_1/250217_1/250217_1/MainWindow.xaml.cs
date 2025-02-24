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

namespace _250217_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Szemely> szemelyek;
        public MainWindow()
        {
            InitializeComponent();

            szemelyek = new ObservableCollection<Szemely>();
            szemelyek.Add(new Szemely("Kes Anna", "04567432456", 56));
            szemelyek.Add(new Szemely("Tes Elek", "06301879582", 20));
            szemelyek.Add(new Szemely("Vim István", "065874845", 44));

            ltx_szemelyek.ItemsSource = szemelyek;
        }

        private void btn_hozzad_Click(object sender, RoutedEventArgs e)
        {
            SzemelyKarbantarto sk = new SzemelyKarbantarto();
            if (sk.ShowDialog() == true)
            {
                this.szemelyek.Add(sk.szemely);
            }
            ;
        }

        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            if (ltx_szemelyek.SelectedItem == null) return;

            Szemely sz = ltx_szemelyek.SelectedItem as Szemely;
            SzemelyKarbantarto sk = new SzemelyKarbantarto(sz);
            if (sk.ShowDialog() == true)
            {

            }
        }

        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {
            this.szemelyek.Remove(ltx_szemelyek.SelectedItem as Szemely);
        }
    }
}
