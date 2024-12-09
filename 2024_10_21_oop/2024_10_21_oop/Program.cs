using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_21_oop
{
    class Program
    {
        static void Main(string[] args)
        {

            //1 feladat
            /*

             Pont2D elso_kordináták = new Pont2D(21,2);
             Pont2D masodik_kordinataok = new Pont2D(32,21);


             //Szakasz
             Szakasz elso_szakasz = new Szakasz(elso_kordináták,masodik_kordinataok);
             elso_szakasz.Kiir();

             */
            //2 feladat
            ElemN nyolc_hosszu = new ElemN(8);
            nyolc_hosszu.Elemfelvétel(5);
            nyolc_hosszu.Elemfelvétel(2);
            nyolc_hosszu.Elemfelvétel(4);
            nyolc_hosszu.Elemfelvétel(3);
            nyolc_hosszu.Elemfelvétel(12);
            nyolc_hosszu.Elemfelvétel(54);
            nyolc_hosszu.Elemfelvétel(76);
            nyolc_hosszu.Elemfelvétel(34);
            nyolc_hosszu.Elemfelvétel(32);
            nyolc_hosszu.Elemfelvétel(23);
            nyolc_hosszu.ElemCsere(0,1212);
            nyolc_hosszu.Elemlekeres(0);
            nyolc_hosszu.Elem_Benne_van_e(1212);



            nyolc_hosszu.Kiiro();
            Console.WriteLine();
            int[] t = { 2, 3, 4, 5, 6, 7, 8, 9 };
            ElemN n2 = new ElemN(t);
            n2.Kiiro();
            Console.WriteLine();
            nyolc_hosszu.Db_lekeres();
            Console.ReadKey();

        }
    }
}
