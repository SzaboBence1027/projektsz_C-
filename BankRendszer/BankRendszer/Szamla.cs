using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankRendszer
{
   public class Szamla : ISzamlaKezelo, INotifyPropertyChanged
    {

        string tulajdonos;
        int egyenlegg;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler!=null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Szamla(string tulajdonos,int egyenleg)
        {
            this.tulajdonos = tulajdonos;
            this.egyenlegg = egyenleg;
        }
        public int egyenleg => throw new NotImplementedException();

        public string Tulajdonos { get => tulajdonos; }
        public int Egyenleg { get => egyenlegg; }

        public void Befizet(int osszeg)
        {
            this.egyenlegg += osszeg;
            OnPropertyChanged("Egyenleg");
        }

        public void Kivesz(int osszeg)
        {
            if (!TranzakcioEloellenorzes(osszeg)) throw new NincsElégEgyelnelExeption(this);
            
                this.egyenlegg -= osszeg;
            OnPropertyChanged("Egyenleg");


        }

        public bool TranzakcioEloellenorzes(int osszeg)
        {
            if (osszeg > this.egyenlegg) return false;
            return true;
        }
        
        public override string ToString()
        {
            return $"Számla tulajdonosa:{this.tulajdonos}, egyenlege:{this.egyenlegg}Ft";
        }
    }
}
