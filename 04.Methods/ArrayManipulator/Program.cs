using System;
using System.Linq;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool end = false;
            string finalArray = string.Join(" ", input);
            int[] temp = finalArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            while (end == false)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    end = true;
                    continue;
                }

                string[] action = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (action[0])
                {
                    case "exchange":
                        if (int.Parse(action[1]) > input.Length - 1 || int.Parse(action[1]) < 0)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        finalArray = Exchange(temp, int.Parse(action[1]));
                        temp = finalArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                        break;
                    case "max":
                        if (Max(temp, action[1]) == int.MaxValue)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }

                        Console.WriteLine(Max(temp, action[1]));
                        break;
                    case "min":
                        if (Min(temp, action[1]) == int.MaxValue)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }

                        Console.WriteLine(Min(temp, action[1]));
                        break;
                    case "first":
                        if (int.Parse(action[1]) > temp.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (First(temp, int.Parse(action[1]), action[2]) == string.Empty)
                        {
                            Console.WriteLine("[]");
                            break;
                        }

                        string[] firstArray = First(temp, int.Parse(action[1]), action[2]).Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"[{string.Join(", ", firstArray)}]");
                        break;
                    case "last":
                        if (int.Parse(action[1]) > temp.Length)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }

                        if (Last(temp, int.Parse(action[1]), action[2]) == string.Empty)
                        {
                            Console.WriteLine("[]");
                            break;
                        }

                        string[] lastArray = Last(temp, int.Parse(action[1]), action[2]).Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"[{string.Join(", ", lastArray)}]");
                        break;
                }

            }

            Console.WriteLine($"[{string.Join(", ", temp)}]");
        }

        static string Exchange(int[] x, int y)
        {
            int[] leftArray = new int[y + 1];
            int[] rightArray = new int[x.Length - y - 1];
            int[] newArray = new int[x.Length];
            string array = string.Empty;

            for (int i = 0; i <= y; i++)
            {
                leftArray[i] = x[i];
            }


            int counter = 0;
            for (int i = y + 1; i < x.Length; i++)
            {
                rightArray[counter] = x[i];
                counter++;
            }

            array = string.Join(" ", rightArray);
            array += " " + string.Join(" ", leftArray);
            return array;
        }

        static int Max(int[] x, string evenOdd)
        {
            int index = int.MaxValue;
            int temp = int.MinValue;

            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 == 0 && x[i] >= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 != 0 && x[i] >= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
            }

            return index;
        }

        static int Min(int[] x, string evenOdd)
        {
            int index = int.MaxValue;
            int temp = int.MaxValue;

            switch (evenOdd)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 == 0 && x[i] <= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (x[i] % 2 != 0 && x[i] <= temp)
                        {
                            index = i;
                            temp = x[i];
                        }
                    }
                    break;
            }

            return index;
        }

        static string First(int[] x, int y, string z)
        {
            int counter = 0;
            string newArray = string.Empty;
            switch (z)
            {
                case "even":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 == 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
                case "odd":
                    for (int i = 0; i < x.Length; i++)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 != 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
            }

            return newArray;
        }

        static string Last(int[] x, int y, string z)
        {
            int counter = 0;
            string newArray = string.Empty;
            switch (z)
            {
                case "even":
                    for (int i = x.Length - 1; i >= 0; i--)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 == 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
                case "odd":
                    for (int i = x.Length - 1; i >= 0; i--)
                    {
                        if (counter >= y)
                        {
                            break;
                        }
                        if (x[i] % 2 != 0)
                        {
                            newArray += x[i] + " ";
                            counter++;
                        }
                    }

                    break;
            }

            int[] newArrayInt = newArray.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Array.Reverse(newArrayInt);
            newArray = string.Join(" ", newArrayInt);

            return newArray;
        }
    }
}
