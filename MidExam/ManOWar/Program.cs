using System;
using System.Linq;

namespace ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int[] warship = Console.ReadLine().Split(">").Select(int.Parse).ToArray();
            int maxHealth = int.Parse(Console.ReadLine());
            int pirateShipSum = 0;
            int warshipSum = 0;
            bool isBroken = false;

            string input = Console.ReadLine();
            while (input != "Retire")
            {
                string[] tokens = input.Split();
                string command = tokens[0];
                if (command == "Fire")
                {
                    int index = int.Parse(tokens[1]);
                    int damage = int.Parse(tokens[2]);
                    if (index < warship.Length && index >= 0)
                    {
                        warship[index] -= damage;
                        if (warship[index] <= 0)
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            isBroken = true;
                            break;
                        }
                    }

                }
                else if (command == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int damage = int.Parse(tokens[3]);
                    if (startIndex >= 0 && startIndex < pirateShip.Length && endIndex > 0 && endIndex < pirateShip.Length)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= damage;
                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                isBroken = true;
                                break;
                            }

                        }

                    }
                }
                else if (command == "Repair")
                {
                    int index = int.Parse(tokens[1]);
                    int health = int.Parse(tokens[2]);
                    if (index >= 0 && index < pirateShip.Length)
                    {
                        pirateShip[index] += health;
                        if (pirateShip[index] > maxHealth)
                        {
                            pirateShip[index] = maxHealth;
                        }
                    }
                }
                else if (command == "Status")
                {
                    int count = 0;
                    foreach (var item in pirateShip)
                    {
                        double temp = maxHealth * 0.2;
                        if (item < temp)
                        {
                            count++;
                        }

                    }
                    Console.WriteLine($"{count} sections need repair.");

                }
                if (isBroken)
                {
                    break;
                }


                input = Console.ReadLine();
            }
            if (!isBroken)
            {
                foreach (var i in pirateShip)
                {
                    pirateShipSum += i;

                }
                foreach (var i in warship)
                {
                    warshipSum += i;

                }
                Console.WriteLine($"Pirate ship status: {pirateShipSum}");
                Console.WriteLine($"Warship status: {warshipSum}");
            }


        }
    }
}
