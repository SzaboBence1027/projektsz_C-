using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._01._06_feladat
{
   abstract class Jarmu
    {
        string marka, tipus;
        int gyartasi_ev;

        public string Marka { get=>marka;  }
        public string Tipus { get => tipus; }
        public int Gyartasi_Ev { get => gyartasi_ev; }


        public Jarmu(string marka,string tipus,int gyartasi_ev)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.gyartasi_ev = gyartasi_ev;
        }
        public abstract bool UzembenVan();

        public override string ToString()
        {
            return $"Márak {this.marka} Tipus:{this.tipus} gyartasi ev: {this.gyartasi_ev} üzemben van {this.UzembenVan()} ";
        }
    }
}
