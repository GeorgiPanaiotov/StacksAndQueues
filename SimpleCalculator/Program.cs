using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Reverse().ToArray();

            Stack<string> numbers = new Stack<string>(arr);

            while(numbers.Count > 1)
            {
                int first = int.Parse(numbers.Pop());
                string command = numbers.Pop();
                int second = int.Parse(numbers.Pop());

                if(command == "+")
                {
                    numbers.Push((first + second).ToString());
                }
                else if(command == "-")
                {
                    numbers.Push((first - second).ToString());
                }
            }
            Console.WriteLine(numbers.Pop());
        }
    }
}
