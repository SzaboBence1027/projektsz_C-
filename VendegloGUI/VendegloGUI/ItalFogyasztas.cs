using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendegloGUI
{
    class ItalFogyasztas
    {
        string ItalNeve { get; }
        int mennyiseg { get; }
        public ItalFogyasztas(string ItalNeve,int mennyiseg)
        {
            this.ItalNeve = ItalNeve;
            this.mennyiseg = mennyiseg;
        }
    }
}
