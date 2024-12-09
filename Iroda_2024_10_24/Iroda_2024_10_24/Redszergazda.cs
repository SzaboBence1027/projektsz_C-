using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iroda_2024_10_24
{
    class Redszergazda :Felhasznalo
    {
        public Redszergazda(string nev, string jelszo): 
            base(nev,jelszo)
        {
            munkakor="Rendszergazda";


        }
    }
}
