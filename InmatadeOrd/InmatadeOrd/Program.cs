using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmatadeOrd
{
    class Program
    {
        static void Main(string[] args)
        {
            string whole = "";
            string input;

            while(true)
            {
                while (true)
                {
                    Console.WriteLine("Ange ett ord eller \"avsluta\" för att avsluta: ");
                    input = Console.ReadLine();

                    if (input == "")
                    {
                        Console.WriteLine("Skriv något!");
                    }
                    else
                    {
                        break;
                    }
                }
                if (input.ToLower() == "avsluta")
                {
                   break;
                }

                whole += " " + input.Trim();

                Console.WriteLine("Din mening just nu är:{0}" , whole);
            }
        }
    }
}