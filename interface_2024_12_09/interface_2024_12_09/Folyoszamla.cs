﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_2024_12_09
{
    class FolyoSzamla:Szamla
    {
        public FolyoSzamla(string szamlaszam,string tulajdonos,int egyenleg):base(szamlaszam,tulajdonos,egyenleg)
        {

        }

        public override float KamatSzamitas()
        {
          return this.Egyenleg * 0.003f;
        }
    }
}
