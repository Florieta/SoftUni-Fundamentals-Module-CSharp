using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Take_SkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> text = new List<string>();
            List<int> numbers = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            string result = string.Empty;
           

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                }
                else
                {
                    text.Add(input[i].ToString());
                }
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }
            int index = 0;
            for (int i = 0; i < takeList.Count; i++)
            {
                int take = takeList[i];
                int skipe = skipList[i];

                if (index + take > text.Count)
                {
                    take = text.Count - index;
                }

                for (int j = 0; j < take; j++)
                {
                    result += text[index + j];
                }

                index += take + skipe;
            }

            Console.WriteLine(result);
        }
    }
}