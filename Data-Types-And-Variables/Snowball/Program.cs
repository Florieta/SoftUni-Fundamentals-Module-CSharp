using System;
using System.Numerics;

namespace Snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            BigInteger biggestValue = 0;
            int largestSnow = 0;
            int largestTime = 0;
            int largestQuality = 0;

            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger currentValue = BigInteger.Pow((snow / time), quality);
                if (currentValue > biggestValue)
                {
                    biggestValue = currentValue;
                    largestSnow = snow;
                    largestTime = time;
                    largestQuality = quality;
                }
            }
            Console.WriteLine($"{largestSnow} : {largestTime} = {biggestValue} ({largestQuality})");
        }
    }
}
