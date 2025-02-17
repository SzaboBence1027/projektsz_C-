using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka_2025_02_17
{
   public class Szemely
    {
        string nev, telefonszam;
        int eletkor;
        public Szemely(string nev, string telefonszam, int eletkor)
        {
            this.nev = nev;
            this.telefonszam = telefonszam;
            this.eletkor = eletkor;

        }
        public Szemely()
        {

        }
        public string Nev { get => nev; set => nev = value; }
        public string Telefonszam { get => telefonszam; set => telefonszam = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
    }
}
