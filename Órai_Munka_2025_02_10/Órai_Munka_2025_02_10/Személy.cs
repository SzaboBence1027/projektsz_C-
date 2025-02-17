using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Órai_Munka_2025_02_10
{
    class Személy
    {
        string nev;
        int eletkor;
        int magassag;
        public Személy(string nev,int eletkor,int magassag)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.magassag = magassag;
        }

        public string Nev { get => nev;  }
        public int Eletkor { get => eletkor;  }
        public int Magassag { get => magassag; }

        public override string ToString()
        {
            return $"{Nev}";
        }
    }
}
