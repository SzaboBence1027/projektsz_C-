using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok_2024_11_16_Szabó_Bence
{
    class GyariDolgozo:Dolgozo
    {
        private int Muszakokszama;

        public int MuszakokSzama { get => Muszakokszama; set {
                if (value<1)
                {
                    throw new Exception("A műszakok száma nem lehet negatív vagy nulla");
                }
                Muszakokszama = value;
            } 
        }

        public GyariDolgozo(string nev,int fizetes,string vegzeteseg,int muszakjai):base(nev,fizetes,vegzeteseg)
        {
            MuszakokSzama = muszakjai;
        }
        public GyariDolgozo(string nev,int muszakjai):base(nev,150000,"Nyolc Általános")
        {
            MuszakokSzama = muszakjai;
        }

        public override double Premium()
        {
            if (MuszakokSzama>=3)
            {
                return Fizetes * 1.05;
            }
            return Fizetes;
        }
        public override string ToString()
        {
            Fizetes =  Premium();
            return base.ToString()+$"Műszakok száma: {MuszakokSzama}";
        }
    }
}
