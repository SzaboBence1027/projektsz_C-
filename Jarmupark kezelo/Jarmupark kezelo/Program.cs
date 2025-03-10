using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark_kezelo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jarmu> jarmuvek = new List<Jarmu>();
            Jarmu audi = new Auto("audi","Q3",2019,1032313123);
            Jarmu bmw = new Auto("BMW","M3",2024,10121324);

            jarmuvek.Add(audi);
            jarmuvek.Add(bmw);
            try
            {
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
                audi.EssemenyHozzadas("Tankolás");
             

            }
            catch (TulSokEsemményExeption e)
            {

                Console.WriteLine(e.Message);
            }

            Jarmu min = jarmuvek[0];
            for (int i = 0; i < jarmuvek.Count; i++)
            {
                if (min.Gyartasiev>jarmuvek[i].Gyartasiev)
                {
                    min = jarmuvek[i];
                }
            }

            Console.WriteLine(min.ToString());
            Console.WriteLine(min.EsemenyListazasa());
          
            
            Console.WriteLine(audi.EsemenyListazasa());

            Console.ReadKey();




        }
    }
}
