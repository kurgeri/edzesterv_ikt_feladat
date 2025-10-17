using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzesterv
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. feladat
            double testsuly, kaloria, teljeshetiedzes, kaloriaszoro;
            byte edzescelja;
            int helyesNev = 0;
            do
            {
                helyesNev = 0;
                Console.Write("Adja meg a nevét: ");
                string nev = Convert.ToString(Console.ReadLine());
                if (nev[0].ToString() == nev[0].ToString().ToUpper())
                {
                    helyesNev++;
                }
                for (int i = 0; i < nev.Length; i++)
                {
                    if (nev[i] == ' ')
                    {
                        helyesNev++;
                        if (nev[i + 1].ToString() == nev[i + 1].ToString().ToUpper())
                        {
                            helyesNev++;
                        }

                    }

                }
            }
            while (helyesNev != 3);
            // ellenőrzés, idk hogy kéne
            Console.Write("Adja meg a testsúlyát 50-120 kg : ");
            testsuly = Convert.ToDouble(Console.ReadLine());
            if (testsuly < 50 || testsuly > 120) {
                Console.WriteLine("A megadott érték nem jó!");

            }

            //2. feladat
            Console.Write("Mi az edzés célja? 1. Állóképesség fejlesztése \n 2. Izomtömeg növelése \n 3.Fogyás");
            edzescelja = Convert.ToByte(Console.ReadLine());
            double edzesido = 0;
            switch (edzescelja) {

                default:
                Console.WriteLine("Érvénytelen érték!");
                break;
                case 1:
                    edzesido = 45;
                    break;
                case 2:
                    edzesido = 60;
                    break;
                case 3:
                    edzesido = 30;
                    break;
               
            }

            // 3.feladat 
            Console.Write("Adja meg hány napot szeretne edzeni (1-7):");
            byte edzesnap = Convert.ToByte(Console.ReadLine());
            Console.Write("Adjon meg egy erősségi szintet(1-5): ");
            byte edzesero = Convert.ToByte(Console.ReadLine());
            double edzesidonap = edzesido * (1 + 0.1 * edzesero);

            

        }
    }
}
