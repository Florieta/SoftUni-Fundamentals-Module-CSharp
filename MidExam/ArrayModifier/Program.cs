using System;
using System.Linq;

namespace ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string line = Console.ReadLine();

            while (line != "end")
            {
                string[] parts = line.Split().ToArray();
                string command = parts[0];
                if (command == "swap")
                {
                    int index1 = int.Parse(parts[1]);
                    int index2 = int.Parse(parts[2]);
                    int temp = numbers[index1];
                    numbers[index1] = numbers[index2];
                    numbers[index2] = temp;
                    
                }
                else if (command == "multiply")
                {
                    int index1 = int.Parse(parts[1]);
                    int index2 = int.Parse(parts[2]);
                    int temp = numbers[index1] * numbers[index2];
                    numbers[index1] = temp;
                   
                }
                else if (command == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        int temp = numbers[i] - 1;
                        numbers[i] = temp;
                    }
                    
                }
                line = Console.ReadLine();
            }
            
            Console.WriteLine(string.Join(", ", numbers));
            
           
        }
    }
}
