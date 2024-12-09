using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka_2024_11_04
{
    class csapat
        
    {
        játékos [] jatekosok;
        int jatekosok_szama;
        

        public csapat()
        {
            jatekosok = new játékos[6];
            jatekosok_szama = 0;
        }
        public bool megtelt()
        {
            if (jatekosok_szama==6)
            {
                return true;
            }
            return false;
        }
        public void Hozzaad(játékos j)
        {
            if (szerepelhet_e(j)&&!benne_van(j))
            {
                jatekosok[jatekosok_szama] = j;
                jatekosok_szama++;
            }
           
        }
        bool szerepelhet_e(játékos j)
        {
            int kapus = 1;
            int vedo = 2;
            int center = 2;
            int tamado = 2;
            for (int i = 0; i < jatekosok_szama; i++)
            {
                if (jatekosok[i].Poz==j.Poz)
                {
                    if (j.Poz==Pozicio.kapus)
                    {
                        kapus--;
                        if (kapus==0)
                        {
                            Console.WriteLine("Az adott pőozició már betelt");
                            return false;
                        }
                    }
                    else if(j.Poz==Pozicio.védő)
                    {
                        vedo--;
                        Console.WriteLine("Az adott pozició már betelt");
                        if (vedo == 0)
                        {
                            return false;
                        }
                    }
                    else if (j.Poz == Pozicio.center)
                    {
                        center--;
                        Console.WriteLine("Az adott pőozició már betelt");
                        if (center== 0)
                        {
                            return false;
                        }
                    }
                    else if (j.Poz == Pozicio.támadó)
                    {
                        tamado--;
                        Console.WriteLine("Az adott pőozició már betelt");
                        if (tamado == 0)
                        {
                            return false;
                        }
                    }
                    
                }
               
            }
            return true;
        }

       public  bool benne_van(játékos j)
        {
            for (int i = 0; i < jatekosok_szama; i++)
            {
                if (jatekosok[i].Equals(j))
                {
                    return true;
                }
            }
            
            return false;
        }

        public override string ToString()
        {
            string kiiras = "Csapat:\n";
            for (int i = 0; i < jatekosok_szama; i++)
            {
                kiiras += jatekosok[i].ToString();
            }
           
            return kiiras;
        }
    }
}
