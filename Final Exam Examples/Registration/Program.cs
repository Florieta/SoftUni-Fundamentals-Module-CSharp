using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string pattern = @"([U$])([A-Z][a-z]{2,})\1([P@$])([a-z]{5,}[\d+])\3$";
                string line = Console.ReadLine();
                int count = 0;
                Match matchPass = Regex.Match(line, pattern);

                if (matchPass.Success)
                {
                    Console.WriteLine("Registration was successful");
                    count++;
                    string username = matchPass.Groups[2].Value;
                    string pass = matchPass.Groups[4].Value;
                    Console.WriteLine($"Username: {username}, Password: {pass}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }

                Console.WriteLine($"Successful registrations: {count}");
            }
            
        }
    }
}
