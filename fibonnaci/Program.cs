using System;
using System.Collections.Generic;

namespace fibonnaci
{
    class Program
    {
        static void Main(string[] args)
        {

            var fibonacciNos = new List<int> { 1, 1 };

            while (fibonacciNos.Count < 20)
            {

                var previous1 = fibonacciNos[fibonacciNos.Count - 1];
                var previous2 = fibonacciNos[fibonacciNos.Count - 2];

                fibonacciNos.Add(previous1 + previous2);

            }

            foreach (var number in fibonacciNos)
                Console.WriteLine(number);

        }

    }
}

