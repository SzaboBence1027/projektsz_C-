using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OkosOtthon
{
  public abstract  class Szenzor:IEszkoz
    {
        string nev;
        bool aktiv;
        protected static Random rnd = new Random();

        public string Nev { get => nev; }
        public bool Aktiv { get => aktiv;  }
        public double UtolsoErtek { get; protected set; }
        public Szenzor(string nev)
        {
            this.nev = nev;
            aktiv = false;
        }

       public void Bekapcsol()
        {
            this.aktiv = true;
        }
       public void Kikapcsol()
        {
            this.aktiv = false;
        }
      protected  abstract void Meres(double celHomerseklet);
      
       public void Frissit()
        {
            Meres(UtolsoErtek);
        }
        

        public override string ToString()
        {
            return $"Név: {this.nev}, aktiv:{this.aktiv} utolso mert ertek: {this.UtolsoErtek}";
        }

        public void Frissit(double celHomerseklet)
        {
            throw new NotImplementedException();
        }
    }
}
