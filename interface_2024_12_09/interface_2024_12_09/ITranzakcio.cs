using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2024_12_09
{
    interface ITranzakcio
    {
        string TranzakcioId { get; }
        DateTime datum { get; }
        ISzamla ForrasSzamla { get; }
        ISzamla CelSzamla { get; }
        float osszeg { get; }

        void Vegrehajt();

    }
}
