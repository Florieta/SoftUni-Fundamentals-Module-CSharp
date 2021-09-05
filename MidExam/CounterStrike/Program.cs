using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int count = 0;

            while (command != "End of battle")
            {
                int distance = int.Parse(command);
                if (energy < 0)
                {
                    break;
                }
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }
                energy -= distance;
                count++;
                if (count % 3 == 0)
                {
                    energy += count;
                }

               
                command = Console.ReadLine();
            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
            }
        }
    }
}
