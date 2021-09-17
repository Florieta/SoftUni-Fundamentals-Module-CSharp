using System;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();


            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Generate")
                {
                    break;
                }

                string[] parts = line.Split(">>>");
                string command = parts[0];

                if (command == "Contains")
                {
                    string substring = parts[1];
                    if (text.Contains(substring))
                    {
                        Console.WriteLine($"{text} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command == "Flip")
                {
                    string casing = parts[1];
                    int startIndex = int.Parse(parts[2]);
                    int endIndex = int.Parse(parts[3]);
                    string substring = text.Substring(startIndex, endIndex - startIndex);
                    string replacement = substring.ToUpper();
                    // string replacement = casing == "Upper" ? substring.ToUpper() : substing.ToLower();
                    if (casing == "Lower")
                    {
                        replacement = substring.ToLower();
                    }
                    text = text.Replace(substring, replacement);
                    Console.WriteLine(text);
                }
                else if (command == "Slice")
                {
                    int startIndex = int.Parse(parts[1]);
                    int endIndex = int.Parse(parts[2]);
                    text = text.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(text);
                }
            }
            Console.WriteLine($"Your activation key is: {text}");
        }
    }
}
