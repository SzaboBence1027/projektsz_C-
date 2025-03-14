﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2024_12_09
{
    abstract class Szamla:ISzamla,IFizetesMod
    {
        string Szamla_tulajdonos;
        string Szamla_Szam;
        float egyenleg;


        public string Szamlaszam  { get => Szamla_Szam; }
        public string Tulajdonos { get => Szamla_tulajdonos; }
        public float Egyenleg { get => egyenleg; }


        public Szamla(string Szamla_tulajdonos,string Szamla_Szam,float egyenleg)
        {
            this.Szamla_tulajdonos = Szamla_tulajdonos;
            this.Szamla_Szam = Szamla_Szam;
            this.egyenleg = egyenleg;
        }

        public void Befizetes(float oszeg)
        {
            egyenleg += oszeg;
        }

        public void Kivonas(float osszeg)
        {
            if (this.egyenleg>=osszeg)
            {
                egyenleg -= osszeg;

            }
        }

        abstract public float KamatSzamitas();
        
        public float Koltseg(float osszeg)
        {

            if (Enum.Equals(Nev.Bankártya, "Bankártya"))
            {
                return osszeg * (float)0.3;
            }
            else if (Enum.Equals(Nev.Utalás, "Utalás"))
            {
                return osszeg * (float)0.6;
            }
            else return osszeg;
        }

    }
}
