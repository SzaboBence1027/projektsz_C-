using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nobel_dij_2024_09_05
{
    public class Szemely
    {
        public int ev;
        public string nev, szuletes_halalozas,orszagkod;
        private int Tol { get; set; }
        private  int Ig { get; set; }
        public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

        public bool IsmertAzElethossz => ElethosszEvekben != -1;

        public Szemely(string sor)
        {
            ev =Convert.ToInt32(sor.Split(";")[0]);
            nev= sor.Split(";")[1];
            szuletes_halalozas = sor.Split(";")[2];
            orszagkod = sor.Split(";")[3];
            
        }
       public void  Elethossz()
        {
            string[] m = szuletes_halalozas.Split('-');
            try
            {
                Tol = int.Parse(m[0]);
            }
            catch (Exception)
            {
                Tol = -1;
            }
            try
            {
                Ig = int.Parse(m[1]);
            }
            catch (Exception)
            {
                Ig = -1;
            }
        }
        

    }
}
