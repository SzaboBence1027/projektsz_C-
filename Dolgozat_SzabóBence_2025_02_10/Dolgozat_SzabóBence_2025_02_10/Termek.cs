using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_SzabóBence_2025_02_10
{
    class Termek
    {
        string nev;
        int ar;
        bool eladott;

        public string Nev { get => nev;  }
        public int Ar { get => ar;  }
        public bool Eladott { get => eladott;  }
        public Termek(string nev,int ar)
        {
            this.nev = nev;
            this.ar = ar;
            eladott = false;

        }
        public Termek(string nev, int ar,bool eladott)
         {
            this.nev = nev;
            this.ar = ar;
           this.eladott = eladott;

        }
    public override string ToString()
        {
            string eladott = Eladott ? "Igen" : "Nem";
            return $"Termék neve: {Nev},Ára: {Ar} Ft,Eladva: {eladott}";
        }
    }
}
