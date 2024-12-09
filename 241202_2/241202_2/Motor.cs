using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241202_2
{
    class Motor : IJarmu
    {
        int maxSebesseg;
        bool elinditva;
        int sebesseg;
        string nev;
        public string Nev 
        { get => nev; }

        public int Sebesseg 
        { get => sebesseg;}

        public Motor(string nev, 
            int maxSebesseg)
        {
            this.maxSebesseg = maxSebesseg;
            this.elinditva = false;
            this.nev = nev;
        }
        public void AlljMeg()
        {
            this.sebesseg = 0;
        }

        public void Gyorsit(int sebesseg)
        {
            if (elinditva)
            {
                this.sebesseg += sebesseg;
                if (this.sebesseg >
                    maxSebesseg)
                {
                    this.sebesseg =
                        maxSebesseg;
                }
            }
        }

        public void Indit()
        {
            this.elinditva = true;
        }

        public void Lassit(int sebesseg)
        {
            if (elinditva)
            {
                this.sebesseg -= sebesseg;
                if (this.sebesseg < 0)
                {
                    this.sebesseg = 0;
                }
            }
        }
    }
}
