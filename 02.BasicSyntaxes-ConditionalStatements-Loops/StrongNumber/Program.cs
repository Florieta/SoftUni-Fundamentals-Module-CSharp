using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int firstNumber = number;

            while (number > 0)
            {
                int currentNumber = number % 10;
                int factoriel = 1;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
                number /= 10;

            }

            if (firstNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
