using System;
using System.Collections.Generic;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyBigNumber(number, multiplier));
            
            
        }

        private static string MultiplyBigNumber(string number, int multiplier)
        {
            if (multiplier == 0)
            {
                return "0";
            }

            int remainder = 0;
            List<string> result = new List<string>();


            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                remainder += multiplier * digit;

                if (remainder > 9)
                {
                    int remainderLastDigit = remainder % 10;
                    remainder /= 10;
                    result.Add(remainderLastDigit.ToString());

                }
                else
                {
                    result.Add(remainder.ToString());
                    remainder = 0;

                }
            }

            if (remainder > 0)
            {
                result.Add(remainder.ToString());
            }



            result.Reverse();

            return string.Concat(result);
        }
    }
}
