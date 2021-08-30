using System;

namespace CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            double input3 = double.Parse(Console.ReadLine());
            PrintClosestToCenter(input, input1, input2, input3);
        }

        private static void PrintClosestToCenter(double x1, double y1, double x2, double y2)
        {
            double distance1 = Math.Pow(x1, 2) + Math.Pow(y1, 2);
            double distance2 = Math.Pow(x2, 2) + Math.Pow(y2, 2);
            if (distance1 < distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
