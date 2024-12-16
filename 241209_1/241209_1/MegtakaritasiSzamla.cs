using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    class MegtakaritasiSzamla : Szamla
    {
        public MegtakaritasiSzamla(string szamlaszam,
            string tulajdonos, int egyenleg)
            : base (szamlaszam, tulajdonos, egyenleg)
        {

        }
        public override int KamatSzamitas()
        {
            return (int)(this.Egyenleg * 0.02f);
        }
    }
}
