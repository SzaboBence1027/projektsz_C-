using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_21_oop
{
    class ElemN
    {
        int[] tomb;
        int taroltDarab;
        public ElemN(int n)
        {
            tomb = new int[n];
            taroltDarab = 0;
        }
        public ElemN(int[] tomb)
        {
            this.tomb = tomb;
            taroltDarab = tomb.Length;
        }
        public void Kiiro()
        {
            Console.Write("A tömb elemei:");
            for (int i = 0; i <taroltDarab; i++)
            {
                Console.Write($"{tomb[i]},");
            }
        }
        public void Elemfelvétel(int szam)
        {
            if (taroltDarab>=tomb.Length)
            {
                Console.WriteLine("tároló megtelt");
            }
            else
            {
                if (!Benne_van_e(szam))
                {
                    this.tomb[taroltDarab] = szam;
                    taroltDarab++;
                    Console.WriteLine($"Sikeres adatfelvétel({szam})");
                }
            }
            
           
        }
        bool Benne_van_e(int szam)
        {
            for (int i = 0; i < taroltDarab; i++)
            {
                if (szam == tomb[i])
                {
                    Console.WriteLine("A szám már benne van a tárolóban");
                    return true;
                }
            }
            
            return false;
        }
        bool Van_e_ilyen_index(int elemhely)
        {
            if (elemhely > taroltDarab)
            {
                Console.WriteLine("Ezt az elemet nem lehet kicserélni mivel még nem lett felvéve");
                return false;
            }
            return true;

        }
        public void ElemCsere(int elemhely, int szam)
        {
            if (!Benne_van_e(szam)&&Van_e_ilyen_index(elemhely))
            {
                tomb[elemhely] = szam;
                Console.WriteLine($"Sikeres csere a(z){elemhely} indexen({szam})");
            }
        }
        public void Elemlekeres(int index)
        {
            if (index<taroltDarab)
            {
                Console.WriteLine("Az indexen lévő szám "+tomb[index]);
            }
            else
            {
                Console.WriteLine("Ezen az indexen nem tárolunk indexet");
            }
        }
        public void Elem_Benne_van_e(int szam)
        {
            if (!Benne_van_e(szam))
            {
                Console.WriteLine("Nincs benne a szám a tömben");
            }
        }
        public void Db_lekeres()
        {
            Console.WriteLine("A tömb elemeinek száma:"+taroltDarab);
        }
    }
}
