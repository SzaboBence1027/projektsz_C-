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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ltb_feltet.Items.Add("olivabogyó");
            ltb_feltet.Items.Add("Szalámi");
            ltb_feltet.Items.Add("Sajt");

            cmb_meret.Items.Add("24 cm");
            cmb_meret.Items.Add("32 cm");
            cmb_meret.Items.Add("50 cm");
            cmb_meret.SelectedIndex = 0;
        }

        private void btn_Szamol_Click(object sender, RoutedEventArgs e)
        {
            int ar = 0;
            if (cmb_meret.SelectedIndex==0)
            {
                ar += 1000;
            }
             
            else if (cmb_meret.SelectedIndex==1)
            {
                ar += 2000;
            }
            else if (cmb_meret.SelectedIndex == 2)
            {
                ar += 3000;
            }

            ar += ltb_feltet.SelectedItems.Count * 500;
            lbl_kiir.Content = $"Az étel ára: {ar} ft";
        }
    }
}
