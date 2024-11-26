using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nobel_dij_2024_09_05
{
    class Program
    {
        static List<Szemely> lista = new List<Szemely>();
        static void Main(string[] args)
        {
            /*StreamReader sr = new StreamReader("orvosi_nobeldijak.txt");
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                lista.Add(new Szemely(sr.ReadLine()));
            }*/
            File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1).ToList().ForEach(item => lista.Add(new Szemely(item)));
            
            // 3 feladat
            Console.WriteLine($"3 feladat :Díjazottak száma: {lista.Count()} fő");
            //4 feladat
            Console.WriteLine($"4 feladat:Utolsó év: {lista.Max(x=>x.ev)}");
            Console.Write("5 feladat: Kérem adja meg egy ország kódját:");
            string orszagkods = Console.ReadLine();
            int db = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].orszagkod==orszagkods)
                {
                    db++;
                }
            }
            if (db==0)
            {
                Console.WriteLine("Az adott országból nem volt díjazott");
            }
            else if (db==1)
            {   
                Console.WriteLine($"Név: {lista.Where(x=>x.orszagkod==orszagkods).First().nev} \n\t   Év: {lista.Where(x => x.orszagkod == orszagkods).First().ev} \n \t SZ/H:{lista.Where(x => x.orszagkod == orszagkods).First().szuletes_halalozas} ");
            }
           





            //6 feldat
            Console.WriteLine("6 feladat statisztika");
            lista.GroupBy(x=>x.orszagkod).Where(x => x.Count()>5).ToList().ForEach(x=> Console.WriteLine( x.Key+" -  "+x.Count()));

            // 7 feladat
            /*
            float osszeletkor = 0;
            int ismert_elet_koruak_darabja = 0;
            foreach (var item in lista)
            {
                item.Elethossz();
                if (item.IsmertAzElethossz==true && item.ElethosszEvekben!=-1)
                {
                    osszeletkor += item.ElethosszEvekben;
                    ismert_elet_koruak_darabja++;
                }
            }
            Console.WriteLine($"7 feladat: A keresett átlag: {Math.Round( osszeletkor/ismert_elet_koruak_darabja,1)} év");*/
            //Console.WriteLine($"7 feladat: A keresett átlag: {Math.Round(lista.FindAll(item=>item.IsmertAzElethossz).Average(x=>x.ElethosszEvekben()),1 )}");
        }
    }
}
