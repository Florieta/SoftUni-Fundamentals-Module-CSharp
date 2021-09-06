using System;
using System.Collections.Generic;
using System.Linq;

namespace LecturePractice
{
    public class Program
    {

        public static void Main()
        {
            List<int> paintingNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                switch (tokens[0])
                {
                    case "Change":
                        int paintingNumber = int.Parse(tokens[1]);
                        int changedNumber = int.Parse(tokens[2]);
                        if (paintingNumbers.Contains(paintingNumber))
                        {
                            int indexOfPaiting = paintingNumbers.IndexOf(paintingNumber);
                            paintingNumbers.RemoveAt(indexOfPaiting);
                            paintingNumbers.Insert(indexOfPaiting, changedNumber);
                        }
                        break;
                    case "Hide":
                        int numberToHide = int.Parse(tokens[1]);
                        if (paintingNumbers.Contains(numberToHide))
                        {
                            paintingNumbers.Remove(numberToHide);
                        }

                        break;
                    case "Switch":
                        int firstNum = int.Parse(tokens[1]);
                        int secondNum = int.Parse(tokens[2]);
                        if (paintingNumbers.Contains(firstNum) && paintingNumbers.Contains(secondNum))
                        {
                            int indexOfFirst = paintingNumbers.IndexOf(firstNum);
                            int indexOfSecond = paintingNumbers.IndexOf(secondNum);
                            paintingNumbers[indexOfFirst] = secondNum;
                            paintingNumbers[indexOfSecond] = firstNum;
                        }
                        break;
                    case "Insert":
                        int place = (int.Parse(tokens[1]) + 1);
                        int pNum = int.Parse(tokens[2]);
                        if (paintingNumbers.Count > place && place > -1)
                        {
                            paintingNumbers.Insert(place, pNum);

                        }
                        break;
                    case "Reverse":
                        paintingNumbers.Reverse();
                        break;
                    default:
                        break;
                }
                input = Console.ReadLine();

            }
            Console.WriteLine(string.Join(" ", paintingNumbers));
        }
    }
}