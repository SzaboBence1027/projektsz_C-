using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._16_Dolgozat_Szabó.Bence
{
    class DVD : MediaElem, IKolcsonozheto
    {
        bool kolcsonozve;


        public bool Kolcsonozve { get=>kolcsonozve; }

        public DVD(string cim, string szerzo, int kiadaseve) : base(cim, szerzo, kiadaseve)
        {
            kolcsonozve = false;
        }

        protected override bool Ujtartalom()
        {
            int jelenlegi_ev = Convert.ToInt32(DateTime.Now.Year);
            if ((jelenlegi_ev - KiadasEve) > 10)
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
            string kolcsonzes = kolcsonozve ? "Nem" : "Igen";
            return base.ToString() + $"Kolcsonozhető a DVD:" + kolcsonzes;
        }
    }
}
