using System;

namespace StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string line = Console.ReadLine();

            while (line != "Done")
            {
                string[] commands = line.Split();
                string command = commands[0];
                if (command == "Change")
                {
                    char symbol = command[1];
                    char replacement = command[2];
                    if(text.Contains(symbol))
                    {
                        while(text.Contains(symbol))
                        {
                            text = text.Replace(symbol, replacement);
                        }
                            
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Includes")
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "End")
                {
                    string finalPart = commands[1];

                    if (text.EndsWith(finalPart))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (command == "Uppercase")
                {
                    text = text.ToUpper();
                    Console.WriteLine(text);
                }
                else if (command == "FindIndex")
                {
                    char symbol = command[1];
                    int index = text.IndexOf(symbol);
                    Console.WriteLine(index);
                }
                else if (command == "Cut")
                {
                    int startIndex = int.Parse(commands[1]);
                    int length = int.Parse(commands[2]);
                    text = text.Substring(startIndex, length);
                    Console.WriteLine(text);
                }
                line = Console.ReadLine();
            }
        }
    }
}
