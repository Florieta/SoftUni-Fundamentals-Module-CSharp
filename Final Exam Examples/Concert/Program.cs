using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> playTime = new Dictionary<string, int>();
            int totalTime = 0;

            while (input != "start of concert")
            {
                string[] parts = input.Split("; ");
                string command = parts[0];
                string band = parts[1];

                if (command == "Add")
                {
                    List<string> members = parts[2].Split(", ").ToList();
                    if (!bands.ContainsKey(band))
                    {
                        
                        bands.Add(band, members);
                    }
                    else
                    {
                        foreach (var member in members)
                        {
                            if (!bands[band].Contains(member))
                            {
                                bands[band].Add(member);
                            }
                        }
                    }
                }
                else if (command == "Play")
                {
                    int time = int.Parse(parts[2]);
                    if(!playTime.ContainsKey(band))
                    {                           
                          playTime.Add(band, time);
                    }
                    else
                    {
                        playTime[band] += time;
                        totalTime += time;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total time: {totalTime}");

            foreach (var band in playTime.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            string nameBand = Console.ReadLine();

            foreach (var member in bands[nameBand])
            {
                Console.WriteLine($"=> {member}");
            }
        }
    }
}
