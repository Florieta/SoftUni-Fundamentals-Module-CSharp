using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string line = Console.ReadLine();
                string pattern = @"(.*)>(\d{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})(<)\1$";

                Match match = Regex.Match(line, pattern);
               

                if (match.Success)
                {
                    string pass1 = match.Groups[2].Value;
                    string pass2 = match.Groups[3].Value;
                    string pass3 = match.Groups[4].Value;
                    string pass4 = match.Groups[5].Value;
                    string password = string.Concat(pass1, pass2, pass3, pass4);
                    Console.WriteLine($"Password: {password}");

                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }

        }
    }
}

