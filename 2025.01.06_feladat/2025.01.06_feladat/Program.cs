
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025._01._06_feladat
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Jarmu> jarmuvek = new List<Jarmu>();
            Auto auto = new Auto("Citroen", "Picasszo",2006,5,false);
            Motor motor = new Motor("Kawasaki", "Ninja", 2019, 1300);
            Bicikli bickili = new Bicikli("decatlon","Riverside",2016,false);
            jarmuvek.Add(auto);
            jarmuvek.Add(motor);
            jarmuvek.Add(bickili);
            foreach (var item in jarmuvek)
            {
                if (item is IBerelheto)
                {
                    (item as IBerelheto).Berel();
                    Console.WriteLine(item.ToString());
                }
            }
            foreach (var item in jarmuvek)
            {
                if (item is IBerelheto)
                {
                    (item as IBerelheto).Visszavisz();
                    Console.WriteLine(item.ToString());
                }
            }
            int osszBerletkoltseg = 0;
            /*for (int i = 0; i < jarmuvek.Count; i++)
            {
                if (jarmuvek[i]is IBerelheto)
                {
                    osszBerletkoltseg += (jarmuvek[i] as IBerelheto).napiBerletiDij();
                }
               
            }
            Console.WriteLine(osszBerletkoltseg);*/
            int uzemben_levo = 0;
            foreach (Jarmu j in jarmuvek)
            {
                if (j is IBerelheto && j.UzembenVan())
                {
                    uzemben_levo++;
                }
            }
            Console.WriteLine(uzemben_levo);
            Console.ReadKey();
        }


        
    }
}
