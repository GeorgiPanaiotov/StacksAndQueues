using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Stack<char> textToChar = new Stack<char>();

            for (int i = 0; i < text.Length; i++)
            {
                textToChar.Push(text[i]);
            }

            for (int i = textToChar.Count; i > 0; i--)
            {
                Console.Write(textToChar.Pop());
            }
        }
    }
}
