using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class Szimulacio:TerkepEsJarmuRajzolo
    {
        public Szimulacio(Terkep terkep, int jarmuszam):base(terkep,jarmuszam)
        {

        }
        void EgyIdoEgysegEltelt()
        {
            for (int i = 0; i < jarmuvekN; i++)
            {
                if (jarmvek[i] is MozgoJarmu)
                {
                    (jarmvek[i] as MozgoJarmu).Mozog();
                }
            }
        }
       public void Fut()
        {
            while (true)
            {
                EgyIdoEgysegEltelt();
                Kirajzol();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
