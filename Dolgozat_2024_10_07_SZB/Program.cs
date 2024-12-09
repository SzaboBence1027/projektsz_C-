using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_SZB_10_07
{
    class Program
    {
        static bool A_feldat(int[] szamok)
        {
            bool duplikált = false;
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = 0; j < szamok.Length; j++)
                {
                    if (szamok[i]!=szamok[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
        }
    }
}
