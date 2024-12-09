using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace órai_munka_2024_11_04
{
    class Program
    {
        
        static void Main(string[] args)
        {
            játékos jatekos = new játékos("Jákob",Pozicio.center);
            játékos jatekos_2 = new játékos("Sanyi", Pozicio.kapus);
            csapat cs = new csapat();
          
            Console.WriteLine(  cs.benne_van(jatekos));
            Console.WriteLine(cs.benne_van(jatekos));
            Console.WriteLine(cs.ToString());
            jatekos.Kiiro();
            játékos [] R_jatekosok = new játékos[20];
            R_jatekosok = RandomJatekosok(R_jatekosok.Length);
            while (!cs.megtelt())
            {
              

                Console.Clear();
                
                Console.WriteLine(cs.ToString());
                for (int i = 0; i < R_jatekosok.Length; i++)
                {
                    Console.Write(i + " " + R_jatekosok[i].ToString());
                }
                Console.WriteLine("Válasz játékost");
                int bekertJatekos = int.Parse(Console.ReadLine());
                cs.Hozzaad(R_jatekosok[bekertJatekos]);
               
            }
            Console.WriteLine("A kész csapat");
            Console.WriteLine(cs.ToString());
            Console.ReadKey();

        }
        static játékos[] RandomJatekosok(int db)
        {
            játékos[] jatekosok = new játékos[db];
            Random r = new Random();

            
            string[] keresztnév = new string[20] { "Sanyi", "Béla", "Matyi", "Dávid", "Ármin", "Martin", "Dani", "Péter", "Bence", "Marci", "Ádám", "Geri", "Ákos", "Zsombor", "Beni", "Csanád", "András", "Laci", "Levente", "Kristóf" };
            string[] vezeték = new string[20] { "Szabó", "Bányai", "Réti", "Huszár", "Beke", "Czipa", "Zsólyomi", "Roszoha", "Varga", "Németh", "Simon", "Szekeres", "Adácsi", "Kerpás", "Tóth", "Horgos", "Kővári", "Király", "Kukucska", "Török" };
            for (int i = 0; i < db; i++)
            {
                Pozicio p = (Pozicio)r.Next(0, 4);
                string nev =vezeték[r.Next(0,keresztnév.Length)]+" "+ keresztnév[r.Next(0,vezeték.Length)];
                jatekosok[i] = new játékos(nev, p);
            }
            return jatekosok;
           
        }
    }
}
