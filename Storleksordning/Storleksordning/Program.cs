using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Storleksordning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mening: ");
            String mening = Console.ReadLine();

            Regex antal = new Regex(@"(\w+|&)");
            MatchCollection match = antal.Matches(mening);
            string[] matches = new string[match.Count];
            int index = 0;

            foreach (Match ord in match)
            {
                matches[index++] = ord.ToString();
            }

            Array.Sort(matches, (x, y) => x.Length.CompareTo(y.Length));

            for (int i = matches.GetLowerBound(0) ; i <= matches.GetUpperBound(0) ; i++)
            {
                Console.WriteLine(matches[i]);
            }

            Console.WriteLine();

            for (int i = matches.GetUpperBound(0); i >= matches.GetLowerBound(0); i--)
            {
                string temp = matches[i];
                char[] arr = temp.ToCharArray();
                Array.Reverse(arr);
                string backwards = new string(arr);

                Console.WriteLine(backwards);
            }

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}   