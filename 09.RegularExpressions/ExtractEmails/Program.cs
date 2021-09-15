using System;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<=\s)([A-za-z0-9]+[-._]*[A-za-z0-9]+)@([A-Za-z]+(([.-]*)[A-Za-z]+)*\.[a-z]{2,})";

            string text = Console.ReadLine();

            MatchCollection matchCollection = Regex.Matches(text, pattern);

            foreach (Match item in matchCollection)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
