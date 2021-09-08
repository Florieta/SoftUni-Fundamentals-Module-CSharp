using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> storage = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] parts = input.Split(" - ");
                string command = parts[0];
                if (command == "Add")
                {
                    string phone = parts[1];
                    if(!storage.Contains(phone))
                    {
                        storage.Add(phone);
                    }

                }
                else if (command == "Remove")
                {
                    string phone = parts[1];
                    if (storage.Contains(phone))
                    {
                        storage.Remove(phone);
                    }

                }
                else if (command == "Bonus phone")
                {
                    string[] tokens = parts[1].Split(":");
                    string oldPhone = tokens[0];
                    string newPhone = tokens[1];
                    if (storage.Contains(oldPhone))
                    {
                        int index = storage.IndexOf(oldPhone);
                        storage.Insert(index + 1, newPhone);
                    }
                }
                else if (command == "Last")
                {
                    string phone = parts[1];
                    if (storage.Contains(phone))
                    {
                        storage.Remove(phone);
                        storage.Add(phone);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", storage));
        }
    }
}
