using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])([A-Za-z ]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]{1,5})\1";
            Regex rg = new Regex(pattern);
            string input = Console.ReadLine();

            MatchCollection matches = rg.Matches(input);
            int totalCalories = 0;



            foreach (Match item in matches)
            {
                totalCalories += int.Parse(item.Groups[4].Value);
            }
            int caloriesforDays = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {caloriesforDays} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups[2].Value}, Best before: {item.Groups[3].Value}, Nutrition: {item.Groups[4].Value}");
            }
        }
    }
}
