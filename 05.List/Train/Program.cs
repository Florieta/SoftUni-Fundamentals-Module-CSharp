using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                if (parts.Length == 2)
                {
                    int passengers = int.Parse(parts[1]);
                    train.Add(passengers);
                }
                else
                {
                    int passengers = int.Parse(parts[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        int currentWagon = train[i];
                        if (currentWagon + passengers <= maxCapacity)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", train));
        }
    }
}
