using System;
using System.Collections.Generic;
using System.Linq;

namespace Inventory03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine().Split(", ").ToList();

            string line = Console.ReadLine();

            while (line != "Craft!")
            {
                string[] parts = line.Split(" - ");
                string command = parts[0];
                if (command == "Collect")
                {
                    string item = parts[1];
                    if (!journal.Contains(item))
                    {
                        journal.Add(item);
                    }
                }
                else if (command == "Drop")
                {
                    string item = parts[1];
                    if (journal.Contains(item))
                    {
                        journal.Remove(item);
                    }
                }
                else if (command == "Combine Items")
                {
                    string[] tokens = parts[1].Split(":");
                    string oldItem = tokens[0];
                    string newItem = tokens[1];
                    if (journal.Contains(oldItem))
                    {
                        int index = journal.IndexOf(oldItem);
                        journal.Insert(index + 1, newItem);
                    }
                    else
                    {
                        break;
                    }
                }
                else if (command == "Renew")
                {
                    string item = parts[1];
                    journal.Remove(item);
                    journal.Add(item);
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
