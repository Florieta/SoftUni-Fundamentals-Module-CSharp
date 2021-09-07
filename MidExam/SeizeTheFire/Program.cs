using System;
using System.Collections.Generic;
using System.Linq;

namespace SeizeTheFire
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fire = Console.ReadLine().Split("#").ToList();
            int water = int.Parse(Console.ReadLine());
            double effort = 0;
            int totalFire = 0;
            List<int> cells = new List<int>();
            for (int i = 0; i < fire.Count; i++)
            {
                string type = fire[i].Split(" = ")[0];
                int cell = int.Parse(fire[i].Split(" = ")[1]);
                if (type == "High" && cell >= 81 && cell <= 125 && water >= cell)
                {
                    cells.Add(cell);
                    effort += cell * 0.25;
                    totalFire += cell;
                    water -= cell;
                }
                if (type == "Medium" && cell >= 51 && cell <= 80 && water >= cell)
                {
                    cells.Add(cell);
                    effort += cell * 0.25;
                    totalFire += cell;
                    water -= cell;
                }
                if (type == "Low" && cell >= 1 && cell <= 50 && water >= cell)
                {
                    cells.Add(cell);
                    effort += cell * 0.25;
                    totalFire += cell;
                    water -= cell;
                }
            }
            Console.WriteLine("Cells:");
            foreach (var cell in cells)
            {
                Console.WriteLine($"- {cell}");
            }
            Console.WriteLine($"Effort: {effort:F2}");
            Console.WriteLine($"Total Fire: {totalFire}");
        }
    }

}
