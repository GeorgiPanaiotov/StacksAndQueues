using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();
            Queue<string> kids = new Queue<string>(names);
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            while (kids.Count > 1)
            {
                if (number == 1)
                {
                    while (kids.Count > 1)
                    {
                        Console.WriteLine($"Removed {kids.Dequeue()}");
                    }
                    break;
                }
                count++;
                if (count == number)
                {
                    Console.WriteLine($"Removed {kids.Dequeue()}");
                    count = 1;
                }
                string currentKid = kids.Dequeue();
                kids.Enqueue(currentKid);
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}
