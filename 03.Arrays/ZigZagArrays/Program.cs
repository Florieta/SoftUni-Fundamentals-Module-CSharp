using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int firstNumber = input[0];
                int secondNumber = input[1];

                if(i % 2 == 0)
                {
                    arr1[i] = firstNumber;
                    arr2[i] = secondNumber;
                }
                else
                {
                    arr1[i] = secondNumber;
                    arr2[i] = firstNumber;
                }
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(string.Join(' ',arr2));
        }
    }
}
