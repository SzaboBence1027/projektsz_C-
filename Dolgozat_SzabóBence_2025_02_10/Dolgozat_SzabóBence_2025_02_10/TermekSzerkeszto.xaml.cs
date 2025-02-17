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

namespace Dolgozat_SzabóBence_2025_02_10
{
    /// <summary>
    /// Interaction logic for TermekSzerkeszto.xaml
    /// </summary>
    public partial class TermekSzerkeszto : Window
    {
        public TermekSzerkeszto()
        {
            InitializeComponent();
        }

        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
