using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            const int breakHour = 3;

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int totalCount = int.Parse(Console.ReadLine());
            int studentsPerHour = first + second + third;

            int neededTimeWithoutBreak = (int)Math.Ceiling(totalCount * 1.0 / studentsPerHour);
            int breakTime = neededTimeWithoutBreak / breakHour;
            if (neededTimeWithoutBreak % breakHour == 0 && breakTime > 0)
            {
                breakTime--;
            }
            Console.WriteLine($"Time needed: {neededTimeWithoutBreak + breakTime}h.");
        }
    }
}
