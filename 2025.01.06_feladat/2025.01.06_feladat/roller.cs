using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._06_feladat
{
    class Roller:IBerelheto
    {
        bool elektromos;
        bool berelheto;
        Random rnd = new Random();
        public bool Elektromos { get => elektromos; }
        public bool Berelheto { get => berelheto; set => berelheto = value; }
      
        public Roller( bool elektromos) { 
            this.elektromos = elektromos;
            berelheto = true;
        }
        public void Berel()
        {
            if (!berelheto)
            {
                berelheto = true;
            }
            else
            {
                Console.WriteLine("A roller már ki van bérelve");
            }
        }

        public int napiBerletiDij()
        {
            return rnd.Next(2000, 16001);
        }

        public void Visszavisz()
        {
            if (berelheto == false)
            {
                Console.WriteLine("A Roller már vissza lett hozva");
            }
            berelheto = false;
        }
        public override string ToString()
        {
            string v = elektromos ? "elektromos" : "lábhajtású";
            return "A roller "+v+"Berelheto :"+berelheto;
        }
    }
}
