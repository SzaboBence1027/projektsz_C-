using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    interface ITranzakcio
    {
        string TranzakcioID { get; }
        DateTime Datum { get; }
        ISzamla ForrasSzamla { get; }
        ISzamla CelSzamla { get; }
        IFizetesiMod FizetesiMod { get; }
        int Osszeg { get; }
        void Vegrehajt();
    }
}
