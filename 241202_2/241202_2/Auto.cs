using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_2
{
    class Auto : IJarmu
    {
        int maxSebesseg;

        int sebesseg;
        string nev;

        bool elinditva;
        public string Nev
        { get => nev; }

        public int Sebesseg 
        { get => sebesseg;  }

        public Auto(string nev, 
            int sebesseg)
        {
            this.nev = nev;
            this.elinditva = false;
            this.maxSebesseg = sebesseg;
        }

        public void AlljMeg()
        {
            if (elinditva)
            {
                this.sebesseg = 0;
            }
            Console.WriteLine("Megállt");
        }

        public void Gyorsit(int sebesseg)
        {
            if (elinditva)
            {
                if (this.sebesseg + sebesseg
                    > maxSebesseg)
                {
                    this.sebesseg = maxSebesseg;
                }
                else
                {
                    this.sebesseg += sebesseg;
                }
            }
            Console.WriteLine(this.sebesseg);
        }

        public void Indit()
        {
            this.elinditva = true;
            Console.WriteLine("Elinditva");
        }

        public void Lassit(int sebesseg)
        {
            if (elinditva)
            {
                if (this.sebesseg - sebesseg
                < 0)
                {
                    this.sebesseg = 0;
                }
                else
                {
                    this.sebesseg -= sebesseg;
                }
            }
            Console.WriteLine(this.sebesseg);
        }
    }
}
