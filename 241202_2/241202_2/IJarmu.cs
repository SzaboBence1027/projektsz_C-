using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_2
{
    interface IJarmu
    {
        string Nev { get; }

        int Sebesseg { get; }

        void Indit();
        void AlljMeg();
        void Gyorsit(int sebesseg);
        void Lassit(int sebesseg);
    }
}
