using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UnikaOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange mening: ");
            String sentence = Console.ReadLine();

            Regex antal = new Regex(@"(\w+|&)");
            MatchCollection match = antal.Matches(sentence.ToLower());
            string[] matches = new string[match.Count];
            int index = 0;

            foreach (Match ord in match)
            {
                matches[index++] = ord.ToString();
            }

            var list = new List<String> (matches);
            var sort = list.GroupBy(x => x)
                .Select(g => new { Value = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count);

            foreach (var x in sort)
            {
                Console.WriteLine("Ord: " + x.Value + ": Antal: " + x.Count);
            }

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}