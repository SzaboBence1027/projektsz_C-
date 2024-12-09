using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_10_14_órai.munka
{
    class Program
    {
        static void allat_kiiras(string nev,string nem,string fajta,int testsúly)
        {
            Console.WriteLine($"Állat neve: {nev} ,neme: {nem}, fajtája: {fajta}, súlya: {testsúly} kg");
        }
        static void Main(string[] args)
        {
            //List<string> ketrec_1 = new List<string>();
            //string allat1_nev = "Kormos";
            //string allat_1_nem = "him";
            //string allat_1_fajta = "kutya";
            //int alat_1_testsúly = 20;
            //allat_kiiras(allat1_nev, allat_1_nem, allat_1_fajta, alat_1_testsúly);
            //ketrec_1.Add(allat1_nev);
            //string allat_2_nev = "Mici";
            //string allat_2_nem = "nőstény";
            //string allat_2_fajta = "panda";
            //int alat_2_testsúly = 320;
            //ketrec_1.Add(allat_2_nev);
            //allat_kiiras(allat_2_nev, allat_2_nem, allat_2_fajta, alat_2_testsúly);

            Allat allat1 = new Allat("Kormos","hím","Kutya",20);
           
           
            allat1.Betegseghozzáad("Allergia");
            allat1.allat_kiiras();
            Allat allat2 = new Allat("Mici","nőstény","panda",320);
            allat2.Betegseghozzáad("Féreg");
            allat2.Betegseghozzáad("Allergia");
            allat2.allat_kiiras();
            allat2.Testömeg = 400;
            allat2.allat_kiiras();
            Allat allat3 = new Allat("Kajás", "hím", "kutya",40);
            allat3.Betegseghozzáad("bolhás");
            allat3.Betegseghozzáad("Allergia");
            allat3.allat_kiiras();

            Console.WriteLine("Ketrec lakói");
            Ketrec ketrec1 = new Ketrec();
            ketrec1.Allathozzada(allat1);
            ketrec1.Allathozzada(allat2);
            ketrec1.KetrecKiir();
            // 2 ketrec lakói
            Allat allat4 = new Allat("Nóri", "Hím", "nyúl", 4);
            allat1.Betegseghozzáad("Répa");
            Allat allat5= new Allat("Marcsi", "nőstény", "panda", 320);
            allat5.Betegseghozzáad("Répa");
            Allat allat6 = new Allat("Nándi", "Hím", "nyúl", 4);
            allat6.Betegseghozzáad("Penicilin");



            Ketrec ketrec2 = new Ketrec();
            ketrec2.Allathozzada(allat4);
            ketrec2.Allathozzada(allat5); 
            ketrec2.Allathozzada(allat6);
            Console.WriteLine("2 ketrec lakói:");
            ketrec2.KetrecKiir();

            Console.ReadKey();
        }
    }
}
