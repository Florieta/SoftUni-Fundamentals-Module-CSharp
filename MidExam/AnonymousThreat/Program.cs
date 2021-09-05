using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> line = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] parts = input.Split();
                string command = parts[0];
                if (command == "merge")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    string mergedString = "";
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= line.Count)
                    {
                        endIndex = line.Count - 1;
                    }
                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        if (startIndex < 0 || startIndex >= line.Count)
                        {
                            continue;
                        }
                        mergedString += line[startIndex];
                        line.RemoveAt(startIndex);
                    }
                    line.Insert(startIndex, mergedString);
                }
                else if (command == "divide")
                {
                    int index = int.Parse(parts[1]);
                    int partitions = int.Parse(parts[2]);
                    

                    string element = line[index];
                    line.RemoveAt(index);
                    int tokens = element.Length / partitions;
                    List<string> dividedElements = new List<string>();

                    for (int i = 0; i < partitions - 1; i++)
                    {
                        string currentElement = element.Substring(tokens * i, tokens);
                        dividedElements.Add(currentElement);
                    }

                    string lastElement = element.Substring(tokens * (partitions - 1));
                    dividedElements.Add(lastElement);

                    line.InsertRange(index, dividedElements);
                }
            }
            }
        }
    }
}
