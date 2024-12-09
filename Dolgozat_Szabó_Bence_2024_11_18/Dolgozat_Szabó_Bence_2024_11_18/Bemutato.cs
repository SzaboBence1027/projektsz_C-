using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_Szabó_Bence_2024_11_18
{
    class Bemutato
    {
        Allat[] allatok;
        int AllatokSzama;
        
        public Bemutato()
        {
            allatok = new Allat[6];
            AllatokSzama = 0;
            
        }
        public bool Megtelt()
        {
            if (AllatokSzama == 6)
            {
                return true;
            }
            return false;
        }

        public bool benne_van(Allat a)
        {
            for (int i = 0; i < AllatokSzama; i++)
            {
                if (allatok[i].Equals(a))
                {
                    return true;
                }
            }

            return false;
        }


        bool szerepelhet_e(Allat a)
        {
            int emlős = 1;
            int madár = 1;
            int hullő = 2;
            int hal = 2;
            
            for (int i = 0; i < AllatokSzama; i++)
            {
                if (allatok[i].Allat_Kategoria == a.Allat_Kategoria)
                {
                    if (a.Allat_Kategoria == kategoria.emlős)
                    {
                        emlős--;
                        if (emlős == 0)
                        {
                            Console.WriteLine("Már nem adhatő emlős a bemutatóhoz");
                            return false;
                        }
                    }
                    else if (a.Allat_Kategoria == kategoria.madár)
                    {
                        madár--;
                        
                        if (madár == 0)
                        {
                            Console.WriteLine("Már nem adahtó hozzá több madár");
                            return false;
                        }
                    }
                    else if (a.Allat_Kategoria == kategoria.hullő)
                    {
                        hullő--;
                        
                        if (hullő == 0)
                        {
                            Console.WriteLine("Nem adható hozzá több hüllő");
                            return false;
                        }
                    }
                    else if (a.Allat_Kategoria == kategoria.hal)
                    {
                        hal--;
                     
                        if (hal == 0)
                        {
                            Console.WriteLine("Nem adható hozzá több madár");
                            return false;
                        }
                    }

                }

            }
            return true;
        }

        public void Hozzáad(Allat a)
        {
            if (szerepelhet_e(a)&&!Megtelt())
            {
                allatok[AllatokSzama] = a;
                AllatokSzama++;
            }
        }

        public void Bemutato_Kiiras()
        {
            string kiiras = "Bemutato:\n";
            for (int i = 0; i < AllatokSzama; i++)
            {
                kiiras += allatok[i].ToString();
            }

            Console.WriteLine(kiiras);
        }
    }
}
