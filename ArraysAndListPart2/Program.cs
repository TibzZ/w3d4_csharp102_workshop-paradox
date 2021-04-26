using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysAndListPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            //TASK 4 - Declare array and empty list 
            // int[] array5Multiple = new int[5] { 5, 10, 15, 20, 25 };
            int[] array5Multiple = {5,10,15,20,25};

            var listEmpty = new List<int>();

            foreach (int multiple in array5Multiple)
            {
                listEmpty.Add(multiple);
            }

            Console.Write($"EmptyList type:{listEmpty.GetType()} List of elements that filled listEmpty: ");
            foreach (int num in listEmpty)
            {
                Console.WriteLine(num);    
        
            }

            //Task 4 - Bonus task - Using Linq and .ToList to convert array to List
            List<int> array5MultipleLinq = array5Multiple.Select(num => num).ToList();

            Console.WriteLine("Bonus question, list elements: ");
            foreach(int multiple in array5MultipleLinq){
                Console.WriteLine($"{multiple}");
            }


        }
    }
}
