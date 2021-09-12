using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int result = MultiplyWords(words[0], words[1]);
            Console.WriteLine(result);
        }

        private static int MultiplyWords(string first, string second)
        {
            int minLength = Math.Min(first.Length, second.Length);
            int sum = 0;

            for (int i = 0; i < minLength; i++)
            {
                sum += first[i] * second[i];
                
            }
            if (first.Length > second.Length)
            {
                sum += SumRemainingCharacters(first, minLength);
            }
            else if (second.Length > first.Length)
            {
                sum += SumRemainingCharacters(second, minLength);

            }
            return sum;
        }

        private static int SumRemainingCharacters(string word, int idx)
        {
            int sum = 0;
            for (int i = idx; i < word.Length; i++)
            {
                sum += word[i];
            }
            return sum;
        }
    }
}
