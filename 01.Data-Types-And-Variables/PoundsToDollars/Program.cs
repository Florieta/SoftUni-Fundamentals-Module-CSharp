using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal dollars = pounds * (decimal)1.31;
            Console.WriteLine($"{dollars:F3}");
        }
    }
}
