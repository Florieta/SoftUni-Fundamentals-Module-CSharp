using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int courses = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Ceiling((double)people / courses));

        }
    }
}
