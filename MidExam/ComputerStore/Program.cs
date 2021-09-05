using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double priceWithoutTaxes = 0;

            while (input != "special" && input != "regular" )
            {
                double price = double.Parse(input);
                if (price <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    input = Console.ReadLine();
                    continue;
                }
                priceWithoutTaxes += price;
                input = Console.ReadLine();
            }


            double priceWithTaxes = priceWithoutTaxes + (priceWithoutTaxes * 0.2);
            double amountOfTaxes = priceWithTaxes - priceWithoutTaxes;

            if (input == "special")
            {
                priceWithTaxes -= priceWithTaxes * 0.1;
            }

            if(priceWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceWithoutTaxes:F2}$");
                Console.WriteLine($"Taxes: {amountOfTaxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {priceWithTaxes:F2}$");
            }
           
        }
    }
}
