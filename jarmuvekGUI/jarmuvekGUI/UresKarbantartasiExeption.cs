using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jarmuvekGUI
{
    class UresKarbantartasiExeption:Exception
    {

        public UresKarbantartasiExeption():base("Üres karbantartási idő")
        {

        }
    }
}
