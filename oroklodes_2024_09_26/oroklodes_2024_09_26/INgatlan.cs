using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oroklodes_2024_09_26
{
    class INgatlan
    {
        private int iranyar, telekmeret;
        protected string   tipus;
        private string cim;

        //jellemzőt, ami kivételt dob akkor, ha az ár kisebb mint 1000000 Ft
        public int Iranyar
        {
            get  //olvasáskor fut le, visszaad értéket
            { 
                return iranyar;
            }
            set //íráskor fut le, value paraméterben lesz az átadandó érték
            {
                if (value < 1000000)
                {
                    throw new Exception("Hibás ár!");
                }
                iranyar = value;
            }

        }
        public int Telekmeret
        {
            get { return telekmeret;
            }
            set
            {
                if (value < 10)
                {
                    throw new Exception("Túl kicsi a telekmeret");
                }
                telekmeret = value;
            }
        }
        public INgatlan(int iranyar, int telekmeret, string cim )
        {
            Iranyar = iranyar;
            this.cim = cim;
            Telekmeret = telekmeret;

           
            
        }

        public INgatlan(int telekmeret, string cim )
        {
            iranyar = 1000000;
            this.cim = cim;
            Telekmeret = telekmeret;
            
           
        }
        public override string ToString()
        {
            return cim+"-i,"+telekmeret+"m2-es,"+tipus+"eladó,"+iranyar+"Ft-ért";
        }
    }
    class Telek :INgatlan
    {
        public bool beepitheto_e { private get; set; }

       public Telek(string cim,int telekmeret,bool beepitheto_e,int negyzetmeterenki_ar):base(telekmeret*negyzetmeterenki_ar,telekmeret,cim)
        {
            this.beepitheto_e = beepitheto_e;
        }
    
    
    }
}
