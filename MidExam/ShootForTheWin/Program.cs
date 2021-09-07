using System;
using System.Linq;

namespace ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string command = Console.ReadLine();
            int counter = 0;

            while(command != "End")
            {
                int index = int.Parse(command);
                if (index >= 0 && index < targets.Length)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        int current = targets[index];
                        if (targets[i] != -1 && i != index)
                        {
                            if (targets[i] > current)
                            {
                                targets[i] -= current;
                            }
                            else if (targets[i] <= current)
                            {
                                targets[i] += current;

                            }
                        }
                    }
                    targets[index] = -1;
                    counter++;
                }
                command = Console.ReadLine();
            }
                Console.WriteLine($"Shot targets: {counter} ->" + " " + string.Join(' ', targets));

        }
    }
}
