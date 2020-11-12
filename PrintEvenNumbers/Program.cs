using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> numbers = new Queue<int>(arr);

            while(numbers.Count > 0)
            {
                int number = numbers.Dequeue();
                if(numbers.Count == 0)
                {
                    Console.Write(number);
                }
                else if(number % 2 == 0)
                {
                    Console.Write(number + ", ");
                }
            }
        }
    }
}
