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

namespace Dolgozat_SzabóBence_2025_02_10
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

        private void btn_hozzaad_Click(object sender, RoutedEventArgs e)
        {
            TermekSzerkeszto tsz = new TermekSzerkeszto();
            if (tsz.ShowDialog()==true)
            {
                Termek t = new Termek(tsz.tbx_Nev.Text,Convert.ToInt32( tsz.tbx_Ar.Text));
                lb_Termekek.Items.Add(t);
            }
        }

        private void btn_szerkesztes_Click(object sender, RoutedEventArgs e)
        {
            if (lb_Termekek.SelectedItem!=null)
            {
                Termek t = lb_Termekek.SelectedItem as Termek;

                TermekSzerkeszto tsz = new TermekSzerkeszto();
                tsz.tbx_Nev.Text = t.Nev;
                tsz.tbx_Ar.Text =Convert.ToString( t.Ar);
                tsz.cbx_Eladva.IsChecked = t.Eladott;
                if (tsz.ShowDialog() == true)
                {
                    if (tsz.cbx_Eladva.IsChecked==true)
                    {
                        lb_Termekek.Items.Remove(lb_Termekek.SelectedItem);
                        lb_Termekek.Items.Add(new Termek(tsz.tbx_Nev.Text, Convert.ToInt32(tsz.tbx_Ar.Text),true));
                    }
                    else
                    {
                        lb_Termekek.Items.Remove(lb_Termekek.SelectedItem);
                        lb_Termekek.Items.Add(new Termek(tsz.tbx_Nev.Text, Convert.ToInt32(tsz.tbx_Ar.Text)));
                    }
                    
                    
                }
            }
        }

        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {
            if (lb_Termekek.SelectedItem!=null)
            {
                lb_Termekek.Items.Remove(lb_Termekek.SelectedItem);
            }
        }

        private void btn_minden_torles_Click(object sender, RoutedEventArgs e)
        {
            lb_Termekek.Items.Clear();
            lb_Termekek.Background = new SolidColorBrush(Color.FromRgb((byte)255, (byte)0, (byte)0));
        }

        private void btn_eladva_Click(object sender, RoutedEventArgs e)
        {
            if (lb_Termekek.SelectedItems!=null)
            {
               
                for (int i = 0; i < lb_Termekek.SelectedItems.Count; i++)
                {
                    
                    Termek t = lb_Termekek.SelectedItem as Termek;
                    string nev = t.Nev;
                    int ar = t.Ar;
                   
                    lb_Termekek.Items.Add(new Termek(nev,ar,true));
                   
                   
                }
                

            }
        }
    }
}
