using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int vowelsCounter = GetVowelsCount(text);

            Console.WriteLine(vowelsCounter);
        }

        private static int GetVowelsCount(string text)
        {
            int counter = 0;
            text = text.ToLower();
            foreach (char letter in text)
            {
                if (letter == 'a' ||
                    letter == 'e' ||
                    letter == 'o' ||
                    letter == 'u' ||
                    letter == 'i' ||
                    letter == 'y')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
