using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class Helikopter:MozgoJarmu
    {
        float sebbeseg;
        public Helikopter( float x, float y, Terkep terkep,float iranyX,float iranyY):base('H',x,y,terkep,iranyX,iranyY)
        {
            sebbeseg = 1;
        }
        protected override void Gyorsit()
        {
            sebbeseg +=(float)0.1;
        }
        protected override void Lassit()
        {
            if (sebbeseg>0)
            {
                sebbeseg -=(float) 0.1;
            }
           
        }
        public override void Mozog()
        {
            x += (IdeLephet(x+iranyX * sebbeseg,y+ iranyY * sebbeseg) ? iranyX * sebbeseg : x);
            y += (IdeLephet(x+iranyX * sebbeseg,y+ iranyY * sebbeseg) ? iranyY * sebbeseg : y);
        }

    }
}
