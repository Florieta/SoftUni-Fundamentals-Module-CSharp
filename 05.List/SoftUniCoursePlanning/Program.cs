using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line = Console.ReadLine();

            while (line != "course start")
            {
                string[] parts = line.Split(":");
                string command = parts[0];
                if (command == "Add")
                {
                    string lesson = parts[1];
                    if (!courses.Contains(lesson))
                    {
                        courses.Add(lesson);
                    }
                    
                }
                else if (command == "Insert")
                {
                    string lesson = parts[1];
                    int index = int.Parse(parts[2]);
                    if (!courses.Contains(lesson))
                    {
                        if (index >= 0 && index < courses.Count)
                        {
                            courses.Insert(index, lesson);
                        }
                    }
                    
                }
                else if (command == "Remove")
                {
                    string lesson = parts[1];
                    if (courses.Contains(lesson))
                    {
                        int index = courses.IndexOf(lesson);

                        if (index + 1 < courses.Count)
                        {
                            if (courses[index + 1] == $"{lesson}-Exercise")
                            {
                                courses.RemoveRange(index, 2);
                            }
                            else
                            {
                                courses.Remove(lesson);
                            }
                        }
                        else
                        {
                            courses.Remove(lesson);
                        }
                    }
                }
                else if (command == "Swap")
                {
                    string firstLesson = parts[1];
                    string secondLesson = parts[2];
                    if (courses.Contains(firstLesson) && courses.Contains(secondLesson))
                    {
                        int firstTitleIndex = courses.IndexOf(firstLesson);
                        int secondTitleIndex = courses.IndexOf(secondLesson);

                        courses[firstTitleIndex] = secondLesson;
                        courses[secondTitleIndex] = firstLesson;
                        if (firstTitleIndex + 1 < courses.Count && secondTitleIndex + 1 < courses.Count)
                        {
                            if (courses[firstTitleIndex + 1] == $"{firstLesson}-Exercise" && courses[secondTitleIndex + 1] == $"{secondLesson}-Exercise")
                            {
                                string temp = courses[secondTitleIndex + 1];
                                courses[secondTitleIndex + 1] = courses[firstTitleIndex + 1];
                                courses[firstTitleIndex + 1] = temp;
                            }
                            else if (courses[firstTitleIndex + 1] == $"{firstLesson}-Exercise")
                            {
                                courses.Insert(secondTitleIndex + 1, courses[firstTitleIndex + 1]);

                                if (secondTitleIndex > firstTitleIndex)
                                {
                                    courses.RemoveAt(firstTitleIndex + 1);
                                }
                                else if (secondTitleIndex < firstTitleIndex)
                                {
                                    courses.RemoveAt(firstTitleIndex + 2);
                                }

                            }
                            else if (courses[secondTitleIndex + 1] == $"{secondLesson}-Exercise")
                            {
                                courses.Insert(firstTitleIndex + 1, courses[secondTitleIndex + 1]);

                                if (firstTitleIndex < secondTitleIndex)
                                {
                                    courses.RemoveAt(secondTitleIndex + 2);
                                }
                                else if (firstTitleIndex > secondTitleIndex)
                                {
                                    courses.RemoveAt(secondTitleIndex + 1);
                                }
                            }
                        }
                        else if (firstTitleIndex + 1 < courses.Count)
                        {
                            if (courses[firstTitleIndex + 1] == $"{firstLesson}-Exercise")
                            {
                                courses.Insert(secondTitleIndex + 1, courses[firstTitleIndex + 1]);

                                if (secondTitleIndex > firstTitleIndex)
                                {
                                    courses.RemoveAt(firstTitleIndex + 1);
                                }
                                else if (secondTitleIndex < firstTitleIndex)
                                {
                                    courses.RemoveAt(firstTitleIndex + 2);
                                }
                            }
                        }
                        else if (secondTitleIndex + 1 < courses.Count)
                        {
                            if (courses[secondTitleIndex + 1] == $"{secondLesson}-Exercise")
                            {
                                courses.Insert(firstTitleIndex + 1, courses[secondTitleIndex + 1]);

                                if (firstTitleIndex < secondTitleIndex)
                                {
                                    courses.RemoveAt(secondTitleIndex + 2);
                                }
                                else if (firstTitleIndex > secondTitleIndex)
                                {
                                    courses.RemoveAt(secondTitleIndex + 1);
                                }
                            }
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    string lesson = parts[1];

                    if (courses.Contains(lesson))
                    {
                        int index = courses.IndexOf(lesson);

                        if (index + 1 < courses.Count)
                        {
                            if (courses[index + 1] != $"{lesson}-Exercise")
                            {
                                courses.Insert(index + 1, $"{lesson}-Exercise");
                            }
                        }
                        else
                        {
                            courses.Add($"{lesson}-Exercise");
                        }
                    }
                    else
                    {
                        courses.Add(lesson);
                        courses.Add($"{lesson}-Exercise");
                    }
                }

                line = Console.ReadLine();
            }
            for (int index = 0; index < courses.Count; index++)
            {
                Console.WriteLine($"{index + 1}.{courses[index]}");
            }
        }
    }
}
