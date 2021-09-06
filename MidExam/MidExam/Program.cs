using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int countLecturesInCourse = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double totalBonus = 0;
            double maxBonus = 0;
            int currentAttendance = 0;

            for (int i = 0; i < countStudents; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                totalBonus = (double)attendance / countLecturesInCourse
                * (5 + additionalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    currentAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {currentAttendance} lectures.");
        }
    }
}
