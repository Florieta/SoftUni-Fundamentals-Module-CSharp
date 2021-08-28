using System;

namespace PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int halfOfN = N / 2;
            int targets = 0;

            while (N >= M)
            {
                targets++;
                N -= M;
                if (halfOfN == N && Y > 0)
                {
                    N /= Y;
                }

                

            }
            Console.WriteLine(N);
            Console.WriteLine(targets);
        }
    }
}
