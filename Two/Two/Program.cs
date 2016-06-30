using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>();
            sequence = Fib(sequence);

            var sum = sequence.Where(n => n % 2 == 0).Sum();
            Debug.WriteLine(sum);
        }

        private static List<int> Fib(List<int> numbers)
        {
            const int MAX_VALUE = 4000000;

            if(numbers.Any() == false)
            {
                numbers.Add(1);
                numbers.Add(2);
            }

            var current = numbers.Last() + numbers.ElementAt(numbers.Count - 2);
            if(current >= MAX_VALUE)
            {
                return numbers;
            }

            numbers.Add(current);
            return Fib(numbers);
        }
    }
}
