using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTal
{
    class Program
    {
        static void Main(string[] args)
        {
           Random rand = new Random();
           int answer = rand.Next(1, 21+1);

            while (true)
            {
                Console.WriteLine("Gissa tal mellan 1-21!");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == answer)
                {
                    Console.WriteLine("Grattis!");

                    break;
                }
                else
                {
                    Console.WriteLine("Försök igen! ({0})" , answer);
                }
            }

            Console.WriteLine("\nKlicka på vilken knapp som helst för att avsluta!");
            Console.ReadKey();
        }
    }
}