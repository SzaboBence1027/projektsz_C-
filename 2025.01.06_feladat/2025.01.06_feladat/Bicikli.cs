using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._06_feladat
{
    class Bicikli:Jarmu
    {
       
        bool hegyiBicikli;

        
        public bool HegyiBicikli { get => hegyiBicikli;}
        public Bicikli(string marka, string tipus, int gyartasi_ev,bool hegyibicikli) : base(marka, tipus, gyartasi_ev)
        {
            
            this.hegyiBicikli = hegyibicikli;
        }

       

        public int napiBerletiDij()
        {
            return rnd.Next(2000, 16001);
        }

        
        
        public override bool UzembenVan()
        {
            if (DateTime.Now.Year - this.Gyartasi_Ev > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool OffroadKepes()
        {
            if (hegyiBicikli==true)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString()+ $"HegyiBicikli:{this.hegyiBicikli} Bérelhető:Nem";
        }
    }
}
