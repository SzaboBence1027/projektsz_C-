using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _240930_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] szamok = GenerateArray(68);

            Console.WriteLine(OutArray(szamok));

            Console.ReadKey();
        }
        static int[] GenerateArray(int db)
        {
            int[] tomb = new int[db];
            Random rnd = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = rnd.Next(0, 1001);
            }
            return tomb;
        }
        static string OutArray(int[] t)
        {
            string szoveg = "";
            for (int i = 0; i < t.Length; i++)
            {
                szoveg += t[i] + "\t";
                if ((i + 1) % 10 == 0)
                {
                    szoveg += "\n";
                }
            }
            return szoveg;
        }
        static bool IsPrime(int num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static int NumOfPrimes(int[] t)
        {
            int primDb = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (IsPrime(t[i]))
                {
                    primDb++;
                }
            }
            return primDb;
        }
        static int GetMin(int[] t)
        {
            int minIndex = 0;//-1;
            int min = t[0];//int.MinValue;

            for (int i = 1; i < t.Length; i++)
            {
                if (t[i] < min)
                {
                    min = t[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        static int NumOdds(int[] t)
        {
            int paratlan = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] % 2 == 1)
                {
                    paratlan++;
                }
            }

            return paratlan;
        }
        static bool Exists(int[] t, int num)
        {
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] == num)
                {
                    return true;
                }
            }
            return false;
        }
        static bool IsRepetition(int[] t)
        {
            for (int i = 0; i < t.Length; i++)
            {
                for (int j = i + 1; j < t.Length; j++)
                {
                    if (t[i] == t[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
