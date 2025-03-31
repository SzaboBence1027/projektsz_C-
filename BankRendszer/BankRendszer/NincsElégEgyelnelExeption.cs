using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRendszer
{
    class NincsElégEgyelnelExeption:Exception
    {
        public NincsElégEgyelnelExeption(Szamla sz):base($"A {sz.ToString()} számlán nincs elég egyenleg. A tranzakcio nem sikerult")
        {

        }
    }
}
