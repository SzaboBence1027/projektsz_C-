using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketto_dimenzios_tomb_2024_09_23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  //inicializálás
              int[,] matrix = new int[4,5];
              Random r = new Random();

              Console.WriteLine("Autómata vagy Kézi feltoltés [A/K]");
              char Feltoltes_tipus = Convert.ToChar(Console.ReadLine());


              //A feladat
              if (Feltoltes_tipus == 'A')
              {
                  for (int i = 0; i < matrix.GetLength(0); i++)
                  {
                      for (int j = 0; j < matrix.GetLength(1); j++)
                      {
                          matrix[i, j] = r.Next(0, 11);
                      }
                  }
              }
              else {
                  Console.WriteLine("Adjon meg"+matrix.GetLength(0)*matrix.GetLength(1)+" db számot");
                  for (int i = 0; i < matrix.GetLength(0); i++)
                  {
                      for (int j = 0; j < matrix.GetLength(1); j++)
                      {
                          matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                          Console.Clear();
                      }
                  }
              }
              //b feladat
              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                  for (int j = 0; j < matrix.GetLength(1); j++)
                  {
                      Console.Write($" {matrix[i, j]}");

                  }
                  Console.WriteLine();
              }

              //c
              /*

              for (int i = 0; i < matrix.GetLength(0); i++)
              {
                  int db = 0;
                  for (int j = 0; j < matrix.GetLength(1); j++)
                  {

                      if (i == 0)
                      {
                          Console.WriteLine($"Pontyok száma {db}");
                      }
                      else if (i == 1)
                      {
                          Console.WriteLine($"Kárászok száma száma {db}");
                      }
                      else if (i == 2)
                      {
                          Console.WriteLine($"amúrok száma {db}");
                      }
                      else if (i == 3)
                      {
                          Console.WriteLine($"harcsák száma {db}");
                      }
                      else if (i == 4)
                      {
                          Console.WriteLine($"vöröszárnyúk  száma {db}");
                      }
                      db += matrix[i, j];
                  }


              }*/
            // Console.WriteLine($"Pontyok száma {ponty_db}\n kárászok száma {kárász_db}\n Amúrok száma {amúr_db} \n harcsák száma {harcsa_db} \n vöröszárnyúk száma {vöröszárnyú_db}");

            // d feladat
            /*
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int db = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    db += matrix[i, j];
                    
                    
                    
                }
                if (i == 0)
                {
                    Console.WriteLine($"Az {i}-dik horgász által fogott halak száma {db}");
                }
                else if (i == 1)
                {
                    Console.WriteLine($"Az {i}-dik horgász által fogott halak száma {db}");
                }
                else if (i == 2)
                {
                    Console.WriteLine($"Az {i}-dik horgász által fogott halak száma {db}");
                }
                else if (i == 3)
                {
                    Console.WriteLine($"Az {i}-dik horgász által fogott halak száma {db}");
                }

            }

            //e feladat

            bool volt_e_nulla = false;
            int nullas_sroszam = 0;/*
             for (int i = 0; i < matrix.GetLength(0); i++)
             {
                 int db = 0;
                 for (int j = 0; j < matrix.GetLength(1); j++)
                 {
                     db += matrix[i, j];



                 }
                 if (db==0)
                 {
                     volt_e_nulla = true;
                     nullas_sroszam = i;
                    break;
                 }


             }
             if (volt_e_nulla==true)
             {
                 Console.WriteLine($"Volt olyan horgász aki nem fogot egy halat se. A(z) {nullas_sroszam} számú ");
             }
             else
             {
                 Console.WriteLine("Minden horgász fogott legalább 1 halat");
             }
            
            *//*
            int seged = 0;
            while (seged<matrix.GetLength(0)&&volt_e_nulla!=true)
            {
                int db = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    db += matrix[seged, j];
                    


                }
                seged++;
                if (db == 0)
                {
                    volt_e_nulla = true;
                    
                }
            }

            if (volt_e_nulla == true)
            {
                Console.WriteLine($"Volt olyan horgász aki nem fogot egy halat se. A(z) {nullas_sroszam} számú ");
            }
            else
            {
                Console.WriteLine("Minden horgász fogott legalább 1 halat");
            }

            //f
            int nullas_horgasz = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int db = 0;
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    db = matrix[i, j];
                    
                    

                }
                if (db==0)
                {
                    nullas_horgasz++;
                }
            }
            Console.WriteLine($" {nullas_horgasz} horgász nem fogott halat");


            //g
            int legsikeresebb_horgász_sorszám = -1;
            int legnagyobb_db = -1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                int db = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    db += matrix[i, j];
                    
                }
                if (db > legnagyobb_db)
                {
                    legnagyobb_db = db;
                    
                    legsikeresebb_horgász_sorszám = i;
                }

            }
            Console.WriteLine($"A legsikeresebb horgász sorszáma a {legsikeresebb_horgász_sorszám} fogott halak száma {legnagyobb_db}");

            Console.ReadKey();*/

            
        }
    }
}
