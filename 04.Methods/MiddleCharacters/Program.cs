using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string middle = GetMiddle(str);

            Console.WriteLine(middle);
        }

        private static string GetMiddle(string str)
        {
            if (str.Length % 2 == 0)
            {
                return $"{str[str.Length / 2 - 1]}{str[str.Length / 2]}";
            }

            return $"{str[(str.Length - 1) / 2]}";
        }
    }
}
