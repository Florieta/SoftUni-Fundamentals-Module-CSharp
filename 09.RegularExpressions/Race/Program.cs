using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> participants = new Dictionary<string, int>();

            string letterPattern = "[A-Za-z]";
            string digitPattern = "[0-9]";

            string[] racers = Console.ReadLine()
                .Split(", ");
            foreach (var item in racers)
            {
                participants.Add(item, 0);
            }
            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string currentName = "";
                int currentSum = 0;

                MatchCollection letters = Regex.Matches(input, letterPattern);

                foreach (Match letter in letters)
                {
                    currentName += letter.Value;
                }

                if (!participants.ContainsKey(currentName))
                {
                    input = Console.ReadLine();
                    continue;
                }

                MatchCollection digits = Regex.Matches(input, digitPattern);

                foreach (Match digit in digits)
                {
                    currentSum += int.Parse(digit.Value);
                }

                participants[currentName] += currentSum;

                input = Console.ReadLine();
            }

            int counter = 1;
            

                foreach (var item in participants.OrderByDescending(x => x.Value))
            {
                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                }
                counter++;
            }
        }
    }
}
