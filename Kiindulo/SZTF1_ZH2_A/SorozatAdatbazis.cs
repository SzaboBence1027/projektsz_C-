using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SZTF1_ZH2_A
{
    class SorozatAdatbazis
    {
        private Epizod[] epizodok;
        public double AtlagNezoSzam { get { return epizodok.Sum(x => x.NezoSzam) / Convert.ToDouble(epizodok.Length); } }
        

        public SorozatAdatbazis(string fajlNev)
        {
            FajlBeolvasas(fajlNev);
            Beallit();
            Mentes("KimentetAdatok.txt");

        }

       
        private void FajlBeolvasas(string fajlNev)
        {
            string[] readText = File.ReadAllLines(fajlNev);
           
            epizodok = new Epizod[readText.Length];
            for (int i = 0; i < readText.Length; i++)
            {
                Epizod ep = new Epizod(readText[i]);
                epizodok[i] = ep;
            }




        }
        void Beallit()
        {
            for (int i = 0; i < epizodok.Length-1; i++)
            {
                if (epizodok[i].EvadResz==1)
                {
                    epizodok[i].EpizodFajtaja = Epizod.EpizodFajta.evadnyito;
                }
                else if (epizodok[i].EvadResz>epizodok[i+1].EvadResz||i==epizodok.Length)
                {
                    epizodok[i].EpizodFajtaja = Epizod.EpizodFajta.evadzaro;
                }
                else
                {
                    epizodok[i].EpizodFajtaja = Epizod.EpizodFajta.normal;
                }
            }
        }

        public Epizod Legnezetteb()
        {
            double max_nezoszam = 0;
            int max_sorszam = 0;
            for (int i = 0; i < epizodok.Length; i++)
            {
                if (epizodok[i].NezoSzam>max_nezoszam)
                {
                    max_sorszam = i;
                    max_nezoszam = epizodok[i].NezoSzam;
                }
            }
            return epizodok[max_sorszam];
        }

        string[] nyitasiAdatok()
        {
            string[] visszaadotomb = new string[epizodok.Where(x=>x.EpizodFajtaja==Epizod.EpizodFajta.evadnyito).Count()];
            int viszadao_tomb_i = 0;
            for (int i = 0; i < epizodok.Length; i++)
            {
                if (epizodok[i].EpizodFajtaja==Epizod.EpizodFajta.evadnyito)
                {
                    visszaadotomb[viszadao_tomb_i] = epizodok[i].Evad+". évad: "+epizodok[i].Cim+"[ nézőszám: "+epizodok[i].NezoSzam+"M fő]";
                    viszadao_tomb_i++;
                }
                
            }
            return visszaadotomb;
        }
        void Mentes(string FileNEv)
        {
            StreamWriter sw = new StreamWriter(FileNEv);
            string[] kiirotomb = nyitasiAdatok();
            for (int i = 0; i <kiirotomb.Length; i++)
            {
                sw.WriteLine(kiirotomb[i]);
            }
            sw.Close();
        }

        /*public Rendező[] RendezokAdatai()
        {
            List<string> rendezo_nevek = new List<string>();
            for (int i = 0; i < epizodok.Count(); i++)
            {
                if (!rendezo_nevek.Contains(epizodok[i].Rendezo) )
                {
                    rendezo_nevek.Add(epizodok[i].Rendezo);
                }
            }
            Rendező[] rendezok = new Rendező[rendezo_nevek.Count()];

            for (int i = 0; i < rendezok.Length; i++)
            {
                Rendező r = new Rendező(epizodok.Distinct().Where(x=>x.Cim&&rendezo_nevek[i]));
            }

            
        }*/
        
        public int Zoldijjasznapok()
        {
            DateTime elso_ep = Convert.ToDateTime(epizodok[1].Premier);
            DateTime utolso_ep= Convert.ToDateTime(epizodok[epizodok.Length-1].Premier);
            return Convert.ToInt32((utolso_ep - elso_ep).TotalDays);
        }
    }
}
