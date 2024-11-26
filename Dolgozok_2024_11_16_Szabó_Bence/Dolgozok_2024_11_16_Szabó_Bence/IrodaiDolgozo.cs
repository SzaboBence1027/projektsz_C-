using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok_2024_11_16_Szabó_Bence
{
    class IrodaiDolgozo:Dolgozo
    {
        private string pozicio;

        public string Pozicio { get => pozicio; set => pozicio = value; }

        public IrodaiDolgozo(string nev, string pozicio):base(nev,250000,"Éretségi")
        {
            Pozicio = pozicio;
        }

        public override double Premium()
        {
            if (Pozicio== "pénzügyi szakember")
            {
                return Fizetes * 1.1;
            }
            return Fizetes;
        }
        public override string ToString()
        {
            Fizetes = Premium();
            return base.ToString()+$"Poziciója {Pozicio}";
        }
    }
}
