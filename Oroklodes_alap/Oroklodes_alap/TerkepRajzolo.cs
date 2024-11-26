using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oroklodes_alap
{
    class TerkepRajzolo
    {
        private readonly ConsoleColor[] MAGASSAG_SZINEK = {
            ConsoleColor.Blue, ConsoleColor.DarkGreen, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.DarkYellow, ConsoleColor.White, ConsoleColor.Gray
        };

        Terkep terkep;

        public TerkepRajzolo(Terkep terkep)
        {
            this.terkep = terkep;
        }

        protected virtual char MiVanItt(int x, int y)//a származtatott osztályban override-olni lehet, azaz utasításait feülírhatjuk
        {
            return ' ';
        }

        public void Kirajzol()
        {
            Console.SetCursorPosition(0,0);
            Console.ForegroundColor = ConsoleColor.Red;
            for (int y = 0; y < terkep.MeretY; y++)
            {
                for (int x = 0; x < terkep.MeretX; x++)
                {
                    float magassag = terkep.Magassag(x, y);
                    Console.BackgroundColor = MAGASSAG_SZINEK[Math.Min((int)Math.Ceiling(Math.Max(magassag, 0) * 5), MAGASSAG_SZINEK.Length - 1)];
                    Console.Write(MiVanItt(x, y));
                }
                Console.WriteLine();
            }
        }
    }
}
