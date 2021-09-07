using System;
using System.Collections.Generic;
using System.Linq;

namespace TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();

            string line = Console.ReadLine();

            while (line != "Yohoho!")
            {
                string[] parts = line.Split(" ");
                string command = parts[0];
                if (command == "Loot")
                {
                    for (int i = 1; i < parts.Length; i++)
                    {
                        if (!chest.Contains(parts[i]))
                        {
                            chest.Insert(0, parts[i]);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(parts[1]);
                    if (index >= 0 && index < chest.Count)
                    {
                        string removedItem = chest[index];
                        chest.RemoveAt(index);
                        chest.Add(removedItem);
                    }
                }
                else if (command == "Steal")
                {
                    List<string> steal = new List<string>();
                    int count = int.Parse(parts[1]);
                    if (count < chest.Count)
                    {
                        for (int i = chest.Count - count; i < chest.Count; i++)
                        {
                            steal.Add(chest[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));

                        chest.RemoveRange(chest.Count - count, count);
                    }

                    else
                    {
                        for (int i = 0; i < chest.Count; i++)
                        {
                            steal.Add(chest[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));

                        chest.RemoveRange(0, chest.Count);
                    }
                }
                line = Console.ReadLine();
            }
            if (chest.Count != 0)
            {

                double sum = 0;

                foreach (var item in chest)
                {
                    sum += item.Length;
                }

                double avg = sum / chest.Count;

                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
