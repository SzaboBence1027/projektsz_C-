using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    class Atutalas : IFizetesiMod
    {
        string nev;
        public string Nev { get => nev; }

        public Atutalas()
        {
            this.nev = "Átutalás";
        }
        public int Koltseg(int osszeg)
        {
            return (int)(osszeg * 0.02f);
        }
    }
}
