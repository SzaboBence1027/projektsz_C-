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

namespace _2025_02_24_órai_munka
{
    /// <summary>
    /// Interaction logic for Feladatszerkesztő.xaml
    /// </summary>
    public partial class Feladatszerkesztő : Window
    {
        public Feladat feladat;
        public Feladatszerkesztő()
        {
            InitializeComponent();
            this.feladat= new Feladat();
            this.DataContext = feladat;
        }
        public Feladatszerkesztő(Feladat f)
        {
            InitializeComponent();
            this.feladat = f;
            this.DataContext = feladat;
        }

        private void btn_mentes_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = tb_nev.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = tb_leiras.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();

            be = tb_hatarido.GetBindingExpression(TextBox.TextProperty);
            be.UpdateSource();
            
            be= cbx_kesz.GetBindingExpression(CheckBox.IsCheckedProperty);
            be.UpdateSource();
            this.DialogResult = true;
        }
    }
}
