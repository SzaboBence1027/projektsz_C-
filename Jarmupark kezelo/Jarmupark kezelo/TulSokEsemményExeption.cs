using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarmupark_kezelo
{
    class TulSokEsemményExeption:Exception
    {
        public TulSokEsemményExeption():base("Több esemény nem rögzíthető, Maximum 10 db ")
        {
           
        }
    }
}
