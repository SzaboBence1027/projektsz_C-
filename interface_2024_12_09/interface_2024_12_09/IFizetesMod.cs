using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2024_12_09
{ enum Nev
    {
        Bankártya,
        Utalás,
        Kp
    }
    interface IFizetesMod
    {
        float Koltseg(float osszeg);
    }
}
