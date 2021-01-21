using System;
using System.Linq;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rainbow = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

            foreach (var colour in rainbow)
            {
                Console.WriteLine(colour.ToUpper());
            }

            string[] rainbowSong = { "Red", "Yellow", "Pink", "Green", "Purple", "Orange", "Blue" };

            var newRainbow = rainbowSong.Concat(rainbow);

            foreach (var colour in newRainbow)
            {
                Console.WriteLine(colour);
            }



        }
    }
}
