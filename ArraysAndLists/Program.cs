using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of 5 num, console write it, return count
            var myNumList = new List<int>() { 1, 2, 3, 4, 5 };

            foreach (int num in myNumList)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"My List has {myNumList.Count} entries");


            //Create array with same number of element
            // BONUS can this be done without writing number?
            var ListToArray = myNumList.ToArray();   
            Console.Write($"My Array has {ListToArray.Length} elements: ");

            foreach(int num in ListToArray){
            //Console.Write($"{num}");
            Console.Write(string.Join(",",num));

            }

        }
    }
}
