using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string name = parts[0];
                if (parts.Length == 4)
                {
                    bool removed = guests.Remove(name);
                    if (!removed)
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
