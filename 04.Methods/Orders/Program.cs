using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            PrintTheSum(product, count);
        }

        private static void PrintTheSum(string product, int count)
        {
            if (product == "coffee")
            {
                Console.WriteLine($"{(count * 1.50):f2}");
            }
            else if (product == "water")
            {
                Console.WriteLine($"{(count * 1.00):f2}");
            }
            else if (product == "coke")
            {
                Console.WriteLine($"{(count * 1.40):f2}");
            }
            else if (product == "snacks")
            {
                Console.WriteLine($"{(count * 2.00):f2}");
            }
        }
    }
}
