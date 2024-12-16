using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    class Tranzakcio : ITranzakcio
    {
        static Random rnd = new Random();
        string tranzakcioID;
        DateTime datum;
        ISzamla forrasSzamla;
        ISzamla celSzamla;
        IFizetesiMod fizetesiMod;
        int osszeg;
        public string TranzakcioID { get => tranzakcioID; }

        public DateTime Datum { get => datum; }

        public ISzamla ForrasSzamla { get => forrasSzamla; }

        public ISzamla CelSzamla { get => CelSzamla; }

        public IFizetesiMod FizetesiMod { get => fizetesiMod; }

        public int Osszeg { get => osszeg; }

        public Tranzakcio(ISzamla forrasSzamla,
            ISzamla celSzamla, IFizetesiMod fizetesiMod,
            int osszeg)
        {
            for (int i = 0; i < 10; i++)
            {
                this.tranzakcioID += rnd.Next(0, 10);
            }
            this.datum = DateTime.Now;
            this.forrasSzamla = forrasSzamla;
            this.celSzamla = celSzamla;
            this.fizetesiMod = fizetesiMod;
            this.osszeg = osszeg;
        }
        public void Vegrehajt()
        {
            if (this.forrasSzamla.Egyenleg >=
                (this.osszeg + 
                fizetesiMod.Koltseg(this.osszeg)))
            {
                forrasSzamla.Kivonas
                    (this.osszeg +
                    fizetesiMod.Koltseg(this.osszeg));
                celSzamla.Befizetes(this.osszeg);
            }
            else
            {
                Console.WriteLine("Nincs elegendő egyenleg" +
                    " a tranzakcióhoz a forrásszámlán.");
            }
        }
        public override string ToString()
        {
            return $"Id: {this.tranzakcioID}, " +
                $"fizetési mód: {this.fizetesiMod.Nev}, " +
                $"forrásszámla: {this.forrasSzamla.Szamlaszam}, " +
                $"célszámla: {this.celSzamla.Szamlaszam}, " +
                $"összeg: {this.osszeg}\n";
        }
    }
}
