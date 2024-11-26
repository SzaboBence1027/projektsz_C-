using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class Jarmu
    {
        public char azonosito { get; private set; }
        public float x { get; protected set; }
        public float y { get; protected set; }
        protected Terkep terkep;
        public Jarmu(char azonosito,float x,float y,Terkep terkep)
        {
            this.azonosito = azonosito;
            this.x = x;
            this.y = y;
            this.terkep = terkep;
        }

        public virtual bool IdeLephet(float x,float y)
        {
            return terkep.TerkepenBeluliPozicio(x, y);
        }
    }
}
