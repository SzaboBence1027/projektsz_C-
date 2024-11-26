using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingatlan_oroklodes
{
    class INgatlan
    {
       
        protected int ar,terulet;
        protected string cim, tulajdonos, tipus;
        protected string ifk;
        public int Ar
        {
            get { return ar; }
            set
            {
                if (value < 1000000)
                {
                    throw new Exception("hibás ár");
                }
                ar = value;
            }
        }
        public INgatlan(int ar,int terulet,string cim,string tulajdonos,string tipus)
        {
            Ar = ar;
            this.terulet = terulet;
            this.cim = cim;
            this.tulajdonos = tulajdonos;
            this.tipus = tipus;

        }
        public INgatlan(int terulet, string cim, string tulajdonos, string tipus)
        {
            this.ar = 100000;
            this.terulet = terulet;
            this.cim = cim;
            this.tulajdonos = tulajdonos;
            this.tipus = tipus;
        }
    }
}
