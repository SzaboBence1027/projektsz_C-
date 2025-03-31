using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Vendeglo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Etel> etelek = new List<Etel>();
            Random r = new Random();
            etelek.Add(new Etel("Somlói galuska", 500));
            etelek.Add(new Etel("pörkölt nokedlivel", 1500));
            etelek.Add(new Fogas(adagMeret.kicsi,"gomba leves", 1700));
            etelek.Add(new Fogas(adagMeret.extra,"gomba pörkölt", 2700));

            foreach (var item in etelek)
            {
                try
                {
                    for (int i = 0; i < 4; i++)
                    {
                        item.Ertekeles(r.Next(1,5));
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
               
            }

            for (int i = 0; i < etelek.Count; i++)
            {
                Console.WriteLine(etelek[i].ToString());
            }
            

            



            Console.ReadKey();
        }
    }
}
