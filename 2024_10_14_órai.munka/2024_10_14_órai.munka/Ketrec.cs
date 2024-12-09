using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_14_órai.munka
{
    class Ketrec
    {
        List<Allat> Allatok;
        public Ketrec()
        {
            Allatok = new List<Allat>();
                
        }
        public void Allathozzada(Allat allat)
        {
            this.Allatok.Add(allat);

        }
        public void KetrecKiir()
        {
            foreach (Allat allat in Allatok)
            {
                allat.allat_kiiras();
                
            }
        }
    }
}
