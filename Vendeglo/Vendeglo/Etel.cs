using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendeglo
{
   public class Etel
    {
        string nev { get; }
       protected int alapar { get; }
        List<int> Ertekelesek;

        public double Atlag { set {
                if (Ertekelesek.Count==0)
                {
                    throw new Exception("Nincs átlagolható értékelés");
                }
                else
                {
                   value= Ertekelesek.Average();
                }
            } }

        public Etel(string nev,int alapar)
        {
            this.nev = nev;
            this.alapar = alapar;
            this.Ertekelesek = new List<int>();
        }

        public virtual void Ertekeles(int ertekeles)
        {
            if (Ertekelesek.Count()>10)
            {
                throw new Exception("Nem lehet több értékelést felvenni. "+ertekeles);
            }
            else
            {
                Ertekelesek.Add(ertekeles);
            }

        }

        public override string ToString()
        {
            return $"Étel neve:{nev}, alapára: {alapar}Ft";
        }



    }
}
