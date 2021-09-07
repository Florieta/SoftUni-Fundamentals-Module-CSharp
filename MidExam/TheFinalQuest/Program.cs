using System;
using System.Collections.Generic;
using System.Linq;

namespace TheFinalQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();

            string line = Console.ReadLine();

            while (line != "Stop")
            {
                string[] parts = line.Split();
                string command = parts[0];
                if (command == "Delete")
                {
                    int index = int.Parse(parts[1]);
                    if (index >= 0 && index < input.Count)
                    {
                        input.RemoveAt(index + 1);
                    }

                }
                else if (command == "Swap")
                {
                    string word1 = parts[1];
                    string word2 = parts[2];
                    if (input.Contains(word1) && input.Contains(word2))
                    {
                        int index1 = input.IndexOf(word1);
                        int index2 = input.IndexOf(word2);
                        input.RemoveAt(index1);
                        input.Insert(index1, word2);
                        input.RemoveAt(index2);
                        input.Insert(index2, word1);
                    }
                }
                else if (command == "Put")
                {
                    string word = parts[1];
                    int index = int.Parse(parts[2]);
                    if (index >= 0 && index <= input.Count)
                    {
                        input.Insert(index - 1, word);
                    }
                }
                else if (command == "Sort")
                {
                    input.OrderByDescending(n => n);
                    //list.Sort((x, y) => y.CompareTo(x));
                }
                else if (command == "Replace")
                {
                    string word1 = parts[1];
                    string word2 = parts[2];
                    if (input.Contains(word2))
                    {
                        int index = input.IndexOf(word2);
                        input.RemoveAt(index);
                        input.Insert(index, word1);
                    }
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", input));
        }
    }
}
