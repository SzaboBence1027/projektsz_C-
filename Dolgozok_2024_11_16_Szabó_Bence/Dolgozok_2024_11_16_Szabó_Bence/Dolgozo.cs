using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok_2024_11_16_Szabó_Bence
{
   abstract class Dolgozo
    {
        private string nev;
        private double fizetes;
        private string vegzeteseg;

        public string Nev { get => nev;

            set //íráskor fut le, value paraméterben lesz az átadandó érték
            {
                if (value!=""|| value.Trim().Contains(' '))
                {
                    nev = value;
                }
                else
                {
                    throw new Exception("A megadott név üres vagy hiányos (hiányzó vezetéknév vagy keresztnév)");
                }
               
            }
        }
        public double Fizetes
        {
            get => fizetes;
            set {
                if (value==0)
                {
                    throw new Exception("A fizetes nem lehet nulla");
                }
                else if (value<=-1)
                {
                    throw new Exception("Nem lehet negatív fizetes");
                }
                fizetes = value;
            }
        }

        public string Vegzeteseg { get => vegzeteseg; set => vegzeteseg = value; }


        public Dolgozo(string nev,int fizetes,string vegzetseg)
        {
            Nev = nev;
            Fizetes = fizetes;
            Vegzeteseg = vegzetseg;
        }
        public Dolgozo(string nev,string vegzetseg)
        {
            Nev = nev;
            this.fizetes = 100000;
            Vegzeteseg = vegzetseg;

        }


        abstract public double Premium();

        public override string ToString()
        {
            string kiiras = $"{Nev}, {Vegzeteseg} dolgozó,{Fizetes} havi fiztesert dolgozik, ";
            return kiiras;
        }

    }
}
