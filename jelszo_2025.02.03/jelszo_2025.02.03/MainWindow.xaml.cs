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

namespace jelszo_2025._02._03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    
    public partial class MainWindow : Window
    {
        int holtartunk = 0;
        string PIN = "2462";
        public MainWindow()
        {
            InitializeComponent();
           
            
        }
       private void OnMouseEnterHandler(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            
            if (l.Content.ToString()==PIN[holtartunk].ToString())
            {
                holtartunk++;
                l.Background = Brushes.Red;
            }
        }
    }
}
