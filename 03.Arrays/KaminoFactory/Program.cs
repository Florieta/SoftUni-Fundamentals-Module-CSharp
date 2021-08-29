using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int applicationMaxSequence = 0;
            int mostLeftIndex = int.MaxValue;
            int maxSumOfOnes = 0;

            int bestDna = 1;
            int currentDna = 0;

            int[] result = null;

            while (command != "Clone them!")
            {
                //1!1!0!1
                int[] numbers = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sumOfOnes = 0;
                int maxSequence = 0;
                int currentSequence = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == 0)
                    {
                        currentSequence = 0;
                        continue;
                    }

                    sumOfOnes++;
                    currentSequence++;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }

                //Replace !!!
                string targetString = new string('1', maxSequence);
                int currentIndex = string.Join("", numbers).IndexOf(targetString);

                currentDna++;

                if (maxSequence >= applicationMaxSequence && currentIndex < mostLeftIndex ||
                    maxSequence == applicationMaxSequence && currentIndex == mostLeftIndex && sumOfOnes > maxSumOfOnes)
                {
                    applicationMaxSequence = maxSequence;
                    mostLeftIndex = currentIndex;
                    maxSumOfOnes = sumOfOnes;
                    bestDna = currentDna;
                    result = numbers;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestDna} with sum: {maxSumOfOnes}.");
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
