using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class Auto:MozgoJarmu
    {
        float sebbeseg;
        public Auto(char id, float x, float y, Terkep terkep, float iranyX, float iranyY) : base(id, x, y, terkep, iranyX, iranyY)
        {
            sebbeseg = 1;
        }
        public override bool IdeLephet(float x, float y)
        {

            if (terkep.Magassag(x,y)<=0)
            {
                return false;
            }
            return true;
            

            
        }
        protected override void Gyorsit()
        {
            sebbeseg += (float)0.2;
        }
        protected override void Lassit()
        {
            if (sebbeseg>=(float)0.5)
            {
                sebbeseg -= (float)0.1;
            }
            
           
        }
        public override void Mozog()
        {
            if (y < (y+= iranyY * sebbeseg))
            {
               
                x += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyX * sebbeseg : x);
                y += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyY * sebbeseg : y);
                Lassit();
            }
            else if(y > (y += iranyY * sebbeseg))
            {
                
                x += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyX * sebbeseg : x);
                y += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyY * sebbeseg : y);
                Gyorsit();
            }
            else
            {
                x += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyX * sebbeseg : x);
                y += (IdeLephet(x + iranyX * sebbeseg, y + iranyY * sebbeseg) ? iranyY * sebbeseg : y);
            }
           
        }
    }
}
