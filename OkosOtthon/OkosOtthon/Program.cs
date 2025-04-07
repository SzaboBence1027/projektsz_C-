using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
    class Program
    {
        static void Main(string[] args)
        {
            IEszkoz homSzenzor = new HomerSzenzor();
            IEszkoz futesrendszer = new FutesRendszer("Ház Fűtésrendszer", 21, homSzenzor as HomerSzenzor);
            OkosOtthonController vezérlő = new OkosOtthonController();
            Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz,homSzenzor));
            vezérlő.ParancsVegrehajtó(Parancs.EszkozHozzaad,futesrendszer );
            Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz));
            vezérlő.ParancsVegrehajtó(Parancs.FutesBekapcsol);
            Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz));
            for (int i = 0; i < 10; i++)
            {
                vezérlő.ParancsVegrehajtó(Parancs.Frissit);
                Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz));
            }
            Console.WriteLine(vezérlő.ParancsVegrehajtó(Parancs.Statusz));

            Console.ReadKey();
          
        }
    }
}
