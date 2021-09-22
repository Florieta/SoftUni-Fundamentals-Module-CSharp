using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] token = input.Split();
                string command = token[0];
                if (command == "Translate")
                {
                    char symbol = char.Parse(token[1]);
                    char replacement = char.Parse(token[2]);
                    if (text.Contains(symbol))
                    {
                        text = text.Replace(symbol, replacement);
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    string str = token[1];
                    if (text.Contains(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Start")
                {
                    string str = token[1];
                    if (text.StartsWith(str))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Lowercase")
                {
                    text = text.ToLower();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char symbol = char.Parse(token[1]);
                    int index = text.LastIndexOf(symbol);
                    Console.WriteLine(index);
                }
                else if (command == "Remove")
                {
                    int startIndex = int.Parse(token[1]);
                    int count = int.Parse(token[2]);
                    text = text.Remove(startIndex, count);
                    Console.WriteLine(text);
                }
                    input = Console.ReadLine();
            }
        }
    }
}
