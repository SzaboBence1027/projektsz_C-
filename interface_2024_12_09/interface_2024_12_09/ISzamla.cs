using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2024_12_09
{
    interface ISzamla
    {
        string Szamlaszam { get; }
        string Tulajdonos { get; }
        float Egyenleg { get; }

        void Befizetes(float osszeg);
        void Kivonas(float osszeg);
        float KamatSzamitas();
    }
}
