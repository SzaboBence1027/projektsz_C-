using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace orvosi_nobeldíjak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<nobel_dijazotak> nobel_dijasok = new List<nobel_dijazotak>();
            List<Elethossz> elethosszak = new List<Elethossz>();
            StreamReader sr = new StreamReader("orvosi_nobeldijak.txt");
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[]be_sor= sor.Split(';');
                nobel_dijasok.Add( new nobel_dijazotak(be_sor[0], be_sor[1], be_sor[2], be_sor[3]));

            }
            //3. feladat
            Console.WriteLine($"3. feladt: Díjazotak száma: {nobel_dijasok.Count()} fő");
            //4. feladat
            Console.WriteLine($"4 feladat: Utolsó év: {nobel_dijasok.OrderBy(x=>x.Év).Last().Év}");
            //5. feladat
            Console.WriteLine("5 feladat: Kérem adja meg egy ország kódját:");
            string orszag = Console.ReadLine();
            int db = 0;
            foreach (var item in nobel_dijasok)
            {
                if (item.Orszagkod == orszag)
                {
                    db++;
                }
            }
            if (db==1)
            {
                Console.WriteLine($"A megadott ország díjazotja \n \t Név: {nobel_dijasok.Where(x=>x.Orszagkod==orszag).Last().Név} \n \t   Év:{nobel_dijasok.Where(x => x.Orszagkod == orszag).Last().Év}  \n \t SZ/H:{nobel_dijasok.Where(x => x.Orszagkod == orszag).Last().Születés_halálozás}");
            }
            else if (db>1)
            {
                Console.WriteLine($"A megadott országból {db} díjazott volt");
            }
            else
            {
                Console.WriteLine($"A megadott országból nem volt díjazott");
            }

            //6. feladat
            //6. feladat
            Console.WriteLine("6 feladat: Statisztika:");
            nobel_dijasok.GroupBy(x => x.Orszagkod).Where(g => g.Count() > 5).ToList().ForEach(g => Console.WriteLine($"\t{g.Key} - {g.Count()} fő"));
            //7. feladat
            foreach (var item in nobel_dijasok)
            {
                elethosszak.Add(new Elethossz(item.Születés_halálozás));
            }
            Console.WriteLine($"7. feladat: Keresett átlag:{Math.Round(elethosszak.Where(x=>x.IsmertAzElethossz==true).Average(x=>x.ElethosszEvekben),1)} év");



            sr.Close();
            Console.ReadKey();
        }
    }
}
