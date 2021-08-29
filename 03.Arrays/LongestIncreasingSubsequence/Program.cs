using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numArray.Length == 1)
            {
                Console.WriteLine("0"); return;
            }

            int leftSum = 0;
            int rightSum = 0;
            bool found = false;

            for (int pos = 0; pos < numArray.Length; pos++) //start searching
            {
                //sum LEFT numbers from current possition:
                for (int L = 0; L < pos; L++)
                {
                    leftSum += numArray[L];
                }
                //sum RIGHT numbers from current possition:
                for (int R = pos + 1; R < numArray.Length; R++)
                {
                    rightSum += numArray[R];
                }

                //check if sums are EQUAL:
                if (leftSum == rightSum)
                {
                    Console.WriteLine(pos);
                    found = true;
                }
                else //if not => reset sums:
                {
                    leftSum = 0;
                    rightSum = 0;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
