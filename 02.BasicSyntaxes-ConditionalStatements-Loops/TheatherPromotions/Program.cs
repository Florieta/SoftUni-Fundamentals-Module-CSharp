using System;

namespace TheatherPromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfTheDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }

            if (typeOfTheDay == "Weekday")
            {
                if (age <= 18)
                {
                    price = 12;
                }
                else if (age <= 64)
                {
                    price = 18;
                }
                else if (age <= 122)
                {
                    price = 12;
                }
            }
            else if (typeOfTheDay == "Weekend")
            {
                if (age <= 18)
                {
                    price = 15;
                }
                else if (age <= 64)
                {
                    price = 20;
                }
                else if (age <= 122)
                {
                    price = 15;
                }
            }
            else if (typeOfTheDay == "Holiday")
            {
                if (age <= 18)
                {
                    price = 5;
                }
                else if (age <= 64)
                {
                    price = 12;
                }
                else if (age <= 122)
                {
                    price = 10;
                }
            }
            Console.WriteLine($"{price}$");
        }
    }
}
