using System;
using System.Collections.Generic;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                bool end = false;
                List<Students> students = new List<Students>();

                AddStudents(end, students);

                string filter = Console.ReadLine();
                foreach (var student in students.Where(s => s.Hometown == filter))
                {
                    Console.WriteLine($"{student.FirstName} {student.SecondName} is {student.Age} years old.");
                }
            }

            static void AddStudents(bool end, List<Students> students)
            {
                while (!end)
                {
                    string input = Console.ReadLine();
                    if (input == "end")
                    {
                        end = true;
                        continue;
                    }

                    string[] data = input.Split();
                    Students student = new Students();

                    student.FirstName = data[0];
                    student.SecondName = data[1];
                    student.Age = int.Parse(data[2]);
                    student.Hometown = data[3];

                    students.Add(student);
                }
            }
        }

        class Students
        {
            public string FirstName { get; set; }
            public string SecondName { get; set; }
            public int Age { get; set; }
            public string Hometown { get; set; }
        }
    }
}
