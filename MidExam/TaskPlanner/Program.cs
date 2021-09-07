using System;
using System.Collections.Generic;
using System.Linq;

namespace TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            int completedTasks = 0;
            int incompletedTasks = 0;
            int droppedTasks = 0;

            while (input != "End")
            {
                string[] parts = input.Split();
                string command = parts[0];
                if (command == "Complete")
                {
                    int index = int.Parse(parts[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = 0;
                    }
                }
                else if (command == "Change")
                {
                    int index = int.Parse(parts[1]);
                    int time = int.Parse(parts[2]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        if (time >= 1 && time <= 5)
                        {
                            tasks[index] = time;
                        }
                       
                    }
                }
                else if (command == "Drop")
                {
                    int index = int.Parse(parts[1]);
                    if (index >= 0 && index < tasks.Count)
                    {
                        tasks[index] = -1;
                    }
                }
                else if (command == "Count")
                {
                    if (parts[1] == "Completed")
                    {
                        List<int> completed = tasks.FindAll(x => x == 0);
                        completedTasks = completed.Count;
                        Console.WriteLine(completedTasks);
                    }
                    else if (parts[1] == "Incomplete")
                    {
                        List<int> incompleted = tasks.FindAll(x => x > 0);
                        incompletedTasks = incompleted.Count;
                        Console.WriteLine(incompletedTasks);
                    }
                    else if (parts[1] == "Dropped")
                    {
                        List<int> dropped = tasks.FindAll(x => x == -1);
                        droppedTasks = dropped.Count;
                        Console.WriteLine(droppedTasks);
                    }

                }
                input = Console.ReadLine();
            }
            List<int> incompleteItems = tasks.FindAll(x => x > 0);
            Console.WriteLine(string.Join(" ", incompleteItems));

        }
    }
}
