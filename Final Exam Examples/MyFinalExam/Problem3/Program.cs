using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> like = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> unlike = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Stop")
            {
                string[] token = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                string command = token[0];
                string guest = token[1];
                string meal = token[2];
                if (command == "Like")
                {
                    if (like.ContainsKey(guest))
                    {
                        if (like[guest].Contains(meal))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            like[guest].Add(meal);
                        }
                        
                    }
                    else
                    {
                        like.Add(guest, new List<string> { meal });
                    }
                }
                else if (command == "Unlike")
                {
                    if (like.ContainsKey(guest))
                    {
                        if (!like[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else
                        {
                            like[guest].Remove(meal);
                            unlike.Add(guest, new List<string> { meal });
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }
                input = Console.ReadLine();
            }

            like = like
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);


            foreach (var guest in like)
            {
                List<string> meals = guest.Value;
                Console.WriteLine($"{guest.Key}: {string.Join(", ", meals)}");
            }

            Console.WriteLine($"Unliked meals: {unlike.Count}");
        }
    }
}
