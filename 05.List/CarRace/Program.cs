using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            double sumLeft = 0;
            double sumRight = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                if (numbers[i] == 0)
                {
                    sumLeft -= sumLeft * 0.2;
                }
                else
                {
                    sumLeft += numbers[i];
                }

                if (numbers[numbers.Count - 1 - i] == 0)
                {
                    sumRight -= sumRight * 0.2;
                }
                else
                {
                    sumRight += numbers[numbers.Count - 1 - i];
                }
            }
            if (sumLeft < sumRight)
            {
                Console.WriteLine($"The winner is left with total time: {sumLeft}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumRight}");
            }
            
        }
    }
}
