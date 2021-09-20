using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> goldByTown = new Dictionary<string, long>();
            Dictionary<string, long> populationByTown = new Dictionary<string, long>();

           
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Sail")
                {
                    break;
                }

                string[] parts = line.Split("||");
                string townName = parts[0];
                long population = long.Parse(parts[1]);
                long gold = long.Parse(parts[2]);
                if (goldByTown.ContainsKey(townName))
                {
                    
                    goldByTown[townName] += gold;
                    populationByTown[townName] += population;
                }
                else
                {
                    goldByTown.Add(townName, gold);
                    populationByTown.Add(townName, population);
                }
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split("=>");
                string command = parts[0];
                string townName = parts[1];
               
                if (command == "Plunder")
                {
                    int people = int.Parse(parts[2]);
                    int gold = int.Parse(parts[3]);

                    goldByTown[townName] -= gold;
                    populationByTown[townName] -= people;
                    

                    Console.WriteLine($"{townName} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (goldByTown[townName] == 0 || populationByTown[townName] == 0)
                    {
                        goldByTown.Remove(townName);
                        populationByTown.Remove(townName);

                        Console.WriteLine($"{townName} has been wiped off the map!");
                    }
                }
                else if (command == "Prosper")
                {
                    int gold = int.Parse(parts[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    goldByTown[townName] += gold;
                    Console.WriteLine($"{gold} gold added to the city treasury. {townName} now has {goldByTown[townName]} gold.");
                }

            }

            Dictionary<string, long> sorted = goldByTown
                .OrderByDescending(t => t.Value)
                .ThenBy(t => t.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            if (sorted.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {sorted.Count} wealthy settlements to go to:");

                foreach (var kvp in sorted)
                {
                    string townName = kvp.Key;
                    long gold = kvp.Value;
                    long population = populationByTown[townName];

                    Console.WriteLine($"{townName} -> Population: {population} citizens, Gold: {gold} kg");
                }
            }
        }

    }
}
