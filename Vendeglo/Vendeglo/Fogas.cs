using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendeglo
{
    enum adagMeret {
        kicsi,
        normál,
        extra
    }

  public  class Fogas : Etel, IFizetheto
    {
        adagMeret AdagMeret;
       

       public int Ar { get => Adag_ar(alapar,AdagMeret) ; }

        //Nem tudtam máshogy megcsinálni tudom nem szép
        int Adag_ar(int ar, adagMeret adagmerete) {
            if (AdagMeret == adagMeret.kicsi)
            {
               return Convert.ToInt32(alapar * 0.8);
            }
             else if (AdagMeret == adagMeret.normál)
            {
                return alapar;
            }
            else
            {
                return Convert.ToInt32(alapar * 1.3);
            }
        }






       








        public int Fizetendo(int letszam)
        {
            return Ar* letszam;
        }

        public Fogas(adagMeret AdagMeret,string nev,int alapar):base(nev,alapar)
        {
            this.AdagMeret = AdagMeret;
        }

        public override void Ertekeles(int ertekeles)
        {
            if (ertekeles >= 3)
            {
                base.Ertekeles(ertekeles);
            }
           
        }
        public override string ToString()
        {
            return base.ToString()+$"Adag méret: {AdagMeret} Ára {Ar} Ft ";
        }
    }
}
