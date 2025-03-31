using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankRendszer
{
  public interface ISzamlaKezelo
    {
        int egyenleg { get; }

        void Befizet(int osszeg);
        void Kivesz(int osszeg);
        bool TranzakcioEloellenorzes(int osszeg);
    }
}
