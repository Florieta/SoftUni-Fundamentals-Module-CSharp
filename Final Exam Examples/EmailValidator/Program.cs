using System;

namespace EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Complete")
            {
                string[] token = input.Split();
                string command = token[0];
                if (command == "Make")
                {
                    if (token[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }

                }
                else if (command == "GetDomain")
                {
                    int count = int.Parse(token[1]);
                    string domain = text.Substring(text.Length - count, count);
                    Console.WriteLine(domain);
                }
                else if (command == "GetUsername")
                {
                    int index = text.IndexOf('@');
                    if (text.Contains('@'))
                    {
                        string username = text.Substring(0, index);  
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The email {text} doesn't contain the @ symbol.");
                    }
                }
                else if (command == "Replace")
                {
                    char symbol = char.Parse(token[1]);
                    if (text.Contains(symbol))
                    {
                        text = text.Replace(symbol, '-');
                    }
                    Console.WriteLine(text);
                }
                else if (command == "Encrypt")
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        Console.Write($"{(int)text[i]}");
                    }
                }

                input = Console.ReadLine();

            }
            Console.WriteLine(text);
        }
    }
}
