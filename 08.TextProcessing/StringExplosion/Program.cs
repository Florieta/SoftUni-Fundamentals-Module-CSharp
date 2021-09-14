using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder();

            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol == '>')
                {
                    bomb += text[i + 1] - '0';
                    result.Append(symbol);
                }
                else if (bomb > 0)
                {
                    bomb -= 1;
                }
                else
                {
                    result.Append(symbol);
                }
            }
            Console.WriteLine(result);
        }
    }
}
