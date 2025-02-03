using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._02._03_órai_munka
{
    class Halgato
    {
        string nev;
        int jegy;
        public Halgato(string nev,int jegy)
        {
            this.nev = nev;
            this.jegy = jegy;
        }

        public string Nev { get => nev;  }
        public int Jegy { get => jegy;  }

        public override string ToString()
        {
            return $"{this.Nev} [{this.Jegy}]";
        }
    }
}
