using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UnikBokstav
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange mening: ");
            String sentence = Console.ReadLine().ToLower();

            String[] words = sentence.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
            char[] characters = string.Join(string.Empty,words).ToCharArray();

            var character_Query = (from char ch in characters orderby ch select ch).Distinct();
            int count = character_Query.Count();
            char[] result = character_Query.ToArray();

            foreach(char ch in result)
            {
                int counting = sentence.Count(c => c == ch);
                Console.WriteLine(ch + " (" + counting + ")");

            }

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}