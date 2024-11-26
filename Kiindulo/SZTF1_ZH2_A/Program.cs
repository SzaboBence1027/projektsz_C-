using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1_ZH2_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //példányosítás
            SorozatAdatbazis adatbazis = new SorozatAdatbazis("katalogus.txt");
            Console.WriteLine("Átlagos nézőszám"+adatbazis.AtlagNezoSzam+"Millió fő");
            Console.WriteLine("Legnézettebb epizód adatai:\n\t"+adatbazis.Legnezetteb().ToString());
            Console.WriteLine("Első és utolsó epizód között eltelt napok száma:"+adatbazis.Zoldijjasznapok()+"nap");
            Console.ReadKey();
        }
    }
}
