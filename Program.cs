using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiune_haine
{
    class Program
    {
        public static List<Haine> toateHainele = new List<Haine>();
        public Haine getHaine(string nume)
        {
            using (StreamReader streamReader = new StreamReader("C:\\Users\\Andu\\source\\repos\\Proiect_3\\Gestiune.txt"))
            {
                string linieFisier;
                string[] linieSplit;
                var i = 1;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    linieSplit = linieFisier.Split(';');
                    if (linieSplit[1] == nume)
                    {
                        return new Haine(i, nume);
                    }
                    i++;
                }
            }
            return null;
        }

        static void Main()
        {
            Readfromfile(toateHainele);
            Boolean showMenu_ = true;
            while (showMenu_)
            {
                showMenu_ = showMenu();
            }
        }

        public static Boolean showMenu()
        {
            Console.WriteLine("--==Meniu gestiune magazin de haine==--");
            Console.WriteLine("1. Afiseaza hainele");
            Console.WriteLine("2. Adauga haine");
            Console.WriteLine("3. Modifica haine");
            Console.WriteLine("4. Sterge haine");
            Console.WriteLine("Alegeti o optiune: ");


            switch (Console.ReadLine())
            {
                case "1":

                    foreach (Haine hn in toateHainele)
                    {
                        //afiseaza toate hainele din fisier dupa ce au fost convertite in obiecte
                        Console.WriteLine(hn.ToString());
                    }
                    return true;

                case "2":
                    Console.WriteLine("Introduceti producatorul");
                    string producator = Console.ReadLine();
                    Console.WriteLine("Introduceti tipul de haine (vara/iarna)");
                    string tip = Console.ReadLine();
                    Console.WriteLine("Introduceti marime");
                    int marime = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduceti nr bucati");
                    int nrBucati = int.Parse(Console.ReadLine());
                    Console.WriteLine("Introduceti pret");
                    float pret = float.Parse(Console.ReadLine());

                    Haine haineNoi = new Haine(producator, tip,marime, nrBucati, pret);
                    toateHainele.Add(haineNoi);
                    Writetofile();

                    return true;
                case "3":
                    return true;
                case "4":
                    return true;
                default:
                    Console.WriteLine("Optiune incorecta!!!Alegeti o optiune din meniu: ");
                    return true;
            }

        }
        static void adaugaHaine(Haine haineDeAdaugat)
        {

        }
        static void Readfromfile(List<Haine> toateHainele)
        {
            string line;
            try
            {
             
                StreamReader sr = new StreamReader("C:\\Users\\Andu\\source\\repos\\Proiect_3\\Gestiune.txt");
               
                line = sr.ReadLine();
               
                while (line != null)
                {
                    string[] result = line.Split(',');
                    toateHainele.Add(new Haine(result[0], result[1], int.Parse(result[2]), int.Parse(result[3]), float.Parse(result[6])));
                     line = sr.ReadLine();
                }
                //close the file
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
        static void Writetofile()
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Andu\\source\\repos\\Proiect_3\\Gestiune.txt");
                
                foreach (Haine hn in toateHainele)
                {
                    sw.WriteLine(hn.ToFile());
                }

                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
