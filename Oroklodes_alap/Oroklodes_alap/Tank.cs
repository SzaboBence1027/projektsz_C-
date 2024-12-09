using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    sealed class Tank : Auto
    {
        float sebbeseg;
        int uzemanyag;
        public Tank(float x, float y, Terkep terkep, float iranyX, float iranyY) : base('T', x, y, terkep, iranyX, iranyY)
        {
            sebbeseg = 1;
            uzemanyag = 30;

        }
        public override bool IdeLephet(float x, float y)
        {
            return true;
        }
        public override void Mozog()
        {
            if (uzemanyag>0)
            {
                x += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyX * sebbeseg : x);
                y += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyY * sebbeseg : y);
                uzemanyag -= 10;
            }
           
        }

    }
}
