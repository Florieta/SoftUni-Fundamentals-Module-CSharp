using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestSequenceSize = 0;
            int bestSequenceNumber = 0;


            for (int i = 0; i < input.Length - 1; i++)
            {
                int currentNumber = input[i];
                int sequenceSize = 1;
                for (int j = i + 1; j < input.Length; j++)
                {
                    int rightNumber = input[j];
                    if (currentNumber == rightNumber)
                    {
                        sequenceSize++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (sequenceSize > bestSequenceSize)
                {
                    bestSequenceSize = sequenceSize;
                    bestSequenceNumber = currentNumber;
                }

            }

            for (int i = 0; i < bestSequenceSize; i++)
            {
                Console.Write(bestSequenceNumber + " ");
            }
            Console.WriteLine();
        }
    }
}

