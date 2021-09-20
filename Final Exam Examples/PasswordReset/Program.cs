using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split();
                string command = tokens[0];

                if (command == "Done")
                {
                    break;
                }
                else if (command == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (command == "Cut")
                {
                    int index = int.Parse(tokens[1]);
                    int length = int.Parse(tokens[2]);
                    password = password.Remove(index, length);
                    Console.WriteLine(password);

                }
                else if (command == "Substitute")
                {
                    string substring = tokens[1];
                    string substitute = tokens[2];
                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);

                    }
                }
            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
