using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._16_Dolgozat_Szabó.Bence
{
    class Folyoirat : MediaElem
    {
        public Folyoirat(string cim, string szerzo, int kiadaseve) : base(cim, szerzo, kiadaseve)
        {

        }
        protected override bool Ujtartalom()
        {
            int jelenlegi_ev = Convert.ToInt32(DateTime.Now.Year);
            if ((jelenlegi_ev - KiadasEve) > 10)
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return base.ToString()+"A Folyóiratok nem kölcsönözhetők";
        }
    }
}
