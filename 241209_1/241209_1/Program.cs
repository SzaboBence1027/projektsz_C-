using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241209_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Atutalas at = new Atutalas();

            Folyoszamla sz =
                new Folyoszamla("854356-3456654-5565333",
                "Kis Tibor", 40000);
            Console.WriteLine(sz.ToString());
            MegtakaritasiSzamla m =
                new MegtakaritasiSzamla("246557455-32432234-43664",
                "Toth Eszter", 23000);
            Console.WriteLine(m.ToString());
            Tranzakcio t = new Tranzakcio(sz, m, at, 10000);
            Console.WriteLine(t.ToString());
            t.Vegrehajt();

            Console.WriteLine(sz.ToString());
            Console.WriteLine(m.ToString());

            Console.ReadLine();
        }
    }
}
