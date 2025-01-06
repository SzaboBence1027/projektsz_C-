using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._12._16_Dolgozat_Szabó.Bence
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Könyv
            Konyv k1 = new Konyv("Game of thrones", "J.R.R Martin", 2009, 700);
            k1.Kolcsonoz();
           
            Console.WriteLine(k1.ToString()) ;
            k1.Kolcsonoz();
            k1.Visszahoz();
            
            
            Console.WriteLine(k1.ToString());
            k1.Visszahoz();
            //DVD
            DVD d1 = new DVD("Dr.Zsivágó","Béla",1998);
            Console.WriteLine(d1.ToString());
            d1.Kolcsonoz();
            Console.WriteLine(d1.ToString());
            d1.Kolcsonoz();
            d1.Visszahoz();
            Console.WriteLine(d1.ToString());
            d1.Visszahoz();
            // Folyóirat
            Folyoirat f1 = new Folyoirat("Forbes","Máté",2024);
            Console.WriteLine(f1.ToString());
            Console.WriteLine();
            List<MediaElem> Mediak = new List<MediaElem>();
            Mediak.Add(k1);
            Mediak.Add(d1);
            Mediak.Add(f1);
            foreach (IKolcsonozheto item in Mediak)
            {
                if (item.Kolcsonozve==false)
                {
                    item.Kolcsonoz();
                }
                else
                {
                    Console.WriteLine("Nem lehet kikölcsönözni");
                }
                
            }
            foreach (IKolcsonozheto item in Mediak)
            {
                if (item.Kolcsonozve==true)
                {
                    item.Visszahoz();
                }
                Console.WriteLine("Már viussza lett hozva a könyv");
            }
            
            Console.ReadKey();
        }
       

    }
}
