using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Szabó_Bence_2024_11_18
{
    enum kategoria
    {
        emlős,
        madár,
        hullő,
        hal
    }
    class Allat
    {
        string nev;
        kategoria Kategoria;

        public kategoria Allat_Kategoria { get => Kategoria; }
       
        public Allat(string nev,kategoria kategoria)
        {
            this.nev = nev;
            this.Kategoria = kategoria;
        }
        public override string ToString()
        {
            string kiiras = $"Név {nev}, Kategória {Kategoria}\n";
            return kiiras;
        }
    }
}
