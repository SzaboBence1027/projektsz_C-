using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Öröklödes_pelda_2024_11_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Sikidom[] sikidomok = new Sikidom[10];

            sikidomok[0] = new Kor("Barna",1);

            sikidomok[1] = new Teglalap("kék",10,20);
            sikidomok[2] = new Negyzet("Kék",10,10);
            foreach (Sikidom sikidom  in sikidomok)
            {
                if (sikidom!=null)
                {
                    Console.WriteLine(sikidom.ToString());
                }
               
            }
            Sikidom legnagyobb = legnagyobb(sikidomok);
            Console.ReadKey();


        }
        public static Sikidom legnagyobb(Sikidom[] s)
        {
            double legnagyobb_terulet = -1;
            int legnagyobb_index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != null && s[i].Terulet() > s[legnagyobb_index].Terulet())
                {
                    legnagyobb_index = i;
                }
            }
            return s[legnagyobb_index];
        }
    }
}
