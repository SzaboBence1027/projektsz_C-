using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2025._01._06_feladat { 

    class Auto : Jarmu, IBerelheto

    {

        bool berelve;
        int ajtokSzama;
        bool elektromos;

        public bool Berelheto { get => berelve; set => berelve = value; }
        public int AjtokSzama { get => ajtokSzama; set => ajtokSzama = value; }
        public bool Elektromos { get => elektromos; set => elektromos = value; }

        public Auto(string marka,string tipus,int gyartasi_ev,int ajtokszama,bool elektromos):base(marka,tipus,gyartasi_ev)
        {
            this.berelve = false;
            this.ajtokSzama = ajtokszama;
            this.elektromos = elektromos;

        }

        public void Berel()
        {
            if (!berelve)
            {
                berelve = true;
            }
            else
            {
                Console.WriteLine("Az autó már ki van bérelve");
            }
           
        }
        bool ModernAuto()
        {
            if (DateTime.Now.Year-this.Gyartasi_Ev<5 && this.elektromos)
            {
                return true;
            }
            return false;
        }

        public int napiBerletiDij()
        {
            return rnd.Next(2000, 16001);
        }

        public void Visszavisz()
        {
            if (berelve==false)
            {
                Console.WriteLine("Az autó már vissza lett hozva");
            }
            berelve = false;
        }
        public override bool UzembenVan()
        {
            if (DateTime.Now.Year-this.Gyartasi_Ev>15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string ToString()
        {
            return base.ToString()+$"Bérelve: {this.berelve},Ajtók száma:{this.ajtokSzama} elekromos{this.elektromos}Modern:{ModernAuto()} ";
        }
    }
}
