using System;

namespace Weaponsmith
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] particles = Console.ReadLine().Split("|");
            string input = Console.ReadLine();

            while (input != "Done")
            {
                string[] splitted = input.Split();
                if (splitted[0] == "Move")
                {
                    int index = int.Parse(splitted[2]);
                    if (splitted[1] == "Left")
                    {

                        if (index > 0 && index < particles.Length)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index - 1];
                            particles[index - 1] = temp;
                        }

                    }
                    if (splitted[1] == "Right")
                    {
                        if (index >= 0 && index < particles.Length - 1)
                        {
                            string temp = particles[index];
                            particles[index] = particles[index + 1];
                            particles[index + 1] = temp;
                        }

                    }
                }
                if (splitted[0] == "Check")
                {
                    int sign = 0;
                    if (splitted[1] == "Odd")
                    {
                        sign = 1;
                    }
                    for (int i = 0; i < particles.Length; i++)
                    {
                        if (i % 2 == sign)
                        {
                            Console.Write(particles[i] + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine($"You crafted {string.Join(" ", particles)}!");
        }
    }
}
