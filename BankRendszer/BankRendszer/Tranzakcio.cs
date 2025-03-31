using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRendszer
{
  public  class Tranzakcio
    {
        Szamla forrasSzamla;
        Szamla celSzamla;
        int osszeg;
        DateTime datum;
        bool sikeres;

        public Tranzakcio(Szamla forrasSzamla,Szamla celSzamla,int osszeg)
        {
            this.forrasSzamla = forrasSzamla;
            this.celSzamla = celSzamla;
            this.osszeg = osszeg;
            sikeres = false;
        }

       public void Vegrehajt()
        {
            this.datum = DateTime.Now;
            forrasSzamla.Kivesz(this.osszeg);
            celSzamla.Befizet(this.osszeg);
           
            this.sikeres = true;


        }
        public override string ToString()
        {
            return $"******************\nTranzakció átekintése: \n Dátum:{this.datum}\n Forrásszámla: {this.forrasSzamla.ToString()} \n CelSzamla {this.celSzamla.ToString()} \n osszeg:{this.osszeg}\n sikkeresége{this.sikeres}";
        }
    }
}
