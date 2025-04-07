using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
   public class FutesRendszer : IEszkoz,INotifyPropertyChanged
    {
        double celHomerseklet;
        string nev;
        bool aktiv;
        HomerSzenzor homerSzenzor;

        public event PropertyChangedEventHandler PropertyChanged;
        

        public double CelHomerseklet { get => celHomerseklet; set => celHomerseklet = value; }

        public string Nev { get => nev; }

        public bool Aktiv { get => aktiv; }

        public FutesRendszer(string nev,double celHomerseklet,HomerSzenzor szenzor)
        {
            this.nev = nev;
            this.celHomerseklet = celHomerseklet;
            this.homerSzenzor = szenzor;

        }
        


        public void Bekapcsol()
        {
            this.aktiv = true;
        }

        public void Kikapcsol()
        {
            this.aktiv = false;
        }


        public void Frissit()
        {
            if (this.homerSzenzor.Aktiv == false) 
                this.homerSzenzor.Bekapcsol();
            this.homerSzenzor.Frissit();

            if (this.celHomerseklet > this.homerSzenzor.UtolsoErtek && this.aktiv != true)
                this.Bekapcsol();
            if (this.celHomerseklet <= this.homerSzenzor.UtolsoErtek && this.aktiv == true)
                this.Kikapcsol();
            
        }
        public override string ToString()
        {
            return $"Nev: {this.nev}, aktiv: {this.aktiv},célhőmérséklet: {this.celHomerseklet}, mért hőmérséklet {this.homerSzenzor.UtolsoErtek} ";
        }

        public void Frissit(double celHomerseklet)
        {
            throw new NotImplementedException();
        }
    }
}
