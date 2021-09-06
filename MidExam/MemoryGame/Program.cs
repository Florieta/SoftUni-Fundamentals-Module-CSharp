using System;
using System.Collections.Generic;
using System.Linq;

namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            int numberOfMoves = 0;
            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] tokens = command.Split();
                int index1 = int.Parse(tokens[0]);
                int index2 = int.Parse(tokens[1]);
                if (index1 >= 0 && index2 >= 0 && index1 < input.Count && index2 < input.Count && index1 != index2)
                {
                    if (input[index1] == input[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {input[index1]}!");

                        if (index1 > index2)
                        {
                            input.RemoveAt(index1);
                            input.RemoveAt(index2);
                        }
                        else
                        {
                            input.RemoveAt(index2);
                            input.RemoveAt(index1);
                        }

                        if (input.Count == 0)
                        {
                            Console.WriteLine($"You have won in {numberOfMoves} turns!");
                            return;
                        }
                    }
                    else if (input[index1] != input[index2])
                    {
                        Console.WriteLine("Try again!");
                    }
                }
                else
                {
                    string added = "-" + numberOfMoves + "a";
                    input.Insert(input.Count / 2, added);
                    input.Insert(input.Count / 2, added);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(String.Join(" ", input));

        }
    }
    }
}
