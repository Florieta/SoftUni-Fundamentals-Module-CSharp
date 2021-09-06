using System;

namespace Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int partysize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int coins = 0;

            for (int currentDay = 1; currentDay <= days; currentDay++)
            {
                if (currentDay % 10 == 0)
                {
                    partysize -= 2;
                }
                if (currentDay % 15 == 0)
                {
                    partysize += 5;
                }
                coins += 50;
                coins -= 2 * partysize;

                if (currentDay % 3 == 0)
                {
                    coins -= 3 * partysize;
                }

                if (currentDay % 5 == 0)
                {
                    coins += 20 * partysize;
                    if (currentDay % 3 == 0)
                    {
                        coins -= 2 * partysize;
                    }
                }
            }

            Console.WriteLine($"{partysize} companions received {coins / partysize} coins each.");
        }
    }
}
