using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orvosi_nobeldíjak
{
    public class nobel_dijazotak
    {
        string év;
        string név;
        string születés_halálozás;
        string orszagkod;

        public nobel_dijazotak(string ev,string nev,string szul_hal,string Orszagkod)
        {
            this.év = ev;
            this.név = nev;
            this.születés_halálozás = szul_hal;
            this.orszagkod = Orszagkod;
        }

        public string Év { get => év;  }
        public string Név { get => név;  }
        public string Születés_halálozás { get => születés_halálozás;  }
        public string Orszagkod { get => orszagkod;  }
    }
}
