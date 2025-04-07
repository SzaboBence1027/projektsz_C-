using BankRendszer;
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

namespace BankRendszerGUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<ISzamlaKezelo> Szamlak ;
        ObservableCollection<Tranzakcio> tranzakciok;
        public MainWindow()
        {
            InitializeComponent();
            Szamlak = new ObservableCollection<ISzamlaKezelo>();
            tranzakciok = new ObservableCollection<Tranzakcio>();

            lbx_szamlak.ItemsSource = Szamlak;
            lbx_tranzakciok.ItemsSource = tranzakciok;
            Szamlak.Add(new Szamla("Kis Anna", 1000));
            Szamlak.Add(new Szamla("Kis Béla", 10000));
            
        }

        private void Befizetés_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbx_szamlak.SelectedItem == null) return;
           
            int osszeg = 0;
            try
            {
                if (!int.TryParse(tbx_oszeg.Text, out osszeg))
                {
                    throw new NotFiniteNumberException("Nem Számot adott meg");

                }
                 (this.lbx_szamlak.SelectedItem as Szamla).Befizet(osszeg);
                MessageBox.Show("Sikeres Befizetés");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void kivétel_Click(object sender, RoutedEventArgs e)
        {
            if (this.lbx_szamlak.SelectedItem == null) return;

            int osszeg = 0;
            try
            {
                if (!int.TryParse(tbx_oszeg.Text, out osszeg))
                {
                    throw new NotFiniteNumberException("Nem számot adott meg");

                }
                 (this.lbx_szamlak.SelectedItem as Szamla).Kivesz(osszeg);
                MessageBox.Show("Sikeres készpénz felvét");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Tranzakciok_Click(object sender, RoutedEventArgs e)
        {
           int forrasszamla;
           int celszamla;
           int osszeg ;

            if (!int.TryParse(tbx_forrás_azon.Text, out forrasszamla)) return;
            if (!int.TryParse(tbx_cél_azon.Text, out celszamla)) return;
            if (!int.TryParse(tbx_oszeg.Text, out osszeg)) return;

            this.tranzakciok.Add(new Tranzakcio(this.Szamlak[forrasszamla] as Szamla, this.Szamlak[celszamla] as Szamla, osszeg));
            try
            {
                (tranzakciok.Last() as Tranzakcio).Vegrehajt();
                MessageBox.Show("Sikeres tranzakcio");
            }
            catch (NincsElégEgyelnelExeption ex)
            {

                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
