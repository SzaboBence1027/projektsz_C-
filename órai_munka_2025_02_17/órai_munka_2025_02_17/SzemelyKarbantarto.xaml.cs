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

namespace órai_munka_2025_02_17
{
    /// <summary>
    /// Interaction logic for SzemelyKarbantarto.xaml
    /// </summary>
    public partial class SzemelyKarbantarto : Window
    {
        public Szemely szemely;
        public SzemelyKarbantarto()
        {
            InitializeComponent();
            this.szemely = new Szemely();
            this.DataContext = szemely;
            
        }
        public SzemelyKarbantarto(Szemely mod)
        {
            InitializeComponent();
            this.szemely = mod;
            this.DataContext = szemely;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = tb_nev.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = tb_telefonszam.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = tb_eletkor.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            this.DialogResult = true;

        }
    }
}
