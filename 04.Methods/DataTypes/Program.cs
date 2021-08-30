using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = string.Empty;

            if (input == "int")
            {
                int intInput = int.Parse(Console.ReadLine());
                final = InputOperation(intInput);
            }
            else if (input == "real")
            {
                double doubleInput = double.Parse(Console.ReadLine());
                final = $"{InputOperation(doubleInput):F2}";
            }
            else if (input == "string")
            {
                string stringInput = Console.ReadLine();
                final = InputOperation(stringInput);
            }

            Console.WriteLine(final);
        }

        private static string InputOperation(string input)
        {
            return $"${input}$";
        }

        private static double InputOperation(double input)
        {
            return input * 1.5;
        }

        private static string InputOperation(int input)
        {
            return (input * 2).ToString();
        }
    }
}
