using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_21_oop
{
    class Szakasz
    {
        private Pont2D pont_1, pont_2;
        private double hossz;

        public Szakasz(Pont2D p1, Pont2D p2)
        {
            pont_1 = p1;
            pont_2 = p2;
            hossz = Hossz();
        }

        public void Kiir()
        {
            Console.WriteLine($"Szakasz pontjai:");
            pont_1.Kiir();
            pont_2.Kiir();
            Console.Write("Felkezőpontja:");
            Felezöpont().Kiir();
            Console.WriteLine("Hossza:"+hossz);
            
        }

        double Hossz()
        {
           return Math.Round(Math.Sqrt(Math.Pow((pont_2.X - pont_1.X), 2) + (pont_2.Y - pont_1.Y)),3);
           
        }
        Pont2D Felezöpont()
        {
            int felezo_x = pont_1.X - pont_2.X/2;
            int felezo_y = pont_1.Y - pont_2.Y/2;
            Pont2D felezopont = new Pont2D(felezo_x,felezo_y);

            return felezopont;
        }


    }
}
