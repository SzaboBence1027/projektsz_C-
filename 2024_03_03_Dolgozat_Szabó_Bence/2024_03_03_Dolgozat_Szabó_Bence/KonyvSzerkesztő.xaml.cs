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
using System.Windows.Shapes;

namespace _2024_03_03_Dolgozat_Szabó_Bence
{
    /// <summary>
    /// Interaction logic for KonyvSzerkesztő.xaml
    /// </summary>
    public partial class KonyvSzerkesztő : Window
    {
        public Konyv konyv;
        public KonyvSzerkesztő()
        {
            InitializeComponent();
            this.konyv = new Konyv();
            this.DataContext = konyv;
        }
        public KonyvSzerkesztő(Konyv k)
        {
            InitializeComponent();
            this.konyv = k;
            this.DataContext = konyv;
        }

        private void btn_mentes_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = tbx_Cim.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            
             be = tbx_Szerzo.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = tbx_kategoria.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = chb_elolvasott.GetBindingExpression(CheckBox.IsCheckedProperty);
            be.UpdateSource();
            this.DialogResult   = true;
        }
    }
}
