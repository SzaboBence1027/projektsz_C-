using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödes_pelda_2024_11_25
{
    class Teglalap:Sikidom
    {
        private double magasag;
        private double szeleseg;

        public double Teglalap_magassag { get => magasag; }
        public double Teglalap_szeleseg{ get => szeleseg; }


        public Teglalap(string szin,double magasag,double szeleseg) : base(szin)
        {
            this.magasag = magasag;
            this.szeleseg = szeleseg;
        }
        protected override float Kerulet()
        {
            return (float)(2 * (magasag + szeleseg));
        }
        public override float Terulet()
        {
            return (float)(magasag*szeleseg);
        }
       
        public override string ToString()
        {
            string tipus = (magasag == szeleseg) ? "Négyzet" : "Téglalap";
            return base.ToString() + $" . Ez a sikidom egy "+tipus;
        }
    }
}
