using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"([=/])([A-Z][A-Za-z]{2,})(\1)";

            MatchCollection matches = Regex.Matches(text, pattern); 
            List<string> validWords = new List<string>();

            int sum = 0;

            foreach (Match match in matches)
            {
                var destination = match.Groups[2].Value;
                sum += destination.Length;

                validWords.Add(destination);
            }

            Console.WriteLine($"Destinations: {String.Join(", ", validWords)}");
            Console.WriteLine($"Travel Points: {sum}");
        }
    }
}
