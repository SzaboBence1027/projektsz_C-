using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark_kezelo
{
    class Jarmu
    {
        string marka;
        string tipus;
        int gyartasiev;

        public string Marka { get => marka;  }
        public int Gyartasiev { get => gyartasiev;  }
        public string Tipus { get => tipus;  }

        List<string> Esemenyek;
        public Jarmu(string marka,string tipus,int gyartasiev)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.gyartasiev = gyartasiev;
            this.Esemenyek = new List<string>();

        }


       public virtual void EssemenyHozzadas(string esemeny)
        {
            if (Esemenyek.Count()>10)
            {
                throw new TulSokEsemményExeption();
            }
            else
            {
                this.Esemenyek.Add(esemeny);
            }
        }
       public string EsemenyListazasa()
        {
            string szoveg="";
            foreach (string esemeny in Esemenyek)
            {
                szoveg += $"{esemeny},";
            }
            return szoveg;
        }

        public override string ToString()
        {
            return $"Marka:{this.marka}, tipus:{this.tipus}, gyartasiev {this.gyartasiev}";
        }
    }
}
