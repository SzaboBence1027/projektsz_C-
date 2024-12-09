using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class Program
    {
        static void Main(string[] args)
        {
            Terkep terkep = new Terkep(100, 25);
            Jarmu jramu = new Jarmu('*', 10, 10, terkep);
            //TerkepRajzolo rajzolo = new TerkepRajzolo(terkep);
            Szimulacio szimulacio = new Szimulacio(terkep,5);
            Helikopter h1 = new Helikopter(13,0,terkep,3,2);
            Auto A1 = new Auto('A',30, 0, terkep, 2, 1);
            Tank T1 = new Tank(31, 1, terkep, 2, 1);
            szimulacio.JarmuFelvetel(T1);
            szimulacio.JarmuFelvetel(h1);
            szimulacio.JarmuFelvetel(A1);
            szimulacio.Kirajzol();
            szimulacio.Fut();
            Console.ReadKey();
        }
    }
}
