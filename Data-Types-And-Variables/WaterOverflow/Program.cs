using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int inputLiters = int.Parse(Console.ReadLine());
                if (sum + inputLiters > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                    sum += inputLiters;
            }
            Console.WriteLine(sum);
        }
    }
}
