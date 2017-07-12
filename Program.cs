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

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            var numberSum = purchases.Sum(purchase => purchase);
            Console.WriteLine(numberSum);

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            var maxDouble = prices.Max();
            Console.WriteLine(maxDouble);

        // Partitioning Operations

            // //Store each number in the following List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            // // foreach (int number in ascendingNumbers) {
            // //     wheresSquaredo.Add(number);
            // //     double squareRoot = Math.Sqrt(number);
            // //     Console.WriteLine(squareRoot);
            // //     if (number%squareRoot == squareRoot) {
            // //         break;
            // //     }
            // // }

            // // Build a collection of customers who are millionaires
            // // Given the same customer set, display how many millionaires per bank.

            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            var millionaires = from customer in customers // can use var for linq statements in IEnumerable lists
                where customer.Balance >= 1000000
                select customer;

            foreach (var customer in millionaires)
            {
                Console.WriteLine($"{customer.Name} {customer.Balance}");
            }

            var millGroup = from millionaire in millionaires
                group millionaire by millionaire.Bank into taco
                select new { Bank = taco.Key, Customers = taco};

            var grouped = customers.Where(c => c.Balance >= 1000000) // what goes into grouped is millionaire customers
                .GroupBy(d => d.Bank);

            foreach (var potato in grouped)
            {
                Console.WriteLine($"{potato.Key} {potato.Count()}");

                foreach (var customer in potato) 
                {
                    Console.WriteLine($"   {customer.Name} {customer.Balance}");
                }
            }   

        }

        public class Customer
        {
            public string Name { get; set; }
            public double Balance { get; set; }
            public string Bank { get; set; }
        }

    }

}