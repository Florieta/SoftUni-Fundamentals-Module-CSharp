using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string result = SignChecker(num);
            Console.WriteLine(result);
        }

        static string SignChecker(int number)
        {
            string sign = null;
            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }
            return $"The number {number} is {sign}.";
        }
    }
}
