using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark_kezelo
{
   public class Auto : Jarmu, Ikarbantarthato
    {
        int kmOraAllas;


        public int KmOraAllas { get => kmOraAllas; }

        public int Karbantartasido { get => KmOraAllas / 1000; }
    

        public Auto(string marka,string tipus,int gyartasiev,int KmOraAllas):base(marka,tipus,gyartasiev)
        {
            this.kmOraAllas = KmOraAllas;
        }
        public override void EssemenyHozzadas(string esemeny)
        {
            if (esemeny.Length<=10)
            {
                base.EssemenyHozzadas(esemeny);
            }
          
        }

        public int Karbantartas(int tavolsag)
        {
            this.kmOraAllas += tavolsag;
            return this.kmOraAllas;
        }

        public override string ToString()
        {
            return base.ToString()+$". Km ora allas: {this.KmOraAllas}, Karbantartasi Ido: {this.Karbantartasido}";
        }
    }
}
