using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced  
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command = Console.ReadLine();
            bool change = false;

            while (command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        numbers.Add(numberToAdd);
                        change = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        change = true;
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        change = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numberToInsert);
                        change = true;
                        break;
                    case "Contains":
                        int containedNumber = int.Parse(tokens[1]);
                        if (numbers.Contains(containedNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> secondList = numbers.Where(n => n % 2 == 0).ToList();

                        Console.WriteLine(string.Join(" ", secondList));

                        break;
                    case "PrintOdd":
                        List<int> thirdList = numbers.Where(x => x % 2 == 1).ToList();

                        Console.WriteLine(string.Join(" ", thirdList));

                        break;
                    case "GetSum":
                        int currentDigit = numbers.Sum();
                        Console.WriteLine("{0}", currentDigit);
                        break;
                    case "Filter":
                        string sign = tokens[1];
                        int numberF = int.Parse(tokens[2]);
                        if (sign == ">")
                        {
                            List<int> newList = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > numberF)
                                {
                                    newList.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", newList));
                        }
                        else if (sign == "<")
                        {
                            List<int> newList = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < numberF)
                                {
                                    newList.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", newList));
                        }
                        else if (sign == "<=")
                        {
                            List<int> newList = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= numberF)
                                {
                                    newList.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", newList));
                        }
                        else if (sign == ">=")
                        {
                            List<int> newList = new List<int>();
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= numberF)
                                {
                                    newList.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(String.Join(" ", newList));
                        }
                        break;

                }
                command = Console.ReadLine();
            }
            if (change == true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}