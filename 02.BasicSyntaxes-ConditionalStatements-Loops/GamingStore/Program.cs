using System;

namespace GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double price = 0;
            double totalSpent = 0;

            while (input != "Game Time")
            {
                if (input == "OutFall 4")
                {
                    price = 39.99;
                }
                else if (input == "CS: OG")
                {
                    price = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99; 
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }

                if (currentBalance >= price)
                {
                    currentBalance -= price;
                    Console.WriteLine($"Bought {input}");
                }
                else if (currentBalance < price)
                {
                    Console.WriteLine("Too Expensive");
                    input = Console.ReadLine();
                    continue;
                }
                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                
                totalSpent += price;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${currentBalance:F2}");
        }
    }
}
