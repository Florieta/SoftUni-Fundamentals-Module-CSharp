using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> studentByCourse = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string course = parts[0];
                string student = parts[1];

                if (!studentByCourse.ContainsKey(course))
                {
                    studentByCourse.Add(course, new List<string>());
                }

                studentByCourse[course].Add(student);
            }

            Dictionary<string, List<string>> sortedCourses = studentByCourse
                .OrderByDescending(c => c.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedCourses)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                //List<string> sortedStudents = kvp.Value.OrderBy(s => s).ToList();

                kvp.Value.Sort();

                foreach (var student in kvp.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
