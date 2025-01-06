using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._16_Dolgozat_Szabó.Bence
{
    class Konyv:MediaElem,IKolcsonozheto
    {
        int oldalszam;
        bool kolcsonozve;
        public bool Kolcsonozve { get=>kolcsonozve; }
        public int Oldalszám { get=>oldalszam; }
        public Konyv(string cim,string szerzo,int kiadaseve,int oldalszam):base(cim,szerzo,kiadaseve)
        {
            
            this.oldalszam = oldalszam;
            kolcsonozve = false;
        }

        bool Hosszu_e()
        {
            if (Oldalszám>500)
            {
                return true;
            }
            return false;
        }
        protected override bool Ujtartalom()
        {
            int jelenlegi_ev =Convert.ToInt32( DateTime.Now.Year);
            if ((jelenlegi_ev-KiadasEve)>10)
            {
                return true;
            }
            return false;
        }

        public void Kolcsonoz()
        {
                kolcsonozve = true;
            
           
        }

        public void Visszahoz()
        {
            
                kolcsonozve = false;
            
        }

        public override string ToString()
        {
           string kolcsonzes= kolcsonozve ? "Nem" : "Igen";
            return base.ToString()+$"Kolcsonozhető a könyv:"+kolcsonzes;
        }

    }
}
