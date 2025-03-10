using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_órai_munka
{
    public class Feladat : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string nev,leiras;
        string hatarido;
        bool kesz;

        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras;  set=> leiras = value; }
        public string Hatarido { get => hatarido; set { hatarido = value; OnPropertyChanged(); } }
        public bool Kesz { get => kesz; set { kesz = value;
                OnPropertyChanged();
            } }

        public Feladat(string nev,string leiras,string hatarido)
        {
            this.nev = nev;
            this.leiras = leiras;
            this.hatarido = hatarido;
            this.kesz = false;

        }
        public Feladat()
        {
            this.kesz = false;
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
