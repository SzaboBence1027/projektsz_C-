using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_2024_11_18
{
    class Program
    {
        static void Main(string[] args)
        {

            Kutya k = new Kutya("Buksi",5,"fekete",Nem.hím,true);
            Macska m = new Macska("Cirmos",10,"szürke",Nem.nőstény);
          
            Console.WriteLine(m.HangotAd());
            Console.WriteLine(m.ToString());
            Console.WriteLine(k.HangotAd());
            Console.WriteLine(k.ToString());
            Console.ReadKey();
        }
    }
}
