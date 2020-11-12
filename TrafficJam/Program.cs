using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int passingCarsOnGreen = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string carBrand = Console.ReadLine();
            int counter = 0;

            while (carBrand != "end")
            {
                if (carBrand != "green")
                {
                    cars.Enqueue(carBrand);
                }
                else
                {
                    for (int i = 0; i < passingCarsOnGreen; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;

                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                carBrand = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
