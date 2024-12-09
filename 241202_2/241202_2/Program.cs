using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IJarmu a = 
                new Auto("Citroen", 180);
            IJarmu m =
                new Motor("Mercedes", 120);

            IJarmu[] jarmuvek =
                new IJarmu[2];
            jarmuvek[0] = a;
            jarmuvek[1] = m;

            foreach (IJarmu jarmu
                in jarmuvek)
            {
                jarmu.Indit();
                for (int i = 0; i < 50; i++)
                {
                    jarmu.Gyorsit(10);
                }
                for (int i = 0; i < 50; i++)
                {
                    jarmu.Lassit(40);
                }
                jarmu.AlljMeg();
            }           
        }
    }
}
