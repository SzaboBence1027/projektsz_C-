using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2024_03_03_Dolgozat_Szabó_Bence
{
    public class Konyv: INotifyPropertyChanged
    {
        string cim, szerzo, kategoria;
        bool olvasott;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Cim { get => cim; set { cim = value; OnPropertyChanged(); } }
        public string Szerzo { get => szerzo; set { szerzo = value; OnPropertyChanged(); } }
        public string Kategoria { get => kategoria; set { kategoria = value; OnPropertyChanged(); } }
        public bool Olvasott { get => olvasott; set { olvasott = value; OnPropertyChanged(); }  }

        public Konyv(string cim,string szerzo,string kategoria)
        {
            this.cim = cim;
            this.szerzo = szerzo;
            this.kategoria = kategoria;
            olvasott = false;
        }
        public Konyv()
        {
            this.olvasott = false;
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
