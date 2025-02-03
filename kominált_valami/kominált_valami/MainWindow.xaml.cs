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

namespace kominált_valami
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        int holtarunk=1;
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Button b = new Button();
                b.Width = 30;
                b.Height = 30;
                b.Margin = new Thickness(rnd.Next(-750,750),rnd.Next(-400,400), 0, 0);
                b.Content = i+1;
                b.Click += B_Click;
                grd_tarolo.Children.Add(b);
                
                
            }
         
          
          
        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            if (b.Content.ToString()== holtarunk.ToString())
            {
                holtarunk++;
                grd_tarolo.Children.Remove(b);
            }
            if (holtarunk>10)
            {
                MessageBox.Show("Kész");
            }
        }

      
    }
}
