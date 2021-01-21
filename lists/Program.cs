using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "James", "Ben", "Liz" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

            var namesCapitals = new List<string> { "Chris", "Tao", "Tim" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            var index = names.IndexOf("Liz");
            Console.WriteLine($"Found Liz at {index}");

            var indexCapitals = namesCapitals.IndexOf("Bill");
            Console.WriteLine($"Found Bill at {indexCapitals}");

            names.Sort();
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }

        }
    }
}
