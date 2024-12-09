using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_21_oop
{
    class Pont2D
    {
        int x, y;


        public Pont2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get=>x; }
        public int Y { get=>y; }
        public void Kiir()
        {
            Console.WriteLine($"X :{x},Y :{y}");
        }
    }


  
}
