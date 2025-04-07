using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkosOtthon
{
   public enum Parancs
    {
        FutesBekapcsol, Frissit, Statusz, EszkozHozzaad
    }
  public  class OkosOtthonController
    {
        ObservableCollection<IEszkoz> eszkozok;


        public OkosOtthonController()
        {
            this.eszkozok = new ObservableCollection<IEszkoz>();


        }

        bool EszkozHozzaadas(IEszkoz eszkoz)
        {
            if (eszkoz == null) return false;

            this.eszkozok.Add(eszkoz);
            return true;
        }

        void FrissitEszkozok()
        {
            foreach (IEszkoz eszkoz in eszkozok)
            {
                eszkoz.Frissit();
            }
        }


        string StatuszJelentes()
        {
            string kiiro = "******************************************";

            foreach (IEszkoz eszkoz in eszkozok)
            {
                kiiro += eszkoz.ToString() + "\n";
            }
            kiiro += " ******************************************";
            return kiiro;
        }

        bool FutesBekapcsol(IEszkoz eszkoz)
        {

            if (eszkoz == null || !(eszkoz is FutesRendszer)) return false;

            eszkoz.Bekapcsol();
            return true;
        }

        public string ParancsVegrehajtó(Parancs parancs, IEszkoz pEszkoz = null)
        {
            switch (parancs)
            {
                case Parancs.FutesBekapcsol:
                    if (FutesBekapcsol(pEszkoz))
                        return "Fűtés bekapcsolva";
                    return "Fűtés  bekapcsolása nem sikerült";


                case Parancs.Frissit:
                    FrissitEszkozok();
                    return "Eszközök frissitve";

                case Parancs.Statusz:
                    return StatuszJelentes();

                case Parancs.EszkozHozzaad:

                    if (EszkozHozzaadas(pEszkoz)) return "Eszköz hozzáadva";
                    return "Eszköz hozzáadása nem sikerült";


                default:
                    return "Ismeretlen parancs!";
            }
        }

    }
}
