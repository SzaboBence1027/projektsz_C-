using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_2024_11_18
{
    
    class Kutya:Allat
    {
        
        bool ugatos;

        public bool Ugatos { get => ugatos;  }
        public Kutya(string nev,int kor,string szin,Nem nem,bool ugatos):base(nev,kor,szin,nem)
        {
            this.ugatos = ugatos;

        }
        public override string HangotAd()
        {
            return "VAU";
        }
        public override string ToString()
        {
            return base.ToString()+$", ugatos {this.ugatos }";
        }
    }
}
