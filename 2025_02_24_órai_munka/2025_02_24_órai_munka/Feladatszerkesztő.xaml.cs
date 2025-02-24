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
    }
}
