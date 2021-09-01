using System;
using System.Collections.Generic;
using System.Linq;

namespace MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstListNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondListNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> concatList = new List<int>();
            int lengthConcatList = Math.Min(firstListNumbers.Count, secondListNumbers.Count) * 2;
            int remindedNumber1 = 0;
            int remindedNumber2 = 0;

            for (int i = 0; i < firstListNumbers.Count; i++)
            {
                for (int k = secondListNumbers.Count - 1; k >= 0; k--)
                {
                    concatList.Add(firstListNumbers[i]);
                    concatList.Add(secondListNumbers[k]);
                    i = i + 1;

                    if (concatList.Count == lengthConcatList)
                    {
                        break;
                    }
                }
                if (concatList.Count == lengthConcatList)
                {
                    break;
                }
            }

            if (firstListNumbers.Count > secondListNumbers.Count)
            {
                remindedNumber1 = firstListNumbers[firstListNumbers.Count - 1];
                remindedNumber2 = firstListNumbers[firstListNumbers.Count - 2];
            }

            else if (secondListNumbers.Count > firstListNumbers.Count)
            {
                remindedNumber1 = secondListNumbers[0];
                remindedNumber2 = secondListNumbers[1];
            }

            int minNum = Math.Min(remindedNumber1, remindedNumber2);
            int maxNum = Math.Max(remindedNumber1, remindedNumber2);

            var listResult = concatList.Where(x => x > minNum && x < maxNum).ToList();
            var OrderedList = listResult.OrderBy(x => x);
            Console.WriteLine(string.Join(" ", OrderedList));
        }
    }
}
