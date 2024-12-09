using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödes_pelda_2024_11_25
{

    abstract class Sikidom
    {
        private bool lyukas;
        private string szin;

        protected string Szin{get =>szin;}

        public Sikidom(string szin)
        {
            
            this.szin = szin;
        }

        virtual protected float Kerulet()
        {
            float kerulet=0;
            return kerulet;
        }
        virtual public float Terulet()
        {
            float terulet = 0;
            return terulet;
        }
         protected bool Kilyukaszt()
        {
            if (Terulet()>Kerulet())
            {
                lyukas=true;
                return lyukas;
            }
            return false;
        }

        public override string ToString()
        {
            string kiiras = lyukas?"Lyukas a Sikidom" + $",A sikidom szine {szin}, Terulete: {Terulet()} . Kerulete: {Kerulet()}" : "Nem lyukas a sikidom"+$",A sikidom szine {szin}, Terulete: {Terulet()} . Kerulete: {Kerulet()}";
            return kiiras;
            
        }

    }
}
