using System;
using System.Collections.Generic;
using System.Linq;

namespace WizardPoker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine().Split(":").ToList();
            List<string> hand = new List<string>();
            string input = Console.ReadLine();

            while (input != "Ready")
            {
                string[] splitted = input.Split();
                switch (splitted[0])
                {
                    case "Add":
                        {
                            if (cards.Contains(splitted[1]))
                            {
                                hand.Add(splitted[1]);

                            }
                            else
                            {
                                Console.WriteLine("Card not found.");
                            }
                        }
                        break;
                    case "Insert":
                        {
                            string cardName = splitted[1];
                            int index = int.Parse(splitted[2]);
                            if (index < 0 || index >= hand.Count || cards.IndexOf(cardName) == -1)
                            {
                                Console.WriteLine("Error!");
                            }
                            else
                            {
                                hand.Insert(index, cardName);
                            }
                        }
                        break;
                    case "Remove":
                        {
                            if (hand.Contains(splitted[1]))
                            {
                                hand.Add(splitted[1]);

                            }
                            else
                            {
                                Console.WriteLine("Card not found.");
                            }
                        }
                        break;
                    case "Swap":
                        {
                            int first = hand.IndexOf(splitted[1]);
                            int second = hand.IndexOf(splitted[2]);
                            string temp = hand[first];
                            hand[first] = hand[second];
                            hand[second] = temp;
                        }
                        break;
                    case "Shuffle":
                        {
                            hand.Reverse();
                        }
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", hand));
        }
    }
}
