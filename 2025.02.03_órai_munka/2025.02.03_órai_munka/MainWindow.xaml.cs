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

namespace _2025._02._03_órai_munka
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
            Karbantarto k = new Karbantarto();
            if (k.ShowDialog()==true)
            {
                Halgato h = new Halgato(k.tbx_nev.Text,(int) k.sdr_jegy.Value);
                ltb_halgatok.Items.Add(h);
            }
           
            
        }

        private void btn_mod_Click(object sender, RoutedEventArgs e)
        {
            if (ltb_halgatok.SelectedItem != null)
            {
                Halgato h = ltb_halgatok.SelectedItem as Halgato;

            Karbantarto k = new Karbantarto();
            k.tbx_nev.Text = h.Nev;
            k.sdr_jegy.Value = h.Jegy;
           
                if (k.ShowDialog() == true)
                {
                    ltb_halgatok.Items.Remove(ltb_halgatok.SelectedItem);
                    ltb_halgatok.Items.Add(new Halgato(k.tbx_nev.Text, (int)k.sdr_jegy.Value));
                }
            }
        }

        private void btn_torles_Click(object sender, RoutedEventArgs e)
        {
            if (ltb_halgatok.SelectedItem!=null)
            {
                ltb_halgatok.Items.Remove(ltb_halgatok.SelectedItem);
            }
            
        }
    }
}
