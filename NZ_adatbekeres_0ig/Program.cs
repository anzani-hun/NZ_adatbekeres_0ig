using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ_adatbekeres_0ig
{
    internal class Program
    {
        static void Main()
        {

            /* Készíts olyan konzolos alkalmazást, amely addig kér be adatokat, amíg nullát nem kap.
            '0' érték esetén kiírja az összes addig kapott szám összegét.  */


            double osszeg = 0;
            string szamBevitel;

            Console.WriteLine("Adj meg számokat! 0 érték bevitel esetén összeadja a már bevitt értékeket és program vége!");

            while (true)
            {
                Console.Write("Aktuális szám: ");
                szamBevitel = Console.ReadLine();

                // ha a bevitt érték nulla! akkor break
                if (szamBevitel == "0")
                {
                    break;
                }

                // a bevitt szöveget tryparszoljuk és hozzáadjuk az "összeg" értékhez.
                if (double.TryParse(szamBevitel, out double aktualisSzam))
                {
                    osszeg += aktualisSzam;
                }
                else
                {
                    Console.WriteLine("Nem jó a szám! Adj meg érvényes számot.");
                }

                Console.WriteLine($"eddigi számok összege: {osszeg}");
            }

            Console.WriteLine($"\nProgram vége! Az eddig bevitt számok összege: {osszeg}");
            Console.ReadKey();
        }
    }
}
