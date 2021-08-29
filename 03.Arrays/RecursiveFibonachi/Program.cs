using System;

namespace RecursiveFibonachi
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(num));

        }

        private static int GetFibonacci(int num)
        {

            if (num == 1 || num == 2)
            {
                return 1;
            }

            return GetFibonacci(num - 2) + GetFibonacci(num - 1);
        }
    }
}
