using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            input = Math.Abs(input);

            int oddSum = GetSumOdds(input);
            int evenSum = GetSumEvens(input);
            Console.WriteLine(MultiplyEO(oddSum, evenSum));
        }

        private static int GetSumEvens(int n)
        {
            string inputArray = n.ToString();
            int sumEven = 0;
            foreach (var digit in inputArray)
            {
                if (digit % 2 == 0)
                {
                    sumEven += (int)char.GetNumericValue(digit);
                }
            }


            return sumEven;
        }

        private static int GetSumOdds(int n)
        {
            string inputArray = n.ToString();
            int sumOdds = 0;
            foreach (var digit in inputArray)
            {
                if (digit % 2 != 0)
                {
                    sumOdds += (int)char.GetNumericValue(digit);
                }
            }
            return sumOdds;
        }
            private static int MultiplyEO(int n1, int n2)
        {
            int result = n1 * n2;
            return result;
        }
    }
}
