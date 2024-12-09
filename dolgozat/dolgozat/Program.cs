using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dolgozat
{
    class Program
    {
        static bool A_feldat(int[] szamok)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = i + 1; j < szamok.Length; j++)
                {
                    if (szamok[i] == szamok[j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static int[] B_feladat(int min, int max) {
            int[] tomb = new int[5];
            Random r = new Random();
            for (int i = 0; i < tomb.Length; i++)
            {
                tomb[i] = r.Next(min, max);
            }
            return tomb;
        }
        static int paros(int[] szamok) {
            int db_paros = 0;
            for (int i = 0; i <szamok.Length; i++)
            {
                if (szamok[i]%2==0)
                {
                    db_paros++;
                }
            }
            return db_paros;
        }
       static int primszam(int[] szamok) {
            int primszam_db = 0;
            bool primszam = true;
            for (int i = 0; i < szamok.Length; i++)
            {
                primszam = true;
                if (szamok[i] == 0 ||szamok[i] == 1)
                {
                    primszam= false;
                }
                else {
                    for (int j = 2; j <= szamok[i]/2 ; j++)
                    {
                        if (szamok[i]%j == 0)
                        {
                           primszam=false;
                        }
                    }
                    
                }
               
                if (primszam==true)
                {
                    primszam_db++;
                }


            }
            return primszam_db;
                }

        static bool D_feladat(int[] random_szam_tomb)
        {
            for (int i = 0; i < random_szam_tomb.Length; i++)
            {
                for (int j =i+ 1; j < random_szam_tomb.Length; j++)
                {
                    if (random_szam_tomb[i] == random_szam_tomb[j])
                    {
                        return true;
                    }
                }
            }
            return false;

        }
        static int E_feladat(int[] tippek, int[] kihuzot) {
            int eltalalt_db = 0;
            for (int i = 0; i < tippek.Length; i++)
            {
                if (kihuzot.Contains(tippek[i]))
                {
                    eltalalt_db++;
                }
            }
            return eltalalt_db;
        }

        static void Main(string[] args)
        {
            int[] tomb = new int[5];
           
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Adja meg az "+(i+1)+" megjátszott számot");
                tomb[i]=Convert.ToInt32( Console.ReadLine());
            }
            Console.WriteLine(A_feldat(tomb)?"Vannak azonos számok":"");
            int[] r_szamok = B_feladat(1, 91);
            //for (int i = 0; i < r_szamok.Length; i++)
            //{
            //    Console.WriteLine(r_szamok[i]);
            //}
            Console.WriteLine($"párosok száma {paros(r_szamok)} prímszámok száma:{primszam(r_szamok)}");

            Console.WriteLine(D_feladat(r_szamok) ? "Vannak azonos számok a kihúzott számok között" : "");
            Console.WriteLine($"A felhasználó {E_feladat(tomb,r_szamok)} számot talált ki a kihúzott számok közül");
            
           

           

           
            Console.ReadKey();
        }
        
    }
}
