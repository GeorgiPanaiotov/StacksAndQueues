using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numberCalc = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                numberCalc.Push(numbers[i]);
            }

            List<string> commands = Console.ReadLine().Split().ToList();
            commands[0] = commands[0].ToLower();

            while (commands[0] != "end")
            {
                CalculationsRA add = new CalculationsRA();
                if (commands[0] == "add")
                {
                    add.Add(numberCalc , int.Parse(commands[1]), int.Parse(commands[2]));
                }
                else if (commands[0] == "remove" && int.Parse(commands[1]) <= numberCalc.Count)
                {
                    add.Remove(numberCalc, int.Parse(commands[1]));
                }
                commands.Clear();
                commands = Console.ReadLine().Split().ToList();
                commands[0] = commands[0].ToLower();
            }

            Console.WriteLine($"Sum: {numberCalc.Sum()}");
        }
    }
    public class CalculationsRA
    {
        public Stack<int> Add(Stack<int> numbers, int numberOne, int numberTwo)
        {
            numbers.Push(numberOne);
            numbers.Push(numberTwo);
            return numbers;
        }
        public Stack<int> Remove(Stack<int> numbers, int number)
        {
            for (int i = 0; i < number; i++)
            {
                numbers.Pop();
            }
            return numbers;
        }
    }
}
