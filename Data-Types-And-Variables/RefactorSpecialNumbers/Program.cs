using System;

namespace RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int total = 0;
            
            bool isSpecialNumber = false;
            for (int i = 1; i <= count; i++)
            {
                 int number = i;
                 while (i > 0)
                 {
                    total += number % 10;
                    number = number / 10;
                 }
                isSpecialNumber = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNumber);
                total = 0;
            }
        }
    }
}
