using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
   public class HomerSzenzor:Szenzor
    {
       
        public HomerSzenzor():base("Hőmérséklet szenzor")
        {
            //this.UtolsoErtek = rnd.Next(15,31);
        }

        protected override void Meres(double celHomerseklet)
        {
            int referencia= Math.Abs((int)(celHomerseklet - this.UtolsoErtek));
            if (referencia > 5) referencia = 5;
            

            
            double valtozas = rnd.Next(0,referencia );//rnd.Next(0, 6) + rnd.Next();
            if (this.UtolsoErtek>celHomerseklet) valtozas *= -1;
            this.UtolsoErtek += valtozas;
        }


    }
}
