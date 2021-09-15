using System;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+[3][5][9](\-|\ )[2]\1\d{3}\1\d{4}\b";
            string phones = Console.ReadLine();
            MatchCollection matches = Regex.Matches(phones, pattern);
            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
