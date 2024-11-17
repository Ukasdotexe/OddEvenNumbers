using System;
using System.Collections.Generic;
using System.Linq;

namespace OddEvenNumbersApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            PrintNumbers("Numbers: ", numbers);
            PrintNumbers("Numbers: ", numbers.Where(n => n % 2 == 0));
            PrintNumbers("Numbers: ", numbers.Where(n => n % 2 != 0));
        }

        private static void PrintNumbers(string v, IEnumerable<int> numbers)
        {
            Console.WriteLine($" {v}  : ");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }
    }
}
