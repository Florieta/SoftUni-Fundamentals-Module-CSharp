using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }
            }
            if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }
            }
            if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }
            }

            double totalPrice = numberPeople * price;

            if (numberPeople >= 30 && typeOfGroup == "Students")
            {
                totalPrice -= totalPrice * 0.15;
            }
            else if (numberPeople >= 100 && typeOfGroup == "Business")
            {
                totalPrice = (numberPeople - 10) * price;
            }
            else if (numberPeople >= 10 && numberPeople <= 20 && typeOfGroup == "Regular")
            {
                totalPrice -= totalPrice * 0.05;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
