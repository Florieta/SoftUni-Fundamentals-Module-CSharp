using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = Console.ReadLine().Split("!").ToList();

            string line = Console.ReadLine();

            while (line != "Go Shopping!")
            {
                string[] parts = line.Split();
                string command = parts[0];

                if (command == "Urgent")
                {
                    string item = parts[1];
                    if (!shoppingList.Contains(item))
                    {
                        shoppingList.Insert(0, item);
                    }
                }
                else if (command == "Unnecessary")
                {
                    string item = parts[1];
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                    }
                }
                else if (command == "Correct")
                {
                    string OldItem = parts[1];
                    string NewItem = parts[2];
                    if (shoppingList.Contains(OldItem))
                    {
                        int index = shoppingList.IndexOf(OldItem);
                        shoppingList.Insert(index, NewItem);
                        shoppingList.Remove(OldItem);
                    }
                }
                else if (command == "Rearrange")
                {
                    string item = parts[1];
                    if (shoppingList.Contains(item))
                    {
                        shoppingList.Remove(item);
                        shoppingList.Add(item);
                    }
                   
                }
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", shoppingList));
        }
    }
}
