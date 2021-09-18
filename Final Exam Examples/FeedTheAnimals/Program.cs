using System;
using System.Collections.Generic;
using System.Linq;

namespace FeedTheAnimals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dailyFoodLimitByAnimal = new Dictionary<string, int>();
            Dictionary<string, List<string>> areaAnimals = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Last info")
            {
                string[] token = input.Split(":");
                string command = token[0];
                if (command == "Add")
                {
                    string animal = token[1];
                    int foodLimit = int.Parse(token[2]);
                    string area = token[3];
                    if (!dailyFoodLimitByAnimal.ContainsKey(animal))
                    {
                        dailyFoodLimitByAnimal[animal] = 0;

                    }

                    if(!areaAnimals.ContainsKey(area))
                    {
                        areaAnimals[area] = new List<string>();

                    }

                    if (!areaAnimals[area].Contains(animal))
                    {
                        areaAnimals[area].Add(animal);
                    }

                    dailyFoodLimitByAnimal[animal] += foodLimit;
                }
                else if (command == "Feed")
                {
                    string animal = token[1];
                    int food = int.Parse(token[2]);
                    string area = token[3];
                    if (dailyFoodLimitByAnimal.ContainsKey(animal))
                    {
                        dailyFoodLimitByAnimal[animal] -= food;

                        if (dailyFoodLimitByAnimal[animal] <= 0)
                        {
                            dailyFoodLimitByAnimal.Remove(animal);
                            areaAnimals[area].Remove(animal);
                            Console.WriteLine($"{animal} was successfully fed.");
                        }
                    }
                }
                input = Console.ReadLine();
            }

            dailyFoodLimitByAnimal = dailyFoodLimitByAnimal
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            areaAnimals = areaAnimals
                .Where(x => x.Value.Count > 0)
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Animals: ");

            foreach (var animal in dailyFoodLimitByAnimal)
            {
                Console.WriteLine($"{animal.Key} -> {animal.Value}g");
            }

            foreach (var animal in areaAnimals)
            {
                Console.WriteLine($"{animal.Key} : {animal.Value.Count}");
            }
        }
    }
}
