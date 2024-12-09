using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödes_pelda_2024_11_25
{
    class Kor:Sikidom
    {
        private float sugar;
        public float Sugar { get => sugar; }

        public Kor(string szin,float sugar):base(szin)
        {
            this.sugar = sugar;
            Kerulet();
            Terulet();
            Kilyukaszt();
        }
        protected override float Kerulet()
        {
     
            return (float)Math.Round((2 * sugar * Math.PI),2);
            
        }
        public override float Terulet()
        {
          
            return (float)Math.Round(((sugar * sugar) * Math.PI),2);
        }

        public override string ToString()
        {
            return base.ToString()+$" . Ez a sikidom egy kör ";
        }
    }
}
