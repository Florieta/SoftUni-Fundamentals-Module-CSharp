using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([@#])(?<word1>[A-Za-z]{3,})(\1)(\1)(?<word2>[A-Za-z]{3,})(\1)";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            List<string> validWords = new List<string>();

            foreach (Match match in matches)
            {
                var word1 = match.Groups["word1"].Value;
                var word2 = match.Groups["word2"].Value;

                var reversed = String.Concat(word1.Reverse());
                if (reversed == word2)
                {
                    validWords.Add($"{word1} <=> {word2}");
                }
            }

            if (matches.Count == 0)
            {
                Console.WriteLine($"No word pairs found!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }

            if (validWords.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(String.Join(", ", validWords));
            }
        }
    }
}
