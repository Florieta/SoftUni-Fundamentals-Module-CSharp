using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = GetSmallestNumber(first, second, third);

            Console.WriteLine(min);
        }

        private static int GetSmallestNumber(int first, int second, int third)
        {
            int min = Math.Min(Math.Min(first, second), third);

            return min;
        }
    }
}
