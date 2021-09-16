using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            string keyPattern = @"[STARstar]";
            string pattern = @"@([A-Za-z]+)[^@\-!:>]*:([0-9]+)[^@\-!:>]*(!A!|!D!)[^@\-!:>]*->([0-9]+)";

            int counter = int.Parse(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                StringBuilder sb = new StringBuilder();
                string input = Console.ReadLine();

                int count = Regex.Matches(input, keyPattern).Count;

                foreach (var item in input)
                {
                    sb.Append((char)(item - count));

                }

                Match match = Regex.Match(sb.ToString(), pattern);

                if (!match.Success)
                {
                    continue;
                }

                string planetName = match.Groups[1].Value;
                int population = int.Parse(match.Groups[2].Value);
                string attackType = match.Groups[3].Value;
                int soldierCounter = int.Parse(match.Groups[4].Value);

                if (attackType == "!A!")
                {
                    attackedPlanets.Add(planetName);
                }
                else
                {
                    destroyedPlanets.Add(planetName);
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var item in attackedPlanets.OrderBy(x => x)) 
            {
                Console.WriteLine($"-> {item}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var item in destroyedPlanets.OrderBy(x => x)) 
            {
                Console.WriteLine($"-> {item}");
            }
        }
    }
}
