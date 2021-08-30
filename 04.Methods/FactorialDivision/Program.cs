using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double firstFactorial = CalculateFactorial(first);
            double secondFactorial = CalculateFactorial(second);

            double result = firstFactorial * 1.0 / secondFactorial;

            Console.WriteLine($"{result:F2}");
        }

        private static double CalculateFactorial(int number)
        {
            double factorial = 1;

            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;
        }
    }
}
