using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka_2024_11_04
{
    enum Pozicio
    {
        kapus,
        védő,
        center,
        támadó
    }
    class játékos
    {
        
        string nev;
        Pozicio poziciopoz;
        public játékos(string nev,Pozicio pozicio)
        {
            this.nev = nev;
            this.poziciopoz = pozicio;
        }
        public Pozicio Poz { get => poziciopoz; }


        public void Kiiro()
        {
            Console.WriteLine("Játékos neve:"+nev+", poziciója:"+poziciopoz);
        }
        public bool Egyezik_E(játékos j)
        {
            if (j.nev==this.nev &&j.poziciopoz==this.poziciopoz)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj is játékos)
            {
                játékos j = obj as játékos;
                if (j.nev == this.nev && j.poziciopoz == this.poziciopoz)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public override string ToString()
        {
            string kiiras = $"Név {nev} pozició {poziciopoz}\n";
            return kiiras;
        }
    }
}
