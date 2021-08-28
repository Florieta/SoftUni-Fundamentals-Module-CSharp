using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string largestKeg = string.Empty;
            double largestVolume = 0;


            for (int i = 0; i < n; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > largestVolume)
                {
                    largestVolume = volume;
                    largestKeg = kegName;
                }
            }
            Console.WriteLine(largestKeg);
        }
    }
}
