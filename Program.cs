using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Linqqq!");
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> startsWithL = from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;

            foreach (string fruit in startsWithL) {
                Console.WriteLine($"{fruit}");
            }

            // var LFruits = from fruit in fruits ...
            // // Which of the following numbers are multiples of 4 or 6
            // List<int> numbers = new List<int>()
            // {
            //     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            // }

            // var fourSixMultiples = numbers.Where();

        }
    }

}

// XXXXXXXX

//         // Display each number that was the acceptable size
//         foreach (int c in idealSizes)
//         {
//             Console.WriteLine($"{c}");
//         }