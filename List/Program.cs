using System;
using System.Collections.Generic;

namespace ListTest
{
    class Program
    {
        static void Main(string[] args){
        
        // TASK 1
            // Create a list 
            var namesCoaches = new List<string> {"James","Ben","Liz","Tao","Chris"};
            
            //Add new member - always good to dream
            namesCoaches.Add("Tibz");
            
            //Return Count/Length of List
            Console.WriteLine(namesCoaches.Count);
            
            //Create foreach loop could also be done with for loop - and print names in List
            foreach(string name in namesCoaches)
            {
                Console.WriteLine($"Hello {name.ToUpperInvariant()} ");
            }
            
            // Return 2nd value from List
            Console.WriteLine($"Name in index n°2: {namesCoaches[2]} ♥️");

            // Search for a name in the List Contains
            string nameToSearch = "Tibz";
            Console.WriteLine($"Is {nameToSearch} listed in our list of names? {namesCoaches.Contains(nameToSearch)}");

            //Is Bob around?
            string theBob = "Bob";
            if(namesCoaches.Contains(theBob))
            {
              Console.WriteLine($"The list contains {theBob}");      
            } else Console.WriteLine($"Hum... no such name found, have you look behind you? 😁");

            //Two more additions to the list 
            namesCoaches.AddRange(new List<string>() {"Tim","Joe"});

            foreach(string name in namesCoaches){
                Console.Write($"{name} ");
            }
            Console.WriteLine(""); 

            //Final List Length
            Console.WriteLine($"Total length list {namesCoaches.Count}");





            // The struggles of the start
            // List<string> namesCoaches = new List<string>();
            // namesCoaches.Add("James");
            // namesCoaches.Add("Ben");
            // namesCoaches.Add("Liz");
            // namesCoaches.Add("Tao");
            // namesCoaches.Add("Chris");
            // Console.WriteLine(namesCoaches.Count);
            // namesCoaches.ForEach(name => Console.Write("{0}\t", name));
            
            // List<string> myList = new List<string>();
            // myList.Add("chocEarly");
            // myList.ForEach(item => Console.WriteLine("{0}\t",item));



        }
    }
}
