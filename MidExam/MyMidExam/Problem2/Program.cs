using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "Report")
            {
                string[] parts = input.Split();
                string command = parts[0];
                if (command == "Blacklist")
                {
                    string name = parts[1];
                    if (list.Contains(name))
                    {
                        int index = list.IndexOf(name);
                        list[index] = "Blacklisted";
                        Console.WriteLine($"{name} was blacklisted.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} was not found.");
                    }
                }
                else if (command == "Error")
                {
                    int index = int.Parse(parts[1]);
                    if (index >= 0 && index < list.Count)
                    {
                        string username = list[index];
                        if (username != "Blacklisted" && username != "Lost")
                        {
                            string oldName = username;
                            list[index] = "Lost";
                            Console.WriteLine($"{oldName} was lost due to an error.");
                            
                        }
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(parts[1]);
                    string newName = parts[2];
                    if (index >= 0 && index < list.Count)
                    {
                        string currentName = list[index];
                        list.Remove(currentName);
                        list.Insert(index, newName);
                        Console.WriteLine($"{currentName} changed his username to {newName}.");
                    }
                }
                input = Console.ReadLine();
            }
            int countBlacklisted = 0;
            int countLost = 0;
            foreach (var item in list)
            {
                if (item == "Blacklisted")
                {
                    countBlacklisted++;
                }
                if (item == "Lost")
                {
                    countLost++;
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlacklisted}");
            Console.WriteLine($"Lost names: {countLost}");
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
