using System;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int division = 0;

            if (number % 10 == 0)
            {
                division = 10;
            }
            else if (number % 7 == 0)
            {
                division = 7;
            }
            else if (number % 6 == 0)
            {
                division = 6;
            }
            else if (number % 3 == 0)
            {
                division = 3;
            }
            else if (number % 2 == 0)
            {
                division = 2;
            }

            if (division == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {division}");
            }
        }
    }
}
