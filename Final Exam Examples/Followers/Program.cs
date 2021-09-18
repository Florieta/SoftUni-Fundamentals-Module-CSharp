using System;
using System.Collections.Generic;

namespace Followers
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int[]> followers = new Dictionary<string, int[]>();

            string input = Console.ReadLine();

            while (input != "Log out")
            {
                string[] token = input.Split(": ");
                string command = token[0];
                string username = token[1];
                if (command == "New follower")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new int[2]);
                    }
                }
                else if (command == "Like")
                {
                    int count = int.Parse(token[2]);
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new int[] { 0, count });
                    }
                    else
                    {
                        followers[username][1] += count;
                    }
                }
                else if (command == "Comment")
                {
                    if (!followers.ContainsKey(username))
                    {
                        followers.Add(username, new int[] { 0, 1 });
                    }
                    else
                    {
                        followers[username][0] += 1;
                    }
                }
                else if (command == "Blocked")
                {
                    if (!followers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn`t exist.");
                    }
                    else
                    {
                        followers.Remove(username);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{followers.Count} followers");

            foreach (var follower in followers)
            {
                Console.WriteLine($"{follower.Key}: {follower.Value[0] + follower.Value[1]}");
            }
        }
    }
}
