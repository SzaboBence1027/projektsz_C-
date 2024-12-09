using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    abstract class MozgoJarmu:Jarmu
    {
        protected float iranyX, iranyY;

       protected void UjIranyVektor(float iranyX, float iranyY)
        {
            this.iranyX = iranyX;
            this.iranyY = iranyY;
            
        }

        public MozgoJarmu(char azonosito, float x, float y, Terkep terkep,float iranyX,float iranyY) :base(azonosito,x,y,terkep)
        {
            UjIranyVektor((float)iranyX, iranyY);
        }
        protected abstract void Gyorsit();
        protected abstract void Lassit();
        public abstract void Mozog();
       
    }
}
