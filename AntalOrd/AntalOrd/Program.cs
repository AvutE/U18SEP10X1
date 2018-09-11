using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AntalOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening: ");
            String mening = Console.ReadLine();

            Regex ord = new Regex(@"(\w+|&)");
            MatchCollection match = ord.Matches(mening);

            Console.WriteLine("Antalet ord i meningen: " + match.Count);

            foreach (Match antal in match)
            {
                Console.WriteLine(antal + " " + "(" + antal.Length + ")");
            }

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}