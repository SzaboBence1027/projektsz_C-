using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
   public interface IEszkoz
    {
        string Nev { get; }
        bool Aktiv { get; }
        void Bekapcsol();
        void Kikapcsol();
        void Frissit(double celHomerseklet);
        void Frissit();
    }
}
