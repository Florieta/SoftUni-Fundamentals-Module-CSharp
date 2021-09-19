using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^([$%])([A-Z][a-z]{2,})([$%])\:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";
           

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string openningTag = match.Groups[1].Value;
                    string closingTag = match.Groups[3].Value;

                    if (openningTag == closingTag)
                    {
                        string nameTag = match.Groups[2].Value;
                        string message = string.Empty;

                        for (int j = 4; j < match.Groups.Count; j++)
                        {
                            int val = int.Parse(match.Groups[j].Value);
                            if (val > 255)
                            {
                                Console.WriteLine("Valid message not found!");
                                continue;
                            }
                            message += (char)val;
                        }
                        Console.WriteLine($"{nameTag}: {message}");
                    }
                    else
                    {
                        Console.WriteLine("Valid message not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
