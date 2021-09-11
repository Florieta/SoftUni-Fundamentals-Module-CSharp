using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToArray();

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }

            // Console.ReaLine().Split().Where(word => word.Length % 2 == 0).ToList().Foreach(word => Console.WriteLine(word));
        }
    }
}
