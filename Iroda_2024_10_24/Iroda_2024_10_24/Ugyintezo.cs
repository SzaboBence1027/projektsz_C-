using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iroda_2024_10_24
{
    class Ugyintezo:Felhasznalo
    {
        int sorszam;
        public Ugyintezo(string nev,string jelszo,int sorszam):base(nev,jelszo)
        {
            this.sorszam = sorszam;
        }
        public override string Adatok()
        {
            return base.Adatok()+$",Sorszám: {sorszam}";
        }

    }
}
