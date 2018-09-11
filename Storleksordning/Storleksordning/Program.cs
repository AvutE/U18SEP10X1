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

            foreach (Match ord in match)
            {
                string[] matches = new string[match.Count];

                Array.Sort(matches, (x, y) => x.Length.CompareTo(y.Length));

                Console.WriteLine(ord);
            }

            char[] arr = mening.ToCharArray();
            Array.Reverse(arr);
            String backward = new string(arr);

            Console.WriteLine(backward);

            Console.ReadLine();
        }
    }
}