using System;

namespace FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string numbers = Console.ReadLine();

                string firstNumAsString = string.Empty;
                string secondNumAsString = string.Empty;
                bool isFirstNum = true;

                for (int j = 0; j < numbers.Length; j++)
                {
                    char currentDigit = numbers[j];

                    if (isFirstNum && numbers[j] != ' ')
                    {
                        firstNumAsString += currentDigit;
                    }
                    else if (!isFirstNum && numbers[j] != ' ')
                    {
                        secondNumAsString += currentDigit;
                    }
                    else if (numbers[j] == ' ')
                    {
                        isFirstNum = false;
                    }
                }

                long firstNumber = long.Parse(firstNumAsString);
                long secondNumber = long.Parse(secondNumAsString);

                if (firstNumber >= secondNumber)
                {
                    long sumOfDigits = 0;
                    long copyNumber = Math.Abs(firstNumber);

                    while (copyNumber > 0)
                    {
                        long currentDigit = copyNumber % 10;
                        sumOfDigits += currentDigit;
                        copyNumber /= 10;
                    }
                    Console.WriteLine(sumOfDigits);
                }
                if (secondNumber > firstNumber)
                {
                    long sumOfDigits = 0;
                    long copyNumber = Math.Abs(secondNumber);

                    while (copyNumber > 0)
                    {
                        long currentDigit = copyNumber % 10;
                        sumOfDigits += currentDigit;
                        copyNumber /= 10;
                    }
                    Console.WriteLine(sumOfDigits);
                }
            }

        }
    }
}
