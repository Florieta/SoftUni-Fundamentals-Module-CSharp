using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedForSpeed
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> miliageByCar = new Dictionary<string, int>();
            Dictionary<string, int> fuelByCar = new Dictionary<string, int>();


            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string car = input[0];
                int miliage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);

                miliageByCar.Add(car, miliage);
                fuelByCar.Add(car, fuel);
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] splitted = command.Split(" : ");
                if (splitted[0] == "Drive")
                {
                    string car = splitted[1];
                    int distance = int.Parse(splitted[2]);
                    int fuel = int.Parse(splitted[3]);

                    if (fuelByCar[car] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        miliageByCar[car] += distance;
                        fuelByCar[car] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (miliageByCar[car] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            miliageByCar[car] = 0;
                        }
                    }
                }
                else if (splitted[0] == "Refuel")
                {
                    string car = splitted[1];
                    int fuel = int.Parse(splitted[2]);
                    if (fuelByCar[car] + fuel < 75)
                    {
                        fuelByCar[car] += fuel;
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {75 - fuelByCar[car]} liters");
                        fuelByCar[car] = 75;
                    }
                }
                else if (splitted[0] == "Revert")
                {
                    string car = splitted[1];
                    int kilometers = int.Parse(splitted[2]);
                    if (miliageByCar[car] - kilometers < 10000)
                    {
                        miliageByCar[car] = 10000;
                    }
                    else
                    {
                        miliageByCar[car] -= kilometers;
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }
                }


                command = Console.ReadLine();
            }

            miliageByCar = miliageByCar
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var car in miliageByCar)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {fuelByCar[car.Key]} lt.");

            }
        }

    }
}
