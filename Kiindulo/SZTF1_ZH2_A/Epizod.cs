using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1_ZH2_A
{
    
    public class Epizod
    {
        public enum EpizodFajta //felsorolás típus
        {
            //értékek
            normal,
            evadnyito,
            evadzaro
        }

        public EpizodFajta EpizodFajtaja { get; set; } //EpizodFajtaja: felsorolás típusú jellemző
        public int Sorszam { get; set; }

        public int Evad { get; set; }

        public int EvadResz { get; set; }

        public string Cim { get; set; }

        public string Rendezo { get; set; }

        public string Premier { get; set; }

        public double NezoSzam { get; set; }

       
        //két konstruktor, paramétereikben különböznek
        public Epizod(string sor)
        {
           Sorszam=Convert.ToInt32( sor.Split('#')[0]);
           Evad= Convert.ToInt32(sor.Split('#')[1]);
           EvadResz=Convert.ToInt32(sor.Split('#')[2]);
            Cim = sor.Split('#')[3];
           Rendezo = sor.Split('#')[4];
           Premier = sor.Split('#')[5];
           NezoSzam =double.Parse( sor.Split('#')[6], CultureInfo.InvariantCulture) ;

        }

        public Epizod()
        {

        }
        public override string ToString()
        {
            string kiiras = $"Sorszam{Sorszam},Evad {Evad} Evadresz {EvadResz} cim {Cim} rendezo {Rendezo} premier {Premier} nezoszam {NezoSzam}";
            return kiiras;
        }
    }
}
