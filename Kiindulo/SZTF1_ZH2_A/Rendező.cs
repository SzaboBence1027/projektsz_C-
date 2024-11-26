using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1_ZH2_A
{
    class Rendező
    {
        public string Nev { get; }
        public Epizod [] Epizodok { get; }

        public Rendező(string sor,int rendezet_ep_szam)
        {
            Epizodok = new Epizod[rendezet_ep_szam];
        }
    }
}
