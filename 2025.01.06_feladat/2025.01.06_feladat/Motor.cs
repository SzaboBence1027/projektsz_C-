using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._06_feladat
{
    class Motor : Jarmu, IBerelheto
    {
        bool berelve;
        int hengerUrTartalom;

        public int HengerUrTartalom { get => hengerUrTartalom; set => hengerUrTartalom = value; }
        public bool Berelheto { get => berelve; set => berelve = value; }

        public Motor(string marka, string tipus, int gyartasi_ev,int hengerUrTartalom) : base(marka, tipus, gyartasi_ev)
        {
            this.berelve = false;
            this.hengerUrTartalom = hengerUrTartalom;
        }


        public void Berel()
        {
             if (!berelve)
            {
                berelve = true;
            }
            else
            {
                Console.WriteLine("Az Motor már ki van bérelve");
            }
        }

        public int napiBerletiDij()
        {
            return rnd.Next(2000, 16001);
        }

        public void Visszavisz()
        {
            if (berelve == false)
            {
                Console.WriteLine("Az autó már vissza lett hozva");
            }
            berelve = false;
        }
        public override bool UzembenVan()
        {
            if (DateTime.Now.Year - this.Gyartasi_Ev > 15)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool NagyTeljesítményu()
        {
            if (hengerUrTartalom>1000)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString()+$"Hengerűrtartalom:{this.hengerUrTartalom}, Nagyteljesítményű:{NagyTeljesítményu()},Berelheto:{berelve}";
        }
    }
}
