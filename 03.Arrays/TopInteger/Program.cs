using System;
using System.Linq;

namespace TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];

                bool isTopNumber = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int rightNumber = numbers[j];

                    if (rightNumber >= currentNumber)
                    {
                        isTopNumber = false;
                        break;
                    }
                   
                }

                if (isTopNumber)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
