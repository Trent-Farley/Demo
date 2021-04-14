using System.Collections.Generic;
using System;
using System.Linq;
using Refresh.Sort;

namespace Refresh
{
    /// <summary>
    /// How'd I create this summary? Just hit "/" button on your keyboard 3 times
    /// </summary>
    internal class Program
    {
        // TODO (Recommended tasks)
        /// <tasks>
        ///  1. Create a new class that does Insertion Sort (new -> file-> InsertionSort.cs)
        ///  2. Implement insertion sort with correct c# features
        ///     NOTABLE FEATURES TO IMPLEMENT
        ///         A. foreach loops when possible (if var i is not needed, use a foreach)
        ///         B. var instead of int/string/type
        ///         C. Use descriptive variable names when possible (if you don't understand whats
        ///         going on, that's ok, just try your best :) )
        ///         C. Use Linq statements to sort, Google search Linq statements or look at my demo below
        ///         D. For class properties type prop + tab + tab which will create a property quicker
        /// </tasks>

        private static void Main(string[] args)
        {
            //LinqStatements(); //Uncomment to run that function
            //TwoDList();
            //TwoDArray();

            //var library = new Library();

            //var book = library.Checkout("Pain", "Dr. Pain");
            //Console.WriteLine(book.ToString());
            var nodes = MakeNode();
            var sort = new InsertionSort(nodes);
            sort.Sort();
        }

        private static List<Node> MakeNode()
        {
            var nodes = new List<Node>();
            var random = new Random();
            var ints = Enumerable.Range(0, 20)
                .Select(i => random.Next(20))
                .ToList();
            foreach (var num in ints)
                nodes.Add(new Node
                {
                    Value = num
                });
            Console.WriteLine("Generated List");
            InsertionSort.PrintList(nodes);

            return nodes;
        }

        /// <summary>
        /// Demo of LINQ. Google linq for more info!
        /// </summary>
        private static void LinqStatements()
        {
            var random = new Random();
            var ints = Enumerable.Range(0, 20)
                .Select(i => random.Next(20))
                .ToList(); // Create a new list with random numbers 0-20.
            //Enumerable.Range(start, end) is a great way to create a list of numbers fast.
            PrintList(ints, "Unsorted list");

            //Let's sort that random list!

            var result = ints
                .OrderBy(i => i)
                .ToList();
            PrintList(result, "Sorted List");
            //easy right?
            //Let's grab all of the numbers bigger then 10

            var biggerThan10 = ints
                .Where(i => i > 10)
                .ToList();
            PrintList(biggerThan10, "Nums bigger then 10");

            //Reverse sort them?
            var reversed = biggerThan10
                .OrderByDescending(i => i)
                .ToList();
            PrintList(reversed, "Reversed bigger than 10");
        }

        private static void PrintList(List<int> nums, string title)
        {
            Console.WriteLine("`````````````````````````````````````````````````````");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"---------  {title}   --------------\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("[");
            foreach (var i in nums)
            {
                Console.Write($" {i} ");
            }
            Console.Write("]\n\n");
            Console.ResetColor();
            Console.WriteLine("`````````````````````````````````````````````````````");
        }

        /// <summary>
        /// Creates a 2d List based off a size
        /// </summary>
        /// <param name="size">The size of the list, else 10</param>
        /// <returns>A newed up 2 d list</returns>
        private static List<List<string>> TwoDList(int size = 10)//This is an "optional parameter"
        //Meaning if they don't provide it, then size will be 10.
        {
            var nums = new List<List<string>>();
            for (var i = 0; i < size; ++i)
            {
                nums.Add(new List<string>());
            }
            return nums;
        }

        /// <summary>
        /// Creates a 2d array
        /// </summary>
        /// <param name="size">The size of the array needed, else 10</param>
        /// <returns>A formed 2d array</returns>
        private static string[][] TwoDArray(int size = 10)
        {
            var twoDArray = new string[size][];
            for (var i = 0; i < twoDArray.Length; ++i)
            {
                twoDArray[i] = new string[size];
            }
            return twoDArray;
        }
    }
}