using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using orvosi_nobeldíjak;
using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace orvosi_nobeldijak_gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<nobel_dijazotak> nobel_dijasok;
        ObservableCollection<Elethossz> elethosszak;
        public MainWindow()
        {
            InitializeComponent();
             
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             new List<nobel_dijazotak>();
             new List<Elethossz>();
            var dgl = new OpenFileDialog();
            if (dgl.ShowDialog()!=true)
            {
                return;
            }
            FileInfo fileInfo = new(dgl.FileName);
            File_name.Text = fileInfo.Name;
            StreamReader sr = new(fileInfo.OpenRead(), Encoding.UTF8);
            string elso_sor=sr.ReadLine();
            while (!sr.EndOfStream)
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] be_sor = sor.Split(';');
                    nobel_dijasok.Add(new nobel_dijazotak(be_sor[0], be_sor[1], be_sor[2], be_sor[3]));

                }
            }
        }
    }
}