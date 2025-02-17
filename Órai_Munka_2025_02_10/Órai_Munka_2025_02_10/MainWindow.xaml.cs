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

namespace Órai_Munka_2025_02_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cby_személyek.Items.Add(new Személy("Kis Emil", 20, 200));
            cby_személyek.Items.Add(new Személy("Kis Béla", 210, 100));
            cby_személyek.Items.Add(new Személy("Kis Kevin", 40, 230));

            cby_személyek.SelectedIndex = 0;
        }
    }
}
