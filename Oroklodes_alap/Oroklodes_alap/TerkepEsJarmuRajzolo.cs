using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class TerkepEsJarmuRajzolo:TerkepRajzolo
    {
        protected Jarmu [] jarmvek;
        protected int jarmuvekN;
        public TerkepEsJarmuRajzolo(Terkep terkep,int jarmuszam):base(terkep)
        {
            jarmvek = new Jarmu[jarmuszam];
            jarmuvekN = 0;
        }
        public void JarmuFelvetel(Jarmu jarmu)
        {
            jarmvek[jarmuvekN]= jarmu;
            jarmuvekN++;
        }

        protected override char MiVanItt(int x, int y)
        {
            for (int i = 0; i < jarmuvekN; i++)
            {
                if (x==Convert.ToInt32(jarmvek[i].x)&& y == Convert.ToInt32(jarmvek[i].y))
                {
                    return jarmvek[i].azonosito;
                }
            }
            return base.MiVanItt(x, y);
        }
    }
}
