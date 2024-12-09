using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_14_órai.munka
{
    class Allat
    {
        int testömeg;
        string nev, nem, fajta;
        private List<string> betegségek;

        public Allat(string nev,string nem,string fajta,int testömeg)
        {
            this.nev = nev;
            this.nem = nem;
            this.fajta = fajta;
            this.testömeg = testömeg;
            this.betegségek = new List<string>();
        }

        public string Nev { get => nev; set {
                if (!string.IsNullOrEmpty(value))
                {
                    nev = value;
                }
                
            }  }

        public int Testömeg { get => testömeg; set
            {
                if (Math.Abs(this.testömeg-value) < 5)
                {
                    Testömeg = value;
                }
                else
                {
                    Console.WriteLine("Nem reális testömeg");
                }

            }
        }

        public void allat_kiiras()
        {
            Console.Write($"Állat neve: {nev}, neme: {nem}, fajtája: {fajta}, súlya: {testömeg} kg, Betegség neve:");
            foreach (var item in betegségek)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine();
        }
        public void Betegseghozzáad(string betegseg)
        {
            betegségek.Add(betegseg);
        }

    }
}
