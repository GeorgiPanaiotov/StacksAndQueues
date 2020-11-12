using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<int> positions = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '(')
                {
                    positions.Push(i);
                }
                if(text[i] == ')')
                {
                    int first = positions.Pop();
                    int lenght = Math.Abs(first - i);
                    Console.WriteLine(text.Substring(first, lenght + 1));
                }
            }
        }
    }
}
