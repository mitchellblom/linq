using System;
using System.Linq;
using System.Collections.Generic;

namespace linq
{
    class Program
    {
        static void Main(string[] args)
        {

        // Restriction/Filtering Operations

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"};

            IEnumerable<string> startsWithL = from fruit in fruits
                where fruit.StartsWith("L")
                select fruit;

            foreach (string fruit in startsWithL) {
                Console.WriteLine($"{fruit}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var fourSixMultiples = numbers.Where(number => (number%4 == 0) || (number%6 == 0));

            foreach (int number in fourSixMultiples) {
                Console.WriteLine($"{number}");
            }

        // Ordering Operations

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre" 
            };

            var descendingNames = names.OrderByDescending(name => name);

            foreach (string name in descendingNames) {
                Console.WriteLine($"{name}");
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers1 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var ascendingNumbers = numbers1.OrderBy(number => number);

            foreach (int number in ascendingNumbers) {
                Console.WriteLine($"{number}");
            }

        // Aggregate Operators

            // Output how many numbers are in this list
            List<int> numbers2 = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var numberCount = numbers2.Count;
            Console.WriteLine(numberCount);

        }
    }

}