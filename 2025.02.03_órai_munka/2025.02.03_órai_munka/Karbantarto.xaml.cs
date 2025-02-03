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

namespace _2025._02._03_órai_munka
{
    /// <summary>
    /// Interaction logic for Karbantarto.xaml
    /// </summary>
    public partial class Karbantarto : Window
    {
        public Karbantarto()
        {
            InitializeComponent();
        }

        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
