using System;
using System.Collections.Generic;
using System.Linq;

namespace MessagesManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Dictionary<string, int> receivedMessages = new Dictionary<string, int>();
            Dictionary<string, int> sentMessages = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "Statistics")
            {
                string[] parts = input.Split("=");

                string command = parts[0];
                if (command == "Add")
                {
                    string username = parts[1];
                    int sent = int.Parse(parts[2]);
                    int received = int.Parse(parts[3]);

                    if (!sentMessages.ContainsKey(username))
                    {
                        sentMessages.Add(username, sent);
                        receivedMessages.Add(username, received);
                    }
                }
                else if (command == "Message")
                {
                    string sender = parts[1];
                    string receiver = parts[2];

                    if (sentMessages.ContainsKey(sender) && receivedMessages.ContainsKey(receiver))
                    {
                        sentMessages[sender] += 1;
                        receivedMessages[receiver] += 1;

                        int senderTotalMessages = sentMessages[sender] + receivedMessages[sender];
                        if (senderTotalMessages >= capacity)
                        {
                            sentMessages.Remove(sender);
                            receivedMessages.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }

                        int receiverTotalMessages = sentMessages[receiver] + receivedMessages[receiver];
                        if (receiverTotalMessages >= capacity)
                        {
                            sentMessages.Remove(receiver);
                            receivedMessages.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }

                    }
                    else if (command == "Empty")
                    {
                        string username = parts[1];

                        if (username == "All")
                        {
                            sentMessages.Clear();
                            receivedMessages.Clear();
                        }
                        else
                        {
                            if (sentMessages.ContainsKey(username))
                            {
                                sentMessages.Remove(username);
                                receivedMessages.Remove(username);
                            }

                        }


                    }

                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {sentMessages.Count}");

            receivedMessages = receivedMessages
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var username in receivedMessages)
            {
                Console.WriteLine($"{username} - {username.Value + sentMessages[username.Key]}");

            }
        }
    }
}
