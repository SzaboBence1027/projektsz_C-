using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_02_24_órai_munka
{
    public class Feladat : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        string nev,leiras;
        DateTime hatarido;
        bool kesz;

        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras;  set=> leiras = value; }
        public DateTime Hatarido { get => hatarido; set => hatarido = value; }
        public bool Kesz { get => kesz; set => kesz = value; }

        public Feladat(string nev,string leiras,DateTime hatarido)
        {
            this.nev = nev;
            this.leiras = leiras;
            this.hatarido = hatarido;
            this.kesz = false;

        }
        public Feladat()
        {

        }
    }
}
