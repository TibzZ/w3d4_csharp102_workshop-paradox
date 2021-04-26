using System;
using System.Collections.Generic;
using System.Linq.Expressions; 

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // TASK 5 - Create a Fibonacci List
            List<int> FibonacciNos = new List<int>{1,1};
            
            
            // Create 20 iteration to add a new number following Fibonacci paradime
            for(int i = 0; i <= 20; i++)
            { 
                int lastElementFiboNo = FibonacciNos[FibonacciNos.Count -1];
                int penultimateFiboNo = FibonacciNos[FibonacciNos.Count -2];
                FibonacciNos.Add(penultimateFiboNo + lastElementFiboNo);
            }           
            
            //Display results 
            foreach(int fibNo in FibonacciNos)
            {
                Console.WriteLine(fibNo);
            }

            
        }
    }
}
