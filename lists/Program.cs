using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "James", "Ben", "Liz", "Tao", "Chris" };

            Console.WriteLine(names.Count);

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name}!");
            }

            Console.WriteLine(names[2]);

            bool present = names.Contains("Bob");

            if (present)
            {
                Console.WriteLine("Name contains Bob");
            };
            Console.WriteLine("No Bob here!");

            names.Add("Tim");
            names.ForEach(Console.WriteLine);
            names.Insert(1, "Joe");
            Console.WriteLine();   //Blank Line

            names.ForEach(Console.WriteLine);
        }
    }
}
