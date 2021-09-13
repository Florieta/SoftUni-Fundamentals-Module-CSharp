using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char previousSymbol = '\0';

            StringBuilder result = new StringBuilder();

            foreach (char letter in text)
            {
                if (letter != previousSymbol)
                {
                    result.Append(letter);
                }

                previousSymbol = letter;
            }

            Console.WriteLine(result);
        }
    }
}
