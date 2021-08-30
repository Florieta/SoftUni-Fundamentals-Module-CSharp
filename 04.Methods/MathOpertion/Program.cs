using System;

namespace MathOpertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, @operator, b));
        }

        private static double Calculate(int a, string @operator, int b)
        {
            double result = 0;

            if (@operator == "+")
            {
                result = a + b;
            }
            else if (@operator == "-")
            {
                result = a - b;
            }
            else if (@operator == "*")
            {
                result = a * b;
            }
            else if (@operator == "/")
            {
                result = a / b;
            }

            return result;
        }
    }
}
