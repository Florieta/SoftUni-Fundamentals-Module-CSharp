using System;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPlunder = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double totalPlunder = 0;
            for (int i = 1; i <= daysPlunder; i++)
            {
                
                if (i % 3 == 0)
                {
                    totalPlunder += dailyPlunder * 1.5;

                }
                else
                {
                    totalPlunder += dailyPlunder;
                }
                
                if (i % 5 == 0)
                {
                    totalPlunder *= 0.7;
                }
               
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:F2} plunder gained.");
            }
            else if (totalPlunder < expectedPlunder)
            {
                double percentage = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentage:F2}% of the plunder.");
            }

        }
    }
}
