using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzesterv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nev;
            double testsuly, edzesido, kaloria, teljeshetiedzes, kaloriaszoro;
            byte edzescelja, edzeserroseg;
            Console.Write("Adja meg a nevét: ");
            nev = Convert.ToString(Console.ReadLine());
            // ellenőrzés, idk hogy kéne
            Console.Write("Adja meg a testsúlyát 50-120 kg : ");
            testsuly = Convert.ToDouble(Console.ReadLine());
            if (testsuly < 50 || testsuly > 120) {
                Console.WriteLine("A megadott érték nem jó!");

            }
            Console.WriteLine("Mi az edzés célja? 1. Állóképesség fejlesztése \n 2. Izomtömeg növelése \n 3.Fogyás");
            edzescelja = Convert.ToByte(Console.ReadLine());
           
            switch (edzescelja) {

                case 1:
                    
                   edzesido = 45;
                    break;
                case 2:
                    edzesido = 60;
                    break;
                case 3:
                    edzesido = 30;
                    break;
                default:
                    Console.WriteLine("Érvénytelen érték!");
                    edzesido = 0;
                    break;
                
                    

            
            
            
            
            }




        }
    }
}
