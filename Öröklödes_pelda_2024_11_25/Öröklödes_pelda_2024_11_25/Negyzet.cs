using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödes_pelda_2024_11_25
{
    class Negyzet:Teglalap
    {
        public double  negyzet_magasag{ get => Teglalap_magassag; }
        public double negyzet_szeleseg { get => Teglalap_szeleseg; }

        public Negyzet(string szin, double magasag, double szeleseg) :base(szin,magasag,szeleseg)
        {

        }
       
    }
}
