using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(GetThePowerOfNumber(number, power));
        }

        private static double GetThePowerOfNumber(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}
