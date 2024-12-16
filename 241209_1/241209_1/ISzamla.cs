using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    interface ISzamla
    {
        string Szamlaszam { get; }
        string Tulajdonos { get; }
        int Egyenleg { get; }
        void Befizetes(int osszeg);
        void Kivonas(int osszeg);
        int KamatSzamitas();
    }
}
