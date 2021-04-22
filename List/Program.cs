using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args){
        
            List<string> namesCoaches = new List<string>();
            namesCoaches.Add("James");
            namesCoaches.Add("Ben");
            namesCoaches.Add("Liz");
            namesCoaches.Add("Tao");
            namesCoaches.Add("Chris");
            Console.WriteLine("namesCoaches");
            namesCoaches.ForEach(name => Console.Write("{0}\t", name));
            
        }
    }
}
