using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok_2024_11_16_Szabó_Bence
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Dolgozo> dolgozok = new List<Dolgozo>();
                dolgozok = Irodai_dolgozo_generator(dolgozok, 5);
                dolgozok = Gyari_dolgozo_generator(dolgozok, 5);
                


                for (int i = 0; i < dolgozok.Count; i++)
                {
                    Console.WriteLine(dolgozok[i].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
            
            Console.ReadKey();
            /*
             Hibás pédlányokra példák 
            Név nem lehet ures nev
                 IrodaiDolgozo i3 = new IrodaiDolgozo("","Könyvelő");
            Név nem lehet ures
                 GyariDolgozo d3 = new GyariDolgozo("", 2);
            Nem lehet a muszakok száma nulla
                 GyariDolgozo d1 = new GyariDolgozo("Alma nemecsek", 0);
                 dolgozok.Add(d1);
            Nem lehet negativ a muszakok szama
            GyariDolgozo d2 = new GyariDolgozo("Körte nemecsek", -1);
                 dolgozok.Add(d2);
            
             
             */



        }

        static List<Dolgozo> Gyari_dolgozo_generator(List<Dolgozo> dolgozok,int db)
        {
            string[] nevek = new string[6] { "Alma Anna", "Alma Béla", "Alma Erika", "Alma Éva", "Szekeres Barnabás", "Kovács Tivadar" };
            Random r = new Random();
            for (int i = 0; i < db; i++)
            {
                int random = r.Next(1,4);
                if (random==1||random==3)
                {
                    GyariDolgozo d = new GyariDolgozo(nevek[r.Next(0,6)],random);
                    dolgozok.Add(d);
                }
                else
                {
                    GyariDolgozo d = new GyariDolgozo(nevek[r.Next(0, 6)], r.Next(100000,280000), "Éretségi", random);
                    dolgozok.Add(d);
                }

            }
            return dolgozok;
        }


        static List<Dolgozo> Irodai_dolgozo_generator(List<Dolgozo> dolgozok, int db)
        {
            string[] nevek = new string[6] { "Körte Elemér", "Körte Béla", "Körte Erika", "Szilva Szilvia", "Kovács Barnabás", "Szekeres Tivadar" };
            string[] poziciok = new string[3] { "Könyvelő", "pénzügyi szakember","Ügyvezető" };
            Random r = new Random();
            for (int i = 0; i < db; i++)
            {
                IrodaiDolgozo irodai = new IrodaiDolgozo(nevek[r.Next(0,6)],poziciok[r.Next(0,3)]);
                dolgozok.Add(irodai);
                

            }
            return dolgozok;
        }


    }
}
