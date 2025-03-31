using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BankRendszer
{
    class Program
    {
        static void Main(string[] args)
        {
            ISzamlaKezelo sz1 = new Szamla("Kovács Péter", 10000);
            ISzamlaKezelo sz2 = new Szamla("Nagy Anna", 2000);

           
            Console.WriteLine("-------Kezdeti Állapot--------");
            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());
            Console.WriteLine("--------Befizetés-----------");
            sz1.Befizet(2000);
            sz2.Befizet(4000);
            sz2.Befizet(4000);
            sz1.Befizet(3000);
            Console.WriteLine(sz1.ToString());
            Console.WriteLine(sz2.ToString());
            Console.WriteLine("---------Kivesz-----------");
            try
            {
                sz1.Kivesz(200);
                sz1.Kivesz(400);
                sz2.Kivesz(300);
                sz2.Kivesz(300);
                sz2.Kivesz(400000);
            }
            catch (NincsElégEgyelnelExeption e)
            {

                Console.WriteLine(e.Message);
            }
            finally {
                Console.WriteLine(sz1.ToString());
                Console.WriteLine(sz2.ToString());
            }

            List<Tranzakcio> tranzakciok = new List<Tranzakcio>();
            tranzakciok.Add(new Tranzakcio(sz1 as Szamla, sz2 as Szamla, 500));
           
            
            tranzakciok.Add(new Tranzakcio(sz1 as Szamla, sz2 as Szamla, 5000000));

            foreach (Tranzakcio item in tranzakciok)
            {
                try
                {
                    item.Vegrehajt();
                }
                catch (NincsElégEgyelnelExeption e)
                {
                    Console.WriteLine(item.ToString());
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    
                    Thread.Sleep(1000);
                }
             
            }
            
            
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("---------------------------");


            Console.ReadKey();

        }
    }
}
