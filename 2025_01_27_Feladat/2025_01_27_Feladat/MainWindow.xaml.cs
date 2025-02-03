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

namespace _2025_01_27_Feladat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Random rnd = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

       

        private void btn_Bevitel_Click_1(object sender, RoutedEventArgs e)
        {
            Label l = new Label();
            l.Content = Tb_bemenet.Text;
            l.Background = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255), (byte)rnd.Next(0, 255)));
            wpl_tarolo.Children.Add(l);

            l.MouseLeftButtonDown += L_MouseLeftButtonDown;
            l.MouseRightButtonDown += L_MouseRightButtonDown;
        }

        private void L_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label l = sender as Label;
            wpl_tarolo.Children.Remove(l);
            wpl_tarolo.Children.Add(l);
        }

        private void L_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Label l = sender as Label;
            wpl_tarolo.Children.Remove(l);
        }
    }
}
