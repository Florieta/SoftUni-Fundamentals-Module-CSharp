using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string newWord = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                newWord += input[i];
            }
            Console.WriteLine(newWord);
        }
    }
}
