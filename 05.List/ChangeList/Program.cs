using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Delete")
                {
                    int element = int.Parse(parts[1]);
                    numbers.RemoveAll(n => n == element);
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(parts[1]);
                    int idx = int.Parse(parts[2]);
                    numbers.Insert(idx, element);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
