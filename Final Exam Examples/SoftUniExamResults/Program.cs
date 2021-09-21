using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> pointsByStudent = new Dictionary<string, int>();
            Dictionary<string, int> submissionByLanguage = new Dictionary<string, int>();

            while (input != "exam finished")
            {
                string[] token = input.Split("-");
                string username = token[0];
                string language = token[1];

                if (language == "banned")
                {
                    pointsByStudent.Remove(username);
                    input = Console.ReadLine();
                    continue;
                }

                int point = int.Parse(token[2]);
                if (!pointsByStudent.ContainsKey(username))
                {
                    pointsByStudent.Add(username, point);
                }
                else
                {
                    if (pointsByStudent[username] < point)
                    {
                        pointsByStudent[username] = point;
                    }
                }

                if (!submissionByLanguage.ContainsKey(language))
                {
                    submissionByLanguage.Add(language, 1);
                }
                else
                {
                    submissionByLanguage[language]++;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var item in pointsByStudent.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in submissionByLanguage.OrderByDescending(l => l.Value).ThenBy(l => l.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }

    }
}
