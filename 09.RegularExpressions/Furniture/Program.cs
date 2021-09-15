using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^>>([a-zA-Z]+)<<([0-9]+\.{0,1}[0-9]{0,})!([0-9]+)";

            string input = Console.ReadLine();
            decimal totalPrice = 0;
            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match match = Regex.Match(input, pattern);

                if(!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }
                string productName = match.Groups[1].Value;
                decimal productPrice = decimal.Parse(match.Groups[2].Value);
                int productCount = int.Parse(match.Groups[3].Value);

                totalPrice += productPrice * productCount;

                
                Console.WriteLine(productName);
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}
