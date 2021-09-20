using System;
using System.Collections.Generic;
using System.Linq;

namespace PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> rarityByPlant = new Dictionary<string, double>();
            Dictionary<string, List<double>> ratingsByPlant = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split("<->");
                string plantName = parts[0];
                double rarity = double.Parse(parts[1]);

                rarityByPlant[plantName] = rarity;
                if (!ratingsByPlant.ContainsKey(plantName))
                {
                    ratingsByPlant[plantName] = new List<double>();
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Exhibition")
                {
                    break;
                }
                string[] commonParts = line.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = commonParts[0];

                if (command == "Rate")
                {
                    string[] arg = commonParts[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    if (arg.Length != 2)
                    {
                        Console.WriteLine("error");
                            continue;
                    }

                    string plant = arg[0];
                    double rating = double.Parse(arg[1]);

                    if (!rarityByPlant.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    ratingsByPlant[plant].Add(rating);

                }
                else if (command == "Reset")
                {
                    string plant = commonParts[1];
                    if (!rarityByPlant.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    ratingsByPlant[plant].Clear();

                }
                else if (command == "Update")
                {
                    string[] arg = commonParts[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                    if (arg.Length != 2)
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    string plant = arg[0];
                    double newRarity = double.Parse(arg[1]);
                    if (!rarityByPlant.ContainsKey(plant))
                    {
                        Console.WriteLine("error");
                        continue;
                    }

                    rarityByPlant[plant] = newRarity;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            Dictionary<string, double> sorted = rarityByPlant
                .OrderByDescending(x => x.Value)
                .ThenByDescending(x =>
                {
                    List<double> ratings = ratingsByPlant[x.Key];

                    if (ratings.Count == 0)
                    {
                        return 0;
                    }

                    return ratings.Average();
                })
                .ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine($"Plants for the exhibition: ");
            foreach (var kvp in sorted)
            {
                string plant = kvp.Key;
                double rarity = kvp.Value;
                double rating = 0;

                List<double> ratings = ratingsByPlant[kvp.Key];
                if (ratings.Count != 0)
                {
                    rating = ratings.Average();
                }
                Console.WriteLine($"- {plant}; Rarity: {rarity}; Rating: {rating:F2}");
            }

        }
    }
}
