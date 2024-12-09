using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Dolgozat_Szabó_Bence_2024_11_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Allat[] R_allatok = new Allat[15];
            R_allatok = RandomAllatok(R_allatok.Length);
            Bemutato bemutato = new Bemutato();
            while (!bemutato.Megtelt())
            {
                Console.Clear();
                bemutato.Bemutato_Kiiras();
                for (int i = 0; i < R_allatok.Length; i++)
                {
                    if (!bemutato.benne_van(R_allatok[i]))
                    {
                        Console.Write(i + " " + R_allatok[i].ToString());
                    }
                   
                }
                Console.WriteLine("Válasz Állatot");
                int bekertAllat = int.Parse(Console.ReadLine());
                bemutato.Hozzáad(R_allatok[bekertAllat]);
            }
            Console.Clear();
            Console.WriteLine("Kész bemutató:");
            bemutato.Bemutato_Kiiras();
            Console.ReadKey();


        }

        static Allat[] RandomAllatok(int db)
        {
            Allat[] allatok = new Allat[db];
            Random R = new Random();

            string[] allatnevek = new string[20] { "Dárius", "Kancsi", "Ahri", "Béla", "Karcsi", "Sanyi", "Lehel", "Álmos", "Ádám", "Benő","Bárány","Bandi","Károly","Ferenc","Donáld","Éva","Vincze","Áron","Bulcsu","Lilla" };
            for (int i = 0; i < db; i++)
            {
                kategoria k = (kategoria)R.Next(0, 4);
                allatok[i] =new Allat (allatnevek[R.Next(0,allatnevek.Length)],k);
            }
            return allatok;
        }
    }
}
