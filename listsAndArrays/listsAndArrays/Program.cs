using System;
using System.Collections.Generic;
using System.Linq;

namespace listsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int> { 1, 2, 3, 4, 5 };
            foreach (int number in numberList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(numberList.Count);

            int[] listToArray = new int[numberList.Count];
            listToArray = numberList.ToArray();
            Console.WriteLine(listToArray.GetType());

            int[] fiveTimesArray = { 5, 10, 15, 20, 25 };
            var fiveTimesList = new List<int>();

            for (int i = 0; i < fiveTimesArray.Length; i++)
            {
                fiveTimesList.Add(fiveTimesArray[i]);
            }

            foreach (int number in fiveTimesList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(fiveTimesList.GetType());

            List<int> testList = fiveTimesArray.ToList();

            foreach (int number in testList)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine(testList.GetType());
        }
    }
}
