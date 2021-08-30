using System;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value1 = Console.ReadLine();
            string value2 = Console.ReadLine();

            Console.WriteLine(BiggerValue(type, value1, value2));
        }

        private static string BiggerValue(string type, string value1, string value2)
        {
            int result = 0;
            char resultChar = 'a';
            string resultStr = String.Empty;
            switch (type)
            {
                case "int":
                    int valueOne = int.Parse(value1);
                    int valueTwo = int.Parse(value2);
                    result = Math.Max(valueOne, valueTwo);
                    break;
                case "char":
                    char value1Char = char.Parse(value1);
                    char value2Char = char.Parse(value2);
                    resultChar = (char)Math.Max(value1Char, value2Char);
                    break;
                case "string":
                    result = value1.CompareTo(value2);
                    if (result >= 0)
                    {
                        resultStr = value1;
                    }
                    else if (result <= 0)
                    {
                        resultStr = value2;
                    }

                    break;
            }

            if (type == "int")
            {
                return result.ToString();
            }
            else if (type == "char")
            {
                return resultChar.ToString();
            }
            else if (type == "string")
            {
                return resultStr;
            }
            else
            {
                return "Invalid";
            }
        }
    }
}
