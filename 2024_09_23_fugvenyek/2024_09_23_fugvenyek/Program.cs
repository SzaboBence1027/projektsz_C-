using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_09_23_fugvenyek
{
    class Program
    {
        static int[] GenerateArray(int db)
        {
            Random r = new Random();
            int[] tomb = new int[db];
            for (int i = 0; i < db; i++)
            {
                tomb[i] = r.Next(0, 1001);
            }
            return tomb;
        }
        static string OutArray(int[] tomb) {
            string kimenet = "";
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i%10==0&&i!=0)
                {
                    kimenet += "\n";
                }
                kimenet +=  tomb[i]+ "\t ";
            }
            return kimenet;
        }
        static void Main(string[] args)
        {
          
            int [] szamok= GenerateArray(100);
            
            Console.WriteLine(OutArray(szamok));


            Console.ReadKey();


        }
    }
}
