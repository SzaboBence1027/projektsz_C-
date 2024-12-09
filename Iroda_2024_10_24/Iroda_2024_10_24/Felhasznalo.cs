using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iroda_2024_10_24
{
    class Felhasznalo
    {
        protected string jelszo, munkakor;
        protected bool bejelentkezes;

        public string nev { get; private set; }
        public Felhasznalo(string nev, string jelszo)
        {
            this.nev = nev;
            this.jelszo = jelszo;
            bejelentkezes = false;
        }

         public virtual string Adatok()
        {
            return $"Felhasznalo neve:{nev},munkakör:{munkakor }\n Bejelentkezve:{(bejelentkezes? "Igen ":"Nem")}";
        }
        public bool Bejelentkezes(string jelszo)
        {
           
          if (!bejelentkezes&&this.jelszo==jelszo)
                {
                bejelentkezes = true;
                    return true;
                }
            return false;
            
        }
        public string Kijelentkezes()
        {
            if (bejelentkezes==false)
            {
                return "A felhasználó nincs bejelentkezve";
            }
            bejelentkezes = false;
            return "Sikeres kijelentkezés";
        }
        public string MunkakorLekerdez()
        {
            return munkakor;
        }

    }
}
