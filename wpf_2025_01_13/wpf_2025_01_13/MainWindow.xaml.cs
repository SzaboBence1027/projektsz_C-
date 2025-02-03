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
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpf_2025_01_13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /*Label l = new Label();
            l.Height = 100;
            l.Content = "C# es valami";
            l.Width = 100;
            l.HorizontalAlignment = HorizontalAlignment.Left;
            l.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin = l.Margin;
            margin.Left=100;
            margin.Right = 100;
            margin.Top = 100;
            margin.Bottom = 110;
            gr_tarolo.Children.Add(l);*/
            lable_kiiras.Content = "Kódból módosított";
        }

        private void b_gomb_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Nev.Text!=string.Empty)
            {
                lable_kiiras.Content = $"Szia {TB_Nev.Text}!";
            }
            else
            {
                lable_kiiras.Content = $"Kéne egy név";
            }
            
        }

        private void Rb_Ferfi_Checked(object sender, RoutedEventArgs e)
        {
           
            Rb_No.IsChecked = false;
            if (Rb_Ferfi.IsChecked==true)
            {
                lable_kiiras.Content = $"Szia Mr. {TB_Nev.Text}!";
            }
        }

        private void Rb_No_Checked(object sender, RoutedEventArgs e)
        {
            
            Rb_Ferfi.IsChecked = false;
            if (Rb_No.IsChecked == true)
            {
                lable_kiiras.Content = $"Szia Mrs. {TB_Nev.Text}!";
            }
        }

        private void b_szamolas_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int sz_1 = Convert.ToInt32(Tb_Szam1.Text);
                int sz_2 = Convert.ToInt32(Tb_Szam2.Text);
                int sz_3 = Convert.ToInt32(Tb_Szam3.Text);
                if (Rb_osszeadas.IsChecked == true)
                {
                    int szam = sz_1 + sz_2 + sz_3;
                    Lb_eredmeny.Content = "Eredmény:" + szam;
                }
                else if (Rb_szorzas.IsChecked == true)
                {
                    int szam = sz_1 * sz_2 * sz_3;
                    Lb_eredmeny.Content = "Eredmény:" + szam;
                }
                else if (Rb_AVG.IsChecked == true)
                {
                    int szam = sz_1 + sz_2 + sz_3;
                    Lb_eredmeny.Content = "Eredmény:" + szam / 3;
                }
                else
                {
                    Lb_eredmeny.Content = "Válasszon műveletet";
                }
            }
            catch (Exception)
            {

                throw new Exception("Hibás Adatbevitel");
            }
            
            
        }
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
