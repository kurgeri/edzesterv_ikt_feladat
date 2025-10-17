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
           
            int helyesNev = 0;
            string nev;
            do
            {
                helyesNev = 0;
                Console.Write("Adja meg a nevét: ");
                nev = Convert.ToString(Console.ReadLine());
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
                if (helyesNev != 3)
                {
                    Console.WriteLine("A megadott név nem megfelelő!");
                } 
            }
            while (helyesNev != 3);

            
            double testsuly;
            do
            {
                Console.Write("Adja meg a testsúlyát 50-120 kg : ");
                testsuly = Convert.ToDouble(Console.ReadLine());

                if (testsuly > 120 || testsuly < 50)
                {
                    Console.WriteLine("A megadott érték helytelen!");
                }
            } while (testsuly > 120 || testsuly < 50);
         

            //2. feladat
           
            int edzescelja;
            string edzesceljaszoveg = "";

            do
            {
                Console.Write("Mi az edzés célja?\n 1. Állóképesség fejlesztése \n 2. Izomtömeg növelése \n 3.Fogyás\n :");
                edzescelja = Convert.ToInt32(Console.ReadLine());
                if (edzescelja < 1 || edzescelja > 3)
                {
                    Console.WriteLine("Érvénytelen érték");
                    edzesceljaszoveg = "Érvénytelen cél";
                }
            } while (edzescelja < 1 || edzescelja > 3 );



            double edzesido = 0;
            double kaloriaszorzo = 0;
            switch (edzescelja) {


                case 1:
                    edzesido = 45;
                    kaloriaszorzo = 0.12;
                    edzesceljaszoveg = "Állóképesség fejlesztése";

                    break;
                case 2:
                    edzesido = 60;
                    kaloriaszorzo = 0.10;
                    edzesceljaszoveg = "Izomtömeg növelése";
                    break;
                case 3:
                    edzesido = 30;
                    kaloriaszorzo = 0.15;
                    edzesceljaszoveg = "Fogyás";
                    break;
               
            }

            // 3.feladat 
            
            int edzesnap;
            do
            {
                Console.Write("Adja meg hány napot szeretne edzeni (1-7):");
                edzesnap = Convert.ToInt32(Console.ReadLine());
                if (edzesnap < 0 || edzesnap > 7)
                {
                    Console.WriteLine("A megadott érték helytelen!");
                }

            } while (edzesnap < 0 || edzesnap > 7 );
            int edzesero;
            do
            {
                Console.Write("Adjon meg egy erősségi szintet(1-5): ");
                edzesero = Convert.ToInt32(Console.ReadLine());
                if (edzesero < 0 || edzesero > 5)
                {
                    Console.WriteLine("A megadott érték helytelen!");
                }
            } while (edzesero < 0 || edzesero > 5);
            
          

            double edzesidonap = edzesido * (1 + 0.1 * edzesero);
            double teljesheti = edzesnap * edzesidonap;
            // 4. feladat

            double kaloria = testsuly * teljesheti * kaloriaszorzo;

            Console.WriteLine($"Név: {nev}\nCélja: {edzesceljaszoveg}\nHeti teljes edzésidő: {teljesheti} perc\nElégetett kalória: {kaloria} J ");
            

        }
    }
}
