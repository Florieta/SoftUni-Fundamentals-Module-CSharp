using System;
using System.Collections.Generic;
using System.Linq;


namespace HeroesOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, int> heroesHP = new Dictionary<string, int>();
            Dictionary<string, int> heroesMP = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int hp = int.Parse(splitted[1]);
                int mp = int.Parse(splitted[2]);

                heroesHP.Add(name, hp);
                heroesMP.Add(name, mp);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command.Contains("CastSpell"))
                {
                    var splitted = command.Split(" - ");
                    string name = splitted[1];
                    int mpNeeded = int.Parse(splitted[2]);
                    string spellName = splitted[3];

                    if (heroesMP[name] < mpNeeded)
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                    else
                    {
                        heroesMP[name] -= mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroesMP[name]} MP!");
                    }
                }
                else if (command.Contains("TakeDamage"))
                {
                    var splitted = command.Split(" - ");
                    string name = splitted[1];
                    int damage = int.Parse(splitted[2]);
                    string attacker = splitted[3];

                    if (heroesHP[name] <= damage)
                    {
                        heroesHP[name] = 0;
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                    }
                    else
                    {
                        heroesHP[name] -= damage;
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroesHP[name]} HP left!");
                    }
                }
                else if (command.Contains("Recharge"))
                {
                    var splitted = command.Split(" - ");
                    string name = splitted[1];
                    int amount = int.Parse(splitted[2]);
                    if (heroesMP[name] + amount > 200)
                    {

                        Console.WriteLine($"{name} recharged for {200 - heroesMP[name]} MP!");
                        heroesMP[name] = 200;
                    }
                    else
                    {
                        heroesMP[name] += amount;
                        Console.WriteLine($"{name} recharged for {amount} MP!");

                    }

                }

                else if (command.Contains("Heal"))
                {
                    var splitted = command.Split(" - ");
                    string name = splitted[1];
                    int amount = int.Parse(splitted[2]);
                    if (heroesHP[name] + amount > 100)
                    {

                        Console.WriteLine($"{name} healed for {100 - heroesHP[name]} HP!");
                        heroesHP[name] = 100;
                    }
                    else
                    {
                        heroesHP[name] += amount;
                        Console.WriteLine($"{name} healed for {amount} HP!");

                    }
                    
                }
                command = Console.ReadLine();
            }

            heroesHP = heroesHP
                .Where(h => h.Value > 0)
                .OrderByDescending(h => h.Value)
                .ThenBy(h => h.Key)
                .ToDictionary(h => h.Key, h => h.Value);

            foreach (var hero in heroesHP)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value}");
                Console.WriteLine($"  MP: {heroesMP[hero.Key]}");

            }
        }
    }
}
