using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_2024_11_18
{
    class Macska:Allat
    {

        public Macska(string nev,int kor,string szin,Nem nem):base(nev,kor,szin,nem)
        {

        }

            public override string HangotAd()
            {
                return "Miau";
            }
        
    }
}
