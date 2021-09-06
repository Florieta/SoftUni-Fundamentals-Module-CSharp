using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string line = Console.ReadLine();
           

            while (line != "End")
            {
                string[] parts = line.Split().ToArray();
                string command = parts[0];
                if (command == "Shoot")
                {
                    int index = int.Parse(parts[1]);
                    int power = int.Parse(parts[2]);
                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;
                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int index = int.Parse(parts[1]);
                    int value = int.Parse(parts[2]);
                    if (index >= 0 && index < line.Length)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int index = int.Parse(parts[1]);
                    int radius = int.Parse(parts[2]);
                    if(index - radius >= 0 && index + radius <= targets[targets.Count - 1])
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
                
                line = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join("|", targets));

        }
    }
}
