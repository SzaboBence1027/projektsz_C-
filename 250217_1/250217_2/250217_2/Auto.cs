using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _250217_2
{
    class Auto : INotifyPropertyChanged
    {
        string rendszam;
        int kmOra;

        public event PropertyChangedEventHandler PropertyChanged;

        public Auto(string rendszam, int kmOra)
        {
            this.rendszam = rendszam;
            this.kmOra = kmOra;
        }

        public string Rendszam { get => rendszam; set => rendszam = value; }
        public int KmOra { 
            get => kmOra;
            set
            {
                kmOra = value;
                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName="")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
