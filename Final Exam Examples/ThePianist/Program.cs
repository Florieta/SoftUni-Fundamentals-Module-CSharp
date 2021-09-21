using System;
using System.Collections.Generic;
using System.Linq;

namespace ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                pieces.Add(data[0], new string[] { data[1], data[2] });

            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add":
                        if (pieces.ContainsKey(tokens[1]))
                        {
                            Console.WriteLine($"{tokens[1]} is already in the collection!");
                        }
                        else
                        {
                            pieces.Add(tokens[1], new string[] { tokens[2], tokens[3] });

                            Console.WriteLine($"{tokens[1]} by {tokens[2]} in {tokens[3]} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(tokens[1]))
                        {
                            pieces.Remove(tokens[1]);
                            Console.WriteLine($"Successfully removed {tokens[1]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (pieces.ContainsKey(tokens[1]))
                        {
                            pieces[tokens[1]][1] = tokens[2];
                            Console.WriteLine($"Changed the key of {tokens[1]} to {tokens[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {tokens[1]} does not exist in the collection.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            pieces = pieces
                .OrderBy(p => p.Key)
                .ThenBy(p => p.Value[0])
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
