using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._16_Dolgozat_Szabó.Bence
{
   abstract class MediaElem
    {
        string cim,szerzo;
        int kiadaseve;
        public string Cim { get=>cim; }
        public string Szerzo { get=>szerzo; }
        public int KiadasEve { get=>kiadaseve; }

        public MediaElem(string cim, string szerzo,int kiadaseve)
        {
            this.cim=cim;
            this.szerzo = szerzo;
            this.kiadaseve = kiadaseve;

        }
       protected abstract  bool Ujtartalom();
        public override string ToString()
        {
            return $"Mű Címe:{Cim},Szerző neve:{Szerzo},Kiadas Éve:{KiadasEve}, ";
        }

    }
}
