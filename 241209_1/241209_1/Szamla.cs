using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    abstract class Szamla : ISzamla
    {
        string szamlaszam;
        string tulajdonos;
        int egyenleg;

        public string Szamlaszam { get => szamlaszam; }
        public string Tulajdonos { get => tulajdonos; }
        public int Egyenleg { get => egyenleg; }

        public Szamla(string szamlaszam, string tulajdonos,
            int egyenleg)
        {
            this.szamlaszam = szamlaszam;
            this.tulajdonos = tulajdonos;
            this.egyenleg = egyenleg;
        }
        public void Befizetes(int osszeg)
        {
            this.egyenleg += osszeg;
        }

        abstract public int KamatSzamitas();

        public void Kivonas(int osszeg)
        {
            if (this.egyenleg >= osszeg)
            {
                this.egyenleg -= osszeg;
            }
            else
            {
                Console.WriteLine("Túl kevés az egyenleg!");
            }
        }
        public override string ToString()
        {
            return $"Számlaszám: {this.szamlaszam}, " +
                $"tulajdonos: {this.tulajdonos}, " +
                $"egyenleg: {this.egyenleg}\n";
        }
    }
}
