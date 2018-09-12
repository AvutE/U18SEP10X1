using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetSpeak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in mening: ");
            String sentence = Console.ReadLine().ToUpper();

            Dictionary<string, string> leet = new Dictionary<string, string>();

            leet.Add("A", @"/-\");
            leet.Add("B", @"|3");
            leet.Add("C", @"(");
            leet.Add("D", @"|)");
            leet.Add("E", @"3");
            leet.Add("F", @"|=");
            leet.Add("G", @"(");
            leet.Add("H", @"|-|");
            leet.Add("I", @"l");
            leet.Add("J", @"    _|");
            leet.Add("K", @"|<");
            leet.Add("L", @"|_");
            leet.Add("M", @"|\/|");
            leet.Add("N", @"|\|");
            leet.Add("O", @"0");
            leet.Add("P", @"|2");
            leet.Add("Q", @"(,)");
            leet.Add("R", @"|2");
            leet.Add("S", @"5");
            leet.Add("T", @"+");
            leet.Add("U", @"|_|");
            leet.Add("V", @"    |/");
            leet.Add("W", @"\/\/");
            leet.Add("X", @"><");
            leet.Add("Y", @"`/");
            leet.Add("Z", @"2");

            foreach(KeyValuePair<string, string> x in leet)
            {
                sentence = sentence.Replace(x.Key, x.Value);
            }

            Console.WriteLine("Din mening i leet blir: " + sentence);

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}