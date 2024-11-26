using System;
using System.IO;
using System.Collections.Generic;

namespace Iroda_2024_10_24
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<Felhasznalo> lista = new List<Felhasznalo>()
            {  new Redszergazda("Géza", "geza"),
            new Ugyintezo("Klárika", "klarika", 3)
        };

            foreach (var item in lista)
            {
                if (item.Bejelentkezes("geza"))
                {
                    Console.WriteLine(item.Adatok());
                    Console.WriteLine(item.Kijelentkezes());
                }
                else
                {
                    Console.WriteLine("Sikertelen bejelentkezes a program leáll");
                    break;
                }
            }
          

           

            
           
            
              
            
            Console.ReadKey();
        }
    }
}
