using System;

namespace RagesExpences
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double priceHeadSet = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());
            double money = 0;

            for (int i = 1; i <= lostGameCount; i++)
            {
                if (i % 2 == 0)
                {
                    money += priceHeadSet;
                }
                if (i % 3 == 0)
                {
                    money += priceMouse;
                }
                if (i % 6 == 0)
                {
                    money += priceKeyboard;
                }
                if (i % 12 == 0)
                {
                    money += priceDisplay;
                }
            }
            Console.WriteLine($"Rage expenses: {money:F2} lv.");
        }
    }
}
