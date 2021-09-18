using System;
using System.Collections.Generic;
using System.Linq;

namespace InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mail = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] token = input.Split("->");
                string command = token[0];
                string username = token[1];
                if (command == "Add")
                {
                    if (mail.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        mail.Add(username, new List<string>());
                    }
                }
                else if (command == "Send")
                {
                    string email = token[2];
                    mail[username].Add(email);
                }
                else if (command == "Delete")
                {
                    if (mail.ContainsKey(username))
                    {
                        mail.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {mail.Count}");

            mail = mail
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in mail)
            {
                Console.WriteLine(kvp.Key);
                List<string> emails = kvp.Value;
                for (int i = 0; i < emails.Count; i++)
                {
                    Console.WriteLine($" - {emails[i]}");
                }
                
            }
        }
    }
}
