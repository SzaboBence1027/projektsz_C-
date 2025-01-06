using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._06_feladat
{
    interface IBerelheto
    {
       bool Berelheto { get; set; }
        void Berel();
        void Visszavisz();
        int napiBerletiDij();
    }
}
