using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Array 1
            string[] coloursRainbow = new string[7]{"red","orange","yellow","green","blue","indigo","violet"};

            foreach (string colour in coloursRainbow)
            {
                Console.WriteLine(colour);
            }

            //Array 2
            string[] colourSongUnsorted = new string[6] {"yellow", "pink", "green", "purple", "orange", "blue"};

            //To combine to arrays has to create a list?
            var myList = new List<string>();
            myList.AddRange(coloursRainbow);
            myList.AddRange(colourSongUnsorted);

            //Reconvert the list to an array
            string[] consolidatedArrayRainbow = myList.ToArray();

            foreach (string item in consolidatedArrayRainbow)
            {
                Console.WriteLine("Our results for the second array:")
                Console.WriteLine($"{item}");
            }

          

        } 

     }
}


