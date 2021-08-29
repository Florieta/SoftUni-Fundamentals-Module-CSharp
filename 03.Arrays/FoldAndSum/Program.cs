using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int size = initialArray.Length / 4;
            int index = initialArray.Length - 1;

            int[] upper = new int[initialArray.Length / 2];
            int[] lower = new int[initialArray.Length / 2];

            for (int i = 0; i < upper.Length; i++)
            {
                if (i < upper.Length / 2)
                {
                    upper[i] = initialArray[size - 1 - i];
                }
                else
                {
                    upper[i] = initialArray[index];
                    index--;
                }

            }

            for (int i = 0; i < lower.Length; i++)
            {
                lower[i] = initialArray[size + i];
            }


            for (int i = 0; i < upper.Length; i++)
            {
                int result = upper[i] + lower[i];
                Console.Write($"{result} ");
            }
        }
    }
}
