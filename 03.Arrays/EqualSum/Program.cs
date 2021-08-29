using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isFound = false;
            int middleIndex = 0;

            if (input.Length == 1)
            {
                isFound = true;
                middleIndex = 0;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                int middle = i + 1;
                for (int j = 0; j <= i; j++)
                {
                    leftSum += input[j];
                }
                for (int j = i + 2; j < input.Length; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum && input.Length > 1)
                {
                    isFound = true;
                    middleIndex = middle;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(middleIndex);
            }
        }
    }
}
