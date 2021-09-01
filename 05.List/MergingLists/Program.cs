using System;
using System.Collections.Generic;
using System.Linq;

namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> secondList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            List<int> numbers = new List<int>(firstList.Count + secondList.Count);
            int limit = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < limit; i++)
            {
                numbers.Add(firstList[i]);
                numbers.Add(secondList[i]);                
            }
            if (firstList.Count != secondList.Count)
            {
                if (firstList.Count > secondList.Count)
                {
                    numbers.AddRange(GetRemainingList(firstList, secondList));
                }
                else
                {
                    numbers.AddRange(GetRemainingList(secondList, firstList));
                }
            }


            Console.WriteLine(string.Join(" ", numbers));
        }

        private static List<int> GetRemainingList(List<int> longestList, List<int> shorterList)
        {
            if (longestList.Count <= shorterList.Count)
            {
                throw new ArgumentException();
            }
            List<int> result = new List<int>();

            for (int i = shorterList.Count; i < longestList.Count; i++)
            {
                result.Add(longestList[i]);
            }

            return result;
        }
    }
}
