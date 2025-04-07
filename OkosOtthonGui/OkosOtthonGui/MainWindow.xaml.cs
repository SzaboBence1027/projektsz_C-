using OkosOtthon;
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

namespace OkosOtthonGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OkosOtthonController vezerlo;
        public MainWindow()
        {
            InitializeComponent();
            vezerlo = new OkosOtthonController();
            IEszkoz homSzenzor = new HomerSzenzor();
            IEszkoz futesrendszer = new FutesRendszer("Ház Fűtésrendszer", 21, homSzenzor as HomerSzenzor);
            OkosOtthonController vezérlő = new OkosOtthonController();
            Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz, homSzenzor));
            vezérlő.ParancsVegrehajtó(Parancs.EszkozHozzaad, futesrendszer);

            //lbx_eszkozok.ItemsSource = vezerlo.Eszkozok;
            Cbx_parancsok.Items.Add(Parancs.EszkozHozzaad);
            Cbx_parancsok.Items.Add(Parancs.Frissit);
            Cbx_parancsok.Items.Add(Parancs.FutesBekapcsol);
            Cbx_parancsok.Items.Add(Parancs.Statusz);
        }

        private void btn_vegrehajt_Click(object sender, RoutedEventArgs e)
        {
            int  i = Cbx_parancsok.SelectedIndex ;
            if (i == -1) return;
            Parancs p = new Parancs();
            switch (i)
            {
                case 0:
                    p = Parancs.EszkozHozzaad;
                    break;
                case 1:
                    p = Parancs.Frissit;
                    break;
                case 2:
                    p = Parancs.FutesBekapcsol;
                    break;
                case 3:
                    p = Parancs.Statusz;
                    break;


                default:
                    break;
            }


            vezerlo.ParancsVegrehajtó(p,lbx_eszkozok.SelectedItem as IEszkoz);
        }
    }
}
