using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    interface IFizetesiMod
    {
        string Nev { get; }
        int Koltseg(int osszeg);
    }
}
